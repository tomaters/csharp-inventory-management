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
    public partial class CategoriesForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\csharp\MS Database\dbms.mdf;Integrated Security = True; Connect Timeout = 30");
        SqlCommand command = new SqlCommand();
        SqlDataReader sqlDataReader;
        public CategoriesForm()
        {
            InitializeComponent();
            LoadCategories();
        }
        public void LoadCategories()
        {
            dataGridViewCategory.Rows.Clear();
            command = new SqlCommand("SELECT * FROM categories", connection);
            connection.Open();
            sqlDataReader = command.ExecuteReader();

            int count = 0;
            try
            {
                while (sqlDataReader.Read())
                {
                    count++;
                    dataGridViewCategory.Rows.Add(count, sqlDataReader[0].ToString(), sqlDataReader[1].ToString());
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
        private void dataGridViewCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridViewCategory.Columns[e.ColumnIndex].Name;
            if (colName == "EditCategory")
            {
                CategoryInfo categoryInfo = new CategoryInfo();
                // set categoryIdLabel text to the stored customerId value at the respective index
                categoryInfo.categoryIdLabel.Text = dataGridViewCategory.Rows[e.RowIndex].Cells[1].Value.ToString();
                categoryInfo.categoryNameTextbox.Text = dataGridViewCategory.Rows[e.RowIndex].Cells[2].Value.ToString();
                categoryInfo.saveCategoryInfoButton.Enabled = false;
                categoryInfo.updateCategoryInfoButton.Enabled = true;
                categoryInfo.ShowDialog();
            }
            else if (colName == "DeleteCategory")
            {
                if (MessageBox.Show("Do you want to delete this category?", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    connection.Open();
                    command = new SqlCommand("DELETE FROM categories WHERE categoryId LIKE '" + dataGridViewCategory.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Record successfully deleted");
                }
            }
            LoadCategories();
        }

        private void addCategoryButton_Click(object sender, EventArgs e)
        {
            CategoryInfo categoryInfoForm = new CategoryInfo();
            categoryInfoForm.saveCategoryInfoButton.Enabled = true;
            categoryInfoForm.updateCategoryInfoButton.Enabled = false;
            categoryInfoForm.ShowDialog();
            LoadCategories();
        }
    }
}
