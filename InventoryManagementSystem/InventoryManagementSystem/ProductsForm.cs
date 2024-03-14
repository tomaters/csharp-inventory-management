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
    public partial class ProductsForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\csharp\MS Database\dbms.mdf;Integrated Security = True; Connect Timeout = 30");
        SqlCommand command = new SqlCommand();
        SqlDataReader sqlDataReader;
        public ProductsForm()
        {
            InitializeComponent();
            LoadProducts();
        }
        public void LoadProducts()
        {
            dataGridViewProduct.Rows.Clear();
            command = new SqlCommand("SELECT * FROM products", connection);
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
        private void dataGridViewProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridViewProduct.Columns[e.ColumnIndex].Name;
            if (colName == "EditProduct")
            {
                ProductInfo productInfo = new ProductInfo();
                // set customerIdLabel text to the stored customerId value at the respective index
                productInfo.productIdLabel.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
                productInfo.productNameTextbox.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
                productInfo.productQuantityTextbox.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
                productInfo.productPriceTextbox.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
                productInfo.productDescriptionTextbox.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[5].Value.ToString();
                productInfo.productCategoryComboBox.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[6].Value.ToString();
                productInfo.saveProductInfoButton.Enabled = false;
                productInfo.updateProductInfoButton.Enabled = true;
                productInfo.ShowDialog();
            }
            else if (colName == "DeleteProduct")
            {
                if (MessageBox.Show("Do you want to delete this product?", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    connection.Open();
                    command = new SqlCommand("DELETE FROM products WHERE productId LIKE '" + dataGridViewProduct.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Record successfully deleted");
                }
            }
            LoadProducts();
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            ProductInfo productInfoForm = new ProductInfo();
            productInfoForm.saveProductInfoButton.Enabled = true;
            productInfoForm.updateProductInfoButton.Enabled = false;
            productInfoForm.ShowDialog();
            LoadProducts();
        }
    }
}
