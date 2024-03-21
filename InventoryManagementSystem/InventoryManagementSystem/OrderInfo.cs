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
    public partial class OrderInfo : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\csharp\MS Database\dbms.mdf;Integrated Security = True; Connect Timeout = 30");
        SqlCommand command = new SqlCommand();
        SqlDataReader sqlDataReader;

        public void LoadCustomers()
        {
            dataGridViewCustomer.Rows.Clear();
            command = new SqlCommand("SELECT customerId, customerName FROM customers WHERE CONCAT(customerId, customerName) LIKE '%" + searchCustomerTextbox.Text + "%'", connection);
            connection.Open();
            sqlDataReader = command.ExecuteReader();

            int count = 0;
            try
            {
                while (sqlDataReader.Read())
                {
                    count++;
                    dataGridViewCustomer.Rows.Add(count, sqlDataReader[0].ToString(), sqlDataReader[1].ToString());
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
        public void LoadProducts()
        {
            dataGridViewProduct.Rows.Clear();
            command = new SqlCommand("SELECT * FROM products WHERE CONCAT(productId, productName, productQuantity, productPrice, productDescription, productCategory) LIKE '%" + searchProductTextbox.Text + "%'", connection);
            connection.Open();
            sqlDataReader = command.ExecuteReader();

            int count = 0;
            try
            {
                while (sqlDataReader.Read())
                {
                    count++;
                    dataGridViewProduct.Rows.Add(count, sqlDataReader[0].ToString(), sqlDataReader[1].ToString(), sqlDataReader[2].ToString(), sqlDataReader[3].ToString(),
                        sqlDataReader[4].ToString(), sqlDataReader[5].ToString());
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
        public OrderInfo()
        {
            InitializeComponent();
            LoadCustomers();
            LoadProducts();
        }

        private void OrderInfo_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void productsButton_Click(object sender, EventArgs e)
        {

        }

        private void searchProductTextbox_TextChanged(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void searchCustomerTextbox_TextChanged(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void exitButton_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
