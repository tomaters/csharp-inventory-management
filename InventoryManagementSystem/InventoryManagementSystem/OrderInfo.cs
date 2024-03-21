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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        // CellClick, not CellContentClick to apply inputs if anywhere in the cell is clicked
        private void dataGridViewCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            customerIdTextbox.Text = dataGridViewCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
            customerNameTextbox.Text = dataGridViewCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        // field variable stores quantity of product to compare to the selected quantity (quantityUpDown) for order
        int quantity = 0;
        private void dataGridViewProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            productIdTextbox.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
            productNameTextbox.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
            priceTextbox.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
            // store quantity value
            quantity = Convert.ToInt16(dataGridViewProduct.Rows[e.RowIndex].Cells[3].Value.ToString());
        }

        private void quantityUpDown_ValueChanged(object sender, EventArgs e)
        {
            // return warning of selected quantity is greater than existing quantity
            if(Convert.ToInt16(quantityUpDown.Value) > quantity)
            {
                MessageBox.Show("Not enough quantity in stock!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // decrease quantity back
                quantityUpDown.Value = quantityUpDown.Value - 1;
                return;
            }
            // total is calculated by selected quantity (quantityUpDown) * price of product
            int total = Convert.ToInt16(priceTextbox.Text) * Convert.ToInt16(quantityUpDown.Value);
            totalTextbox.Text = total.ToString();
        }

        private void clearOrderInfoButton_Click(object sender, EventArgs e)
        {
            Clear();
            saveOrderInfoButton.Enabled = true;
            updateOrderInfoButton.Enabled = false;
        }
        public void Clear()
        {
            customerIdTextbox.Clear();
            customerNameTextbox.Clear();
            productIdTextbox.Clear();
            productNameTextbox.Clear();
            priceTextbox.Clear();
            totalTextbox.Clear();
            quantityUpDown.ResetText();
            orderDatePicker.ResetText();
        }

        private void totalTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveOrderInfoButton_Click(object sender, EventArgs e)
        {
            try
            {
                // make sure customer and product is selected before saving, quantity is not 0
                if(customerIdTextbox.Text == "")
                {
                    MessageBox.Show("Please select a customer!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if(productIdTextbox.Text == "")
                {
                    MessageBox.Show("Please select a product!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if(quantityUpDown.Value <= 0)
                {
                    MessageBox.Show("Please enter a quantity!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Would you like to add this order?", "Saving", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    command = new SqlCommand("INSERT INTO orders (orderDate, productId, customerId, quantity, price, total) " +
                        "VALUES(@orderDate, @productId, @customerId, @quantity, @price, @total)", connection);
                    command.Parameters.AddWithValue("@orderDate", orderDatePicker.Value);
                    command.Parameters.AddWithValue("@productId", productIdTextbox.Text);
                    command.Parameters.AddWithValue("@customerId", customerIdTextbox.Text);
                    command.Parameters.AddWithValue("@quantity", quantityUpDown.Value);
                    command.Parameters.AddWithValue("@price", priceTextbox.Text);
                    command.Parameters.AddWithValue("@total", totalTextbox.Text);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Order successfully added");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
