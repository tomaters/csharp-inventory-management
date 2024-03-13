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
    public partial class CustomersForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\csharp\MS Database\dbms.mdf;Integrated Security = True; Connect Timeout = 30");
        SqlCommand command = new SqlCommand();
        SqlDataReader sqlDataReader;
        public CustomersForm()
        {
            InitializeComponent();
            LoadCustomers();
        }

        public void LoadCustomers()
        {
            dataGridViewCustomer.Rows.Clear();
            command = new SqlCommand("SELECT * FROM customers", connection);
            connection.Open();
            sqlDataReader = command.ExecuteReader();

            int count = 0;
            try
            {
                while (sqlDataReader.Read())
                {
                    count++;
                    dataGridViewCustomer.Rows.Add(count, sqlDataReader[0].ToString(), sqlDataReader[1].ToString(), sqlDataReader[2].ToString(), sqlDataReader[3].ToString());
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

        private void dataGridViewCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridViewCustomer.Columns[e.ColumnIndex].Name;
            if (colName == "EditCustomer")
            {
                CustomerInfo customerInfo = new CustomerInfo();
                // set customerIdLabel text to the stored customerId value at the respective index
                customerInfo.customerIdLabel.Text = dataGridViewCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
                customerInfo.nameTextbox.Text = dataGridViewCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
                customerInfo.emailTextbox.Text = dataGridViewCustomer.Rows[e.RowIndex].Cells[3].Value.ToString();
                customerInfo.phoneTextbox.Text = dataGridViewCustomer.Rows[e.RowIndex].Cells[4].Value.ToString();
                customerInfo.saveCustomerInfoButton.Enabled = false;
                customerInfo.updateCustomerInfoButton.Enabled = true;
                customerInfo.ShowDialog();
            }
            else if (colName == "DeleteCustomer")
            {
                if (MessageBox.Show("Do you want to delete this customer?", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    connection.Open();
                    command = new SqlCommand("DELETE FROM customers WHERE customerId LIKE '" + dataGridViewCustomer.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Record successfully deleted");
                }
            }
            LoadCustomers();
        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            CustomerInfo customerInfoForm = new CustomerInfo();
            customerInfoForm.saveCustomerInfoButton.Enabled = true;
            customerInfoForm.updateCustomerInfoButton.Enabled = false;
            customerInfoForm.ShowDialog();
            LoadCustomers();
        }
    }
}
