namespace InventoryManagementSystem
{
    partial class OrderInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderInfo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.PictureBox();
            this.folderIcon = new System.Windows.Forms.PictureBox();
            this.orderInformationLabel = new System.Windows.Forms.Label();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.dataGridViewCustomer = new System.Windows.Forms.DataGridView();
            this.c0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Column0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerLabel = new System.Windows.Forms.Label();
            this.productLabel = new System.Windows.Forms.Label();
            this.searchCustomerTextbox = new System.Windows.Forms.TextBox();
            this.searchCustomerLabel = new System.Windows.Forms.Label();
            this.searchProductTextbox = new System.Windows.Forms.TextBox();
            this.searchProductLabel = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.folderIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.PowderBlue;
            this.panelHeader.Controls.Add(this.exitButton);
            this.panelHeader.Controls.Add(this.folderIcon);
            this.panelHeader.Controls.Add(this.orderInformationLabel);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(975, 55);
            this.panelHeader.TabIndex = 31;
            // 
            // exitButton
            // 
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.Location = new System.Drawing.Point(940, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(23, 20);
            this.exitButton.TabIndex = 9;
            this.exitButton.TabStop = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click_1);
            // 
            // folderIcon
            // 
            this.folderIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.folderIcon.Image = ((System.Drawing.Image)(resources.GetObject("folderIcon.Image")));
            this.folderIcon.Location = new System.Drawing.Point(12, 2);
            this.folderIcon.Name = "folderIcon";
            this.folderIcon.Size = new System.Drawing.Size(48, 50);
            this.folderIcon.TabIndex = 8;
            this.folderIcon.TabStop = false;
            // 
            // orderInformationLabel
            // 
            this.orderInformationLabel.AutoSize = true;
            this.orderInformationLabel.Font = new System.Drawing.Font("Sitka Banner", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderInformationLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.orderInformationLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.orderInformationLabel.Location = new System.Drawing.Point(58, 4);
            this.orderInformationLabel.Name = "orderInformationLabel";
            this.orderInformationLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 10);
            this.orderInformationLabel.Size = new System.Drawing.Size(176, 48);
            this.orderInformationLabel.TabIndex = 7;
            this.orderInformationLabel.Text = "Order Information";
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.PowderBlue;
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 488);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(975, 22);
            this.panelFooter.TabIndex = 32;
            // 
            // dataGridViewCustomer
            // 
            this.dataGridViewCustomer.AllowUserToAddRows = false;
            this.dataGridViewCustomer.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Sitka Banner", 10.2F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCustomer.ColumnHeadersHeight = 29;
            this.dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c0,
            this.c1,
            this.c2});
            this.dataGridViewCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewCustomer.EnableHeadersVisualStyles = false;
            this.dataGridViewCustomer.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCustomer.Name = "dataGridViewCustomer";
            this.dataGridViewCustomer.RowHeadersVisible = false;
            this.dataGridViewCustomer.RowHeadersWidth = 51;
            this.dataGridViewCustomer.RowTemplate.Height = 24;
            this.dataGridViewCustomer.Size = new System.Drawing.Size(323, 209);
            this.dataGridViewCustomer.TabIndex = 33;
            this.dataGridViewCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCustomer_CellContentClick);
            // 
            // c0
            // 
            this.c0.HeaderText = "No";
            this.c0.MinimumWidth = 6;
            this.c0.Name = "c0";
            this.c0.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.c0.Width = 58;
            // 
            // c1
            // 
            this.c1.HeaderText = "Customer ID";
            this.c1.MinimumWidth = 6;
            this.c1.Name = "c1";
            this.c1.Width = 120;
            // 
            // c2
            // 
            this.c2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.c2.HeaderText = "Name";
            this.c2.MinimumWidth = 6;
            this.c2.Name = "c2";
            // 
            // dataGridViewProduct
            // 
            this.dataGridViewProduct.AllowUserToAddRows = false;
            this.dataGridViewProduct.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Sitka Banner", 10.2F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewProduct.ColumnHeadersHeight = 29;
            this.dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column0,
            this.Column6,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewProduct.EnableHeadersVisualStyles = false;
            this.dataGridViewProduct.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.RowHeadersVisible = false;
            this.dataGridViewProduct.RowHeadersWidth = 51;
            this.dataGridViewProduct.RowTemplate.Height = 24;
            this.dataGridViewProduct.Size = new System.Drawing.Size(634, 209);
            this.dataGridViewProduct.TabIndex = 34;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.searchCustomerTextbox);
            this.panel1.Controls.Add(this.searchCustomerLabel);
            this.panel1.Controls.Add(this.customerLabel);
            this.panel1.Controls.Add(this.dataGridViewCustomer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 433);
            this.panel1.TabIndex = 35;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.searchProductTextbox);
            this.panel2.Controls.Add(this.searchProductLabel);
            this.panel2.Controls.Add(this.productLabel);
            this.panel2.Controls.Add(this.dataGridViewProduct);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(341, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(634, 433);
            this.panel2.TabIndex = 36;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
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
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.HeaderText = "Product ID";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 107;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Name";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "Quantity";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 95;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "Price";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 70;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Description";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "Category";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 96;
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Sitka Banner", 12.2F);
            this.customerLabel.Location = new System.Drawing.Point(60, 260);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(111, 30);
            this.customerLabel.TabIndex = 34;
            this.customerLabel.Text = "CUSTOMER";
            this.customerLabel.Click += new System.EventHandler(this.productsButton_Click);
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Font = new System.Drawing.Font("Sitka Banner", 12.2F);
            this.productLabel.Location = new System.Drawing.Point(104, 260);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(97, 30);
            this.productLabel.TabIndex = 35;
            this.productLabel.Text = "PRODUCT";
            // 
            // searchCustomerTextbox
            // 
            this.searchCustomerTextbox.Location = new System.Drawing.Point(108, 215);
            this.searchCustomerTextbox.Name = "searchCustomerTextbox";
            this.searchCustomerTextbox.Size = new System.Drawing.Size(193, 29);
            this.searchCustomerTextbox.TabIndex = 35;
            // 
            // searchCustomerLabel
            // 
            this.searchCustomerLabel.AutoSize = true;
            this.searchCustomerLabel.Location = new System.Drawing.Point(49, 217);
            this.searchCustomerLabel.Name = "searchCustomerLabel";
            this.searchCustomerLabel.Size = new System.Drawing.Size(53, 24);
            this.searchCustomerLabel.TabIndex = 36;
            this.searchCustomerLabel.Text = "Search";
            // 
            // searchProductTextbox
            // 
            this.searchProductTextbox.Location = new System.Drawing.Point(244, 217);
            this.searchProductTextbox.Name = "searchProductTextbox";
            this.searchProductTextbox.Size = new System.Drawing.Size(364, 29);
            this.searchProductTextbox.TabIndex = 37;
            // 
            // searchProductLabel
            // 
            this.searchProductLabel.AutoSize = true;
            this.searchProductLabel.Location = new System.Drawing.Point(185, 219);
            this.searchProductLabel.Name = "searchProductLabel";
            this.searchProductLabel.Size = new System.Drawing.Size(53, 24);
            this.searchProductLabel.TabIndex = 38;
            this.searchProductLabel.Text = "Search";
            // 
            // OrderInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 510);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelFooter);
            this.Font = new System.Drawing.Font("Sitka Banner", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "OrderInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderInfo";
            this.Load += new System.EventHandler(this.OrderInfo_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.folderIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox exitButton;
        private System.Windows.Forms.PictureBox folderIcon;
        private System.Windows.Forms.Label orderInformationLabel;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.DataGridView dataGridViewCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn c0;
        private System.Windows.Forms.DataGridViewTextBoxColumn c1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2;
        private System.Windows.Forms.DataGridView dataGridViewProduct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column0;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.Label productLabel;
        public System.Windows.Forms.TextBox searchCustomerTextbox;
        private System.Windows.Forms.Label searchCustomerLabel;
        public System.Windows.Forms.TextBox searchProductTextbox;
        private System.Windows.Forms.Label searchProductLabel;
    }
}