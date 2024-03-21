namespace InventoryManagementSystem
{
    partial class OrdersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DeleteCustomer = new System.Windows.Forms.DataGridViewImageColumn();
            this.c4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditCustomer = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.searchOrderTextbox = new System.Windows.Forms.TextBox();
            this.searchOrderLabel = new System.Windows.Forms.Label();
            this.viewOrdersButton = new System.Windows.Forms.Button();
            this.manageOrdersLabel = new System.Windows.Forms.Label();
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.dataGridViewCustomer = new System.Windows.Forms.DataGridView();
            this.Column0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteCustomer
            // 
            this.DeleteCustomer.HeaderText = "";
            this.DeleteCustomer.Image = ((System.Drawing.Image)(resources.GetObject("DeleteCustomer.Image")));
            this.DeleteCustomer.MinimumWidth = 6;
            this.DeleteCustomer.Name = "DeleteCustomer";
            this.DeleteCustomer.ReadOnly = true;
            this.DeleteCustomer.Width = 25;
            // 
            // c4
            // 
            this.c4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.c4.HeaderText = "Phone Number";
            this.c4.MinimumWidth = 6;
            this.c4.Name = "c4";
            this.c4.Width = 137;
            // 
            // c3
            // 
            this.c3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.c3.HeaderText = "Email Address";
            this.c3.MinimumWidth = 6;
            this.c3.Name = "c3";
            this.c3.Width = 130;
            // 
            // c2
            // 
            this.c2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.c2.HeaderText = "Name";
            this.c2.MinimumWidth = 6;
            this.c2.Name = "c2";
            // 
            // c1
            // 
            this.c1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.c1.HeaderText = "Customer ID";
            this.c1.MinimumWidth = 6;
            this.c1.Name = "c1";
            this.c1.Width = 120;
            // 
            // c0
            // 
            this.c0.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.c0.HeaderText = "No";
            this.c0.MinimumWidth = 6;
            this.c0.Name = "c0";
            this.c0.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.c0.Width = 58;
            // 
            // EditCustomer
            // 
            this.EditCustomer.HeaderText = "";
            this.EditCustomer.Image = ((System.Drawing.Image)(resources.GetObject("EditCustomer.Image")));
            this.EditCustomer.MinimumWidth = 6;
            this.EditCustomer.Name = "EditCustomer";
            this.EditCustomer.ReadOnly = true;
            this.EditCustomer.Width = 25;
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.PowderBlue;
            this.panelFooter.Controls.Add(this.searchOrderTextbox);
            this.panelFooter.Controls.Add(this.searchOrderLabel);
            this.panelFooter.Controls.Add(this.viewOrdersButton);
            this.panelFooter.Controls.Add(this.manageOrdersLabel);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 415);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(816, 41);
            this.panelFooter.TabIndex = 8;
            // 
            // searchOrderTextbox
            // 
            this.searchOrderTextbox.Location = new System.Drawing.Point(261, 6);
            this.searchOrderTextbox.Name = "searchOrderTextbox";
            this.searchOrderTextbox.Size = new System.Drawing.Size(354, 29);
            this.searchOrderTextbox.TabIndex = 9;
            // 
            // searchOrderLabel
            // 
            this.searchOrderLabel.AutoSize = true;
            this.searchOrderLabel.Location = new System.Drawing.Point(202, 8);
            this.searchOrderLabel.Name = "searchOrderLabel";
            this.searchOrderLabel.Size = new System.Drawing.Size(53, 24);
            this.searchOrderLabel.TabIndex = 10;
            this.searchOrderLabel.Text = "Search";
            // 
            // viewOrdersButton
            // 
            this.viewOrdersButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.viewOrdersButton.Location = new System.Drawing.Point(664, 4);
            this.viewOrdersButton.Name = "viewOrdersButton";
            this.viewOrdersButton.Size = new System.Drawing.Size(140, 32);
            this.viewOrdersButton.TabIndex = 4;
            this.viewOrdersButton.Text = "View Orders";
            this.viewOrdersButton.UseVisualStyleBackColor = true;
            this.viewOrdersButton.Click += new System.EventHandler(this.viewOrdersButton_Click);
            // 
            // manageOrdersLabel
            // 
            this.manageOrdersLabel.AutoSize = true;
            this.manageOrdersLabel.Location = new System.Drawing.Point(12, 8);
            this.manageOrdersLabel.Name = "manageOrdersLabel";
            this.manageOrdersLabel.Size = new System.Drawing.Size(109, 24);
            this.manageOrdersLabel.TabIndex = 1;
            this.manageOrdersLabel.Text = "Manage Orders";
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.AllowUserToAddRows = false;
            this.dataGridViewOrder.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Sitka Banner", 10.2F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewOrder.ColumnHeadersHeight = 29;
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column0,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Edit,
            this.Delete});
            this.dataGridViewOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOrder.EnableHeadersVisualStyles = false;
            this.dataGridViewOrder.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.RowHeadersWidth = 51;
            this.dataGridViewOrder.RowTemplate.Height = 24;
            this.dataGridViewOrder.Size = new System.Drawing.Size(816, 456);
            this.dataGridViewOrder.TabIndex = 7;
            this.dataGridViewOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrder_CellContentClick);
            // 
            // dataGridViewCustomer
            // 
            this.dataGridViewCustomer.AllowUserToAddRows = false;
            this.dataGridViewCustomer.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Sitka Banner", 10.2F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCustomer.ColumnHeadersHeight = 29;
            this.dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c0,
            this.c1,
            this.c2,
            this.c3,
            this.c4,
            this.EditCustomer,
            this.DeleteCustomer});
            this.dataGridViewCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCustomer.EnableHeadersVisualStyles = false;
            this.dataGridViewCustomer.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCustomer.Name = "dataGridViewCustomer";
            this.dataGridViewCustomer.RowHeadersWidth = 51;
            this.dataGridViewCustomer.RowTemplate.Height = 24;
            this.dataGridViewCustomer.Size = new System.Drawing.Size(816, 456);
            this.dataGridViewCustomer.TabIndex = 9;
            // 
            // Column0
            // 
            this.Column0.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column0.HeaderText = "No";
            this.Column0.MinimumWidth = 6;
            this.Column0.Name = "Column0";
            this.Column0.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column0.Width = 58;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "Order ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 96;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Order Date";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 110;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Product ID";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 110;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Customer ID";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 110;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "Qty";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 62;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Price";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 75;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.HeaderText = "Total";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // Edit
            // 
            this.Edit.HeaderText = "";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Width = 25;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 25;
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 456);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.dataGridViewOrder);
            this.Controls.Add(this.dataGridViewCustomer);
            this.Font = new System.Drawing.Font("Sitka Banner", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "OrdersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrdersForm";
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewImageColumn DeleteCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn c4;
        private System.Windows.Forms.DataGridViewTextBoxColumn c3;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2;
        private System.Windows.Forms.DataGridViewTextBoxColumn c1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c0;
        private System.Windows.Forms.DataGridViewImageColumn EditCustomer;
        private System.Windows.Forms.Panel panelFooter;
        public System.Windows.Forms.TextBox searchOrderTextbox;
        private System.Windows.Forms.Label searchOrderLabel;
        private System.Windows.Forms.Button viewOrdersButton;
        private System.Windows.Forms.Label manageOrdersLabel;
        private System.Windows.Forms.DataGridView dataGridViewOrder;
        private System.Windows.Forms.DataGridView dataGridViewCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column0;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}