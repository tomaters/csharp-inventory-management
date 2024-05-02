using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class MainForm : Form
    {
        public static string loggedUsername { get; private set; }
        // for subform (or childform) form in mainform
        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            // check whether there is an existing form. if there is, close it
            if (activeForm != null)
                activeForm.Close();
            
            activeForm = childForm;

            // indicate that the form is not a top-level control; treated as nested
            childForm.TopLevel = false;
            
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        public MainForm(String username)
        {
            InitializeComponent();
            setUsername(username);
        }

        public static void setUsername(String username)
        {
            loggedUsername = username;
        }
       private void productsButton_Click(object sender, EventArgs e)
        {
            openChildForm(new ProductsForm());
        }
        private void usersButton_Click(object sender, EventArgs e)
        {
            openChildForm(new UsersForm());
        }

        private void customersButton_Click(object sender, EventArgs e)
        {
            openChildForm(new CustomersForm());
        }

        private void categoriesButton_Click(object sender, EventArgs e)
        {
            openChildForm(new CategoriesForm());
        }

        private void ordersButton_Click(object sender, EventArgs e)
        {
            openChildForm(new OrdersForm(loggedUsername));
        }
    }
}
