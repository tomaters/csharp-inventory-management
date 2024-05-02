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
using System.Runtime.Remoting.Contexts;

namespace InventoryManagementSystem
{
    public partial class UserInfo : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\csharp\MS Database\dbms.mdf;Integrated Security = True; Connect Timeout = 30");
        SqlCommand command = new SqlCommand();
        public UserInfo()
        {
            InitializeComponent();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void saveUserInfoButton_Click(object sender, EventArgs e)
        {
            try
            {
                // re-password check
                if(passwordTextbox.Text != repasswordTextbox.Text)
                {
                    MessageBox.Show("The passwords do not match. Please try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // popup confirmation
                if (MessageBox.Show("Are you sure you want to save this data?", "Saving", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    // execute insert statement
                    command = new SqlCommand("INSERT INTO users (username, fullname, password, email, phone) VALUES(@username, @fullname, @password, @email, @phone)", connection);
                    command.Parameters.AddWithValue("@username", usernameTextbox.Text);
                    command.Parameters.AddWithValue("@fullname", fullnameTextbox.Text);
                    command.Parameters.AddWithValue("@password", passwordTextbox.Text);
                    command.Parameters.AddWithValue("@email", emailTextbox.Text);
                    command.Parameters.AddWithValue("@phone", phoneTextbox.Text);
                    connection.Open();
                    // NonQuery because it does not return any values
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("User data successfully saved");
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
            saveUserInfoButton.Enabled = true;
            updateUserInfoButton.Enabled = false;
        }

        public void Clear()
        {
            // clear button clears the text boxes
            usernameTextbox.Clear();
            fullnameTextbox.Clear();
            passwordTextbox.Clear();
            repasswordTextbox.Clear();
            emailTextbox.Clear();
            phoneTextbox.Clear();
        }

        private void updateUserInfoButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (passwordTextbox.Text != repasswordTextbox.Text)
                {
                    MessageBox.Show("The passwords do not match. Please try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // popup confirmation
                if (MessageBox.Show("Are you sure you want to update this data?", "Updating", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // execute insert statement
                    command = new SqlCommand("UPDATE users SET username=@username, fullname=@fullname, password=@password, email=@email, phone=@phone WHERE username LIKE '" + usernameTextbox.Text + "'", connection);
                    command.Parameters.AddWithValue("@username", usernameTextbox.Text);
                    command.Parameters.AddWithValue("@fullname", fullnameTextbox.Text);
                    command.Parameters.AddWithValue("@password", passwordTextbox.Text);
                    command.Parameters.AddWithValue("@email", emailTextbox.Text);
                    command.Parameters.AddWithValue("@phone", phoneTextbox.Text);
                    connection.Open();
                    // NonQuery because it does not return any values
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("User data successfully updated");
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
