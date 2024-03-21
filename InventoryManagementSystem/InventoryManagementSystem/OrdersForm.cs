using System;
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
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();
        }

        private void dataGridViewOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void viewOrdersButton_Click(object sender, EventArgs e)
        {
            OrderInfo orderInfoForm = new OrderInfo();
            orderInfoForm.ShowDialog();
        }
    }
}
