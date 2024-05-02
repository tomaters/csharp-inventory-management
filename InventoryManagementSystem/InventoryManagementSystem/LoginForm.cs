using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class LoginForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\csharp\MS Database\dbms.mdf;Integrated Security = True; Connect Timeout = 30");
        SqlCommand command = new SqlCommand();
        SqlDataReader sqlDataReader;

        private Form activeForm = null;

        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = true;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.BringToFront();
            childForm.Show();

        }
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                command = new SqlCommand("SELECT * FROM users WHERE username = @username AND password = @password", connection);
                command.Parameters.AddWithValue("@username", usernameTextbox.Text);
                command.Parameters.AddWithValue("@password", passwordTextbox.Text);
                connection.Open();
                sqlDataReader = command.ExecuteReader();
                sqlDataReader.Read();

                if (sqlDataReader.HasRows)
                {
                    MessageBox.Show("Welcome, " + sqlDataReader["fullname"].ToString() + "!", "Login success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MainForm mainForm = new MainForm(usernameTextbox.Text);
                    this.Hide();
                    mainForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Login failed. Please try again.", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void folderIcon_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if(MessageBox.Show("Exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            openChildForm(new CreateAccountForm());
        }
    }
}
