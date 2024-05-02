using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InventoryManagementSystem
{
    public partial class CustomerInfo : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\csharp\MS Database\dbms.mdf;Integrated Security = True; Connect Timeout = 30");
        SqlCommand command = new SqlCommand();
        public CustomerInfo()
        {
            InitializeComponent();
        }
        private void clearCustomerInfoButton_Click(object sender, EventArgs e)
        {
            Clear();
            saveCustomerInfoButton.Enabled = true;
            updateCustomerInfoButton.Enabled = false;
        }
        public void Clear()
        {
            nameTextbox.Clear();
            emailTextbox.Clear();
            phoneTextbox.Clear();
        }

        private void saveCustomerInfoButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this data?", "Saving", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // customerId column defined as IDENTITY, so it increments automatically 
                    command = new SqlCommand("INSERT INTO customers (customerName, customerEmail, customerPhone) VALUES(@name, @email, @phone)", connection);
                    command.Parameters.AddWithValue("@name", nameTextbox.Text);
                    command.Parameters.AddWithValue("@email", emailTextbox.Text);
                    command.Parameters.AddWithValue("@phone", phoneTextbox.Text);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Customer data successfully saved");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateCustomerInfoButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this data?", "Updating", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // in CustomersForm.cs, customerIdLabel.Text is set to the respective customerId
                    command = new SqlCommand("UPDATE customers SET customerName=@name, customerEmail=@email, customerPhone=@phone WHERE customerId LIKE '" + customerIdLabel.Text +  "'", connection);
                    command.Parameters.AddWithValue("@name", nameTextbox.Text);
                    command.Parameters.AddWithValue("@email", emailTextbox.Text);
                    command.Parameters.AddWithValue("@phone", phoneTextbox.Text);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Customer data successfully updated");
                    this.Dispose();
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
    }
}
