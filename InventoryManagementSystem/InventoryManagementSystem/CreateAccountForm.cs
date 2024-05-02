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
    public partial class CreateAccountForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\csharp\MS Database\dbms.mdf;Integrated Security = True; Connect Timeout = 30");
        SqlCommand command = new SqlCommand();
        SqlDataReader sqlDataReader;

        public CreateAccountForm()
        {
            InitializeComponent();
        }

        private void clearUserInfoButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            usernameTextbox.Clear();
            fullnameTextbox.Clear();
            passwordTextbox.Clear();
            repasswordTextbox.Clear();
            emailTextbox.Clear();
            phoneTextbox.Clear();
        }


        private void saveUserInfoButton_Click(object sender, EventArgs e)
        {
            try 
            { 
                if(passwordTextbox.Text != repasswordTextbox.Text)
                {
                    MessageBox.Show("The passwords do not match. Please try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Create account?", "Creating", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // create account
                    command = new SqlCommand("INSERT INTO users (username, fullname, password, email, phone) VALUES (@username, @fullname, @password, @email, @phone)", connection);
                    command.Parameters.AddWithValue("@username", usernameTextbox.Text);
                    command.Parameters.AddWithValue("@fullname", fullnameTextbox.Text);
                    command.Parameters.AddWithValue("@password", passwordTextbox.Text);
                    command.Parameters.AddWithValue("@email", emailTextbox.Text);
                    command.Parameters.AddWithValue("@phone", phoneTextbox.Text);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Account created successfully");
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Boolean checkAvailability(String username)
        {
            string query = "SELECT username FROM users WHERE username = @username";

            using (SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\csharp\MS Database\dbms.mdf;Integrated Security = True; Connect Timeout = 30"))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@username", username);
                try
                {
                    connection.Open();
                    using (sqlDataReader = command.ExecuteReader())
                    {
                        return sqlDataReader.Read();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }

            }
        }

        private void usernameTextbox_TextChanged(object sender, EventArgs e)
        {
            // if textbox is not empty, display availabity status
            if(usernameTextbox.Text != "")
            {
                availabilityLabel.Visible = true;
                if (checkAvailability(usernameTextbox.Text) == true)
                {
                    availabilityLabel.Text = "The username is not available.";
                    availabilityLabel.ForeColor = Color.Red;
                }
                else
                {
                    availabilityLabel.Text = "The username is available!";
                    availabilityLabel.ForeColor = Color.Green;
                }
            }
             // if empty, make text invisible
             else
                {
                    availabilityLabel.Visible = false;
                }
        }

        private void passwordTextbox_TextChanged(object sender, EventArgs e)
        {
            if(passwordTextbox.Text != "" &&  passwordTextbox.Text != repasswordTextbox.Text)
            {
                passwordMatchingLabel.Visible = true;
                passwordMatchingLabel.ForeColor = Color.Red;
                passwordMatchingLabel.Text = "Passwords do not match!";
            }
            else
            {
                passwordMatchingLabel.Visible = false;
            }
        }

        private void repasswordTextbox_TextChanged(object sender, EventArgs e)
        {
            if (repasswordTextbox.Text != "" && passwordTextbox.Text != repasswordTextbox.Text)
            {
                passwordMatchingLabel.Visible = true;
                passwordMatchingLabel.ForeColor = Color.Red;
                passwordMatchingLabel.Text = "Passwords do not match!";
            }
            else
            {
                passwordMatchingLabel.Visible = false;
            }
        }
        private void exitButton_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
