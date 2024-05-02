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
            LoadUsers();
        }

        public void LoadUsers()
        {
            dataGridViewUser.Rows.Clear();
            command = new SqlCommand("SELECT * FROM users WHERE CONCAT(username, fullname, password, email, phone) LIKE '%" + searchUserTextbox.Text + "%'", connection);
            connection.Open();
            sqlDataReader = command.ExecuteReader();

            // count represents No
            int count = 0;
            try
            {
                while (sqlDataReader.Read())
                {
                    count++;
                    // skip sqlDataReader[2]; don't display password
                    dataGridViewUser.Rows.Add(count, sqlDataReader[0].ToString(), sqlDataReader[1].ToString(), sqlDataReader[3].ToString(), sqlDataReader[4].ToString());
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
        private void dataGridViewUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridViewUser.Columns[e.ColumnIndex].Name;
            // response when 'EditUser' is clicked
            if (colName == "EditUser")
            {
                UserInfo userInfo = new UserInfo();
                // change info of username accordingly
                userInfo.usernameTextbox.Text = dataGridViewUser.Rows[e.RowIndex].Cells[1].Value.ToString();
                userInfo.fullnameTextbox.Text = dataGridViewUser.Rows[e.RowIndex].Cells[2].Value.ToString();
                // password not shown
                // userInfo.passwordTextbox.Text = dataGridViewUser.Rows[e.RowIndex].Cells[].Value.ToString();
                userInfo.emailTextbox.Text = dataGridViewUser.Rows[e.RowIndex].Cells[3].Value.ToString();
                userInfo.phoneTextbox.Text = dataGridViewUser.Rows[e.RowIndex].Cells[4].Value.ToString();
                // enable necessary features
                userInfo.saveUserInfoButton.Enabled = false;
                userInfo.updateUserInfoButton.Enabled = true;
                userInfo.usernameTextbox.Enabled = false;
                userInfo.ShowDialog();
            }
            // response when 'DeleteUser' is clicked
            else if(colName == "DeleteUser")
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
            LoadUsers();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            UserInfo userInfoForm = new UserInfo();
            userInfoForm.saveUserInfoButton.Enabled = true;
            userInfoForm.updateUserInfoButton.Enabled = false;
            userInfoForm.ShowDialog();
            LoadUsers();
        }
        private void searchUserTextbox_TextChanged(object sender, EventArgs e)
        {
            LoadUsers();
        }
    }
}
