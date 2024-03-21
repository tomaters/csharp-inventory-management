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
            command = new SqlCommand("SELECT * FROM orders WHERE CONCAT(orderId, orderDate, productId, customerId, quantity, price, total) LIKE '%" + searchOrderTextbox.Text + "%'", connection);
            connection.Open();
            sqlDataReader = command.ExecuteReader();

            int count = 0;
            try
            {
                while (sqlDataReader.Read())
                {
                    count++;
                    dataGridViewOrder.Rows.Add(count, sqlDataReader[0].ToString(), sqlDataReader[1].ToString(), sqlDataReader[2].ToString(), sqlDataReader[3].ToString(),
                        sqlDataReader[4].ToString(), sqlDataReader[5].ToString(), sqlDataReader[6].ToString());
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
            if (colName == "EditOrder")
            {
                OrderInfo orderInfo = new OrderInfo();

                orderInfo.orderDatePicker.Value = dataGridViewOrder.Rows[e.RowIndex].Cells[3].;

                orderInfo.saveOrderInfoButton.Enabled = false;
                orderInfo.updateOrderInfoButton.Enabled = true;
                orderInfo.ShowDialog();
            }
            else if (colName == "DeleteOrder")
            {
                if (MessageBox.Show("Do you want to delete this order?", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    connection.Open();
                    command = new SqlCommand("DELETE FROM orders WHERE orderId LIKE '" + dataGridViewOrder.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Record successfully deleted");
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
        }

        private void searchOrderTextbox_TextChanged(object sender, EventArgs e)
        {
            LoadOrders();
        }
    }
}
