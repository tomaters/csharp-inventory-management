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
    public partial class CategoryInfo : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\csharp\MS Database\dbms.mdf;Integrated Security = True; Connect Timeout = 30");
        SqlCommand command = new SqlCommand();
        public CategoryInfo()
        {
            InitializeComponent();
        }

        private void categoryInformationLabel_Click(object sender, EventArgs e)
        {

        }

        private void saveCategoryInfoButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this data?", "Saving", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // categoryId column defined as IDENTITY, so it increments automatically 
                    command = new SqlCommand("INSERT INTO categories (categoryName) VALUES(@categoryName)", connection);
                    command.Parameters.AddWithValue("@categoryName", categoryNameTextbox.Text);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Category data successfully saved");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void CategoryInfo_Load(object sender, EventArgs e)
        {

        }

        private void updateCategoryInfoButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this data?", "Updating", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // in CustomersForm.cs, customerIdLabel.Text is set to the respective customerId
                    command = new SqlCommand("UPDATE categories SET categoryName=@categoryName WHERE categoryId LIKE '" + categoryIdLabel.Text + "'", connection);
                    command.Parameters.AddWithValue("@categoryName", categoryNameTextbox.Text);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Category data successfully updated");
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearCategoryInfoButton_Click(object sender, EventArgs e)
        {
            categoryNameTextbox.Clear();
            saveCategoryInfoButton.Enabled = true;
            updateCategoryInfoButton.Enabled = false;
        }
    }
}
