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
    public partial class UsersForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\csharp\MS Database\dbms.mdf;Integrated Security = True; Connect Timeout = 30");
        SqlCommand command = new SqlCommand();
        SqlDataReader sqlDataReader;
        public UsersForm()
        {
            InitializeComponent();
            LoadUser();
        }

        public void LoadUser()
        {
            dataGridViewUser.Rows.Clear();
            command = new SqlCommand("SELECT * FROM users", connection);
            connection.Open();
            sqlDataReader = command.ExecuteReader();

            // count represents No
            int count = 0;
            try
            {
                while (sqlDataReader.Read())
                {
                    count++;
                    dataGridViewUser.Rows.Add(count, sqlDataReader[0].ToString(), sqlDataReader[1].ToString(), sqlDataReader[2].ToString(), sqlDataReader[3].ToString());
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
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridViewUser.Columns[e.ColumnIndex].Name;
            // response when 'Edit' is clicked
            if (colName == "Edit")
            {
                UserInfo userInfo = new UserInfo();
                // change info of username accordingly
                userInfo.usernameTextbox.Text = dataGridViewUser.Rows[e.RowIndex].Cells[1].Value.ToString();
                userInfo.fullnameTextbox.Text = dataGridViewUser.Rows[e.RowIndex].Cells[2].Value.ToString();
                userInfo.passwordTextbox.Text = dataGridViewUser.Rows[e.RowIndex].Cells[3].Value.ToString();
                userInfo.emailTextbox.Text = dataGridViewUser.Rows[e.RowIndex].Cells[4].Value.ToString();
                userInfo.phoneTextbox.Text = dataGridViewUser.Rows[e.RowIndex].Cells[5].Value.ToString();
                // enable necessary features
                userInfo.saveUserInfoButton.Enabled = false;
                userInfo.updateUserInfoButton.Enabled = true;
                userInfo.usernameTextbox.Enabled = false;
                userInfo.ShowDialog();
            }
            // response when 'Delete' is clicked
            else if(colName == "Delete")
            {
                if(MessageBox.Show("Do you want to delete this user?", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    connection.Open();
                    // delete from table where username = the username
                    command = new SqlCommand("DELETE FROM users WHERE username LIKE '" + dataGridViewUser.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Record successfully deleted");
                }
            }
            LoadUser();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserInfo userInfoForm = new UserInfo();
            // show the UserInfo form
            userInfoForm.Show();
            // hide the current form
            this.Hide();
        }

        private void panelFooter_Paint(object sender, PaintEventArgs e)
        {
 
        }
    }
}
