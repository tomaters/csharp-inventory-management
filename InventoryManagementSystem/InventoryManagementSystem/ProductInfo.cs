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
    public partial class ProductInfo : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\csharp\MS Database\dbms.mdf;Integrated Security = True; Connect Timeout = 30");
        SqlCommand command = new SqlCommand();
        SqlDataReader sqlDataReader;
        public ProductInfo()
        {
            InitializeComponent();
            LoadCategories();
        }
        // load categories in database for dropdown on addition
        public void LoadCategories()
        {
            productCategoryComboBox.Items.Clear();
            command = new SqlCommand("SELECT categoryName FROM categories", connection);
            connection.Open();
            sqlDataReader = command.ExecuteReader();
            while(sqlDataReader.Read())
            {
                productCategoryComboBox.Items.Add(sqlDataReader[0].ToString());
            }
            sqlDataReader.Close();
            connection.Close();
        }
        private void usernameTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void updateUserInfoButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this data?", "Updating", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // in CustomersForm.cs, customerIdLabel.Text is set to the respective customerId
                    command = new SqlCommand("UPDATE products SET productName=@productName, productQuantity=@productQuantity, productPrice=@productPrice, productDescription=@productDescription, productCategory=@productCategory WHERE productId LIKE '" + productIdLabel.Text + "'", connection);
                    command.Parameters.AddWithValue("@productName", productNameTextbox.Text);
                    command.Parameters.AddWithValue("@productQuantity", productQuantityTextbox.Text);
                    command.Parameters.AddWithValue("@productPrice", productPriceTextbox.Text);
                    command.Parameters.AddWithValue("@productDescription", productDescriptionTextbox.Text);
                    command.Parameters.AddWithValue("@productCategory", productCategoryComboBox.Text);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Product data successfully updated");
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void saveUserInfoButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this data?", "Saving", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    command = new SqlCommand("INSERT INTO products (productName, productQuantity, productPrice, productDescription, productCategory) " +
                        "VALUES(@productName, @productQuantity, @productPrice, @productDescription, @productCategory)", connection);
                    command.Parameters.AddWithValue("@productName", productNameTextbox.Text);
                    command.Parameters.AddWithValue("@productQuantity", productQuantityTextbox.Text);
                    command.Parameters.AddWithValue("@productPrice", productPriceTextbox.Text);
                    command.Parameters.AddWithValue("@productDescription", productDescriptionTextbox.Text);
                    command.Parameters.AddWithValue("@productCategory", productCategoryComboBox.Text);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Product data successfully saved");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearUserInfoButton_Click(object sender, EventArgs e)
        {
            Clear();
            saveProductInfoButton.Enabled = true;
            updateProductInfoButton.Enabled = false;
        }

        public void Clear()
        {
            productNameTextbox.Clear();
            productQuantityTextbox.Clear();
            productPriceTextbox.Clear();
            productDescriptionTextbox.Clear();
        }
    }
}
