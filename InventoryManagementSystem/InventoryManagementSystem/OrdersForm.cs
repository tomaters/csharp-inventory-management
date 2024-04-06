using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class OrdersForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\csharp\MS Database\dbms.mdf;Integrated Security = True; Connect Timeout = 30");
        SqlCommand command = new SqlCommand();
        SqlDataReader sqlDataReader;
        public OrdersForm()
        {
            InitializeComponent();
            LoadOrders();
        }
        public void LoadOrders()
        {
            dataGridViewOrder.Rows.Clear();
            // assign aliases for tables: orders as O, products as P, customers as C
            // O has columns from primary keys of P (productId) and C (customerId)
            // use JOIN to retrieve product and customer names from tables where records match from these columns
            // keep search function via WHERE CONCAT clause
            command = new SqlCommand("SELECT orderId, orderDate, O.productId, P.productName, O.customerId, C.customerName, quantity, price, total " +
                "FROM orders AS O " +
                "JOIN customers AS C ON O.customerId = C.customerId " +
                "JOIN products AS P ON O.productId = P.productId " +
                "WHERE CONCAT(orderId, orderDate, O.productId, P.productName, O.customerId, C.customerName, quantity, price, total) LIKE '%" + searchOrderTextbox.Text + "%'", connection);
            connection.Open();
            sqlDataReader = command.ExecuteReader();

            int count = 0;
            try
            {
                while (sqlDataReader.Read())
                {
                    count++;
                    dataGridViewOrder.Rows.Add(count, sqlDataReader[0].ToString(), Convert.ToDateTime(sqlDataReader[1].ToString()).ToString("dd/MM/yyyy"), sqlDataReader[2].ToString(), sqlDataReader[3].ToString(),
                        sqlDataReader[4].ToString(), sqlDataReader[5].ToString(), sqlDataReader[6].ToString(), sqlDataReader[7].ToString(), sqlDataReader[8].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlDataReader.Close();
                connection.Close();
            }
        }
        private void dataGridViewOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridViewOrder.Columns[e.ColumnIndex].Name;
            if (colName == "DeleteOrder")
            {
                if (MessageBox.Show("Do you want to delete this order?", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    connection.Open();
                    command = new SqlCommand("DELETE FROM orders WHERE orderId LIKE '" + dataGridViewOrder.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Record successfully deleted");
                    
                    // change quantity in DB to new quantity
                    command = new SqlCommand("UPDATE products SET productQuantity = (productQuantity + @productQuantity) WHERE productId LIKE '" + dataGridViewOrder.Rows[e.RowIndex].Cells[3].Value.ToString() + "' ", connection);
                    
                    command.Parameters.AddWithValue("@productQuantity", Convert.ToInt16(dataGridViewOrder.Rows[e.RowIndex].Cells[5].Value.ToString())); ;
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            LoadOrders();
        }

        private void addOrderButton_Click(object sender, EventArgs e)
        {
            OrderInfo orderInfoForm = new OrderInfo();
            orderInfoForm.saveOrderInfoButton.Enabled = true;
            orderInfoForm.updateOrderInfoButton.Enabled = false;
            orderInfoForm.ShowDialog();
            LoadOrders();
        }

        private void searchOrderTextbox_TextChanged(object sender, EventArgs e)
        {
            LoadOrders();
        }
    }
}
