namespace InventoryManagementSystem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.folderIcon = new System.Windows.Forms.PictureBox();
            this.inventoryManagementLabel = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.customersButton = new System.Windows.Forms.Label();
            this.ordersButton = new System.Windows.Forms.Label();
            this.productsButton = new System.Windows.Forms.Label();
            this.usersButton = new System.Windows.Forms.Label();
            this.categoriesButton = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.folderIcon)).BeginInit();
            this.panelMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.PowderBlue;
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Controls.Add(this.folderIcon);
            this.panelHeader.Controls.Add(this.inventoryManagementLabel);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1232, 83);
            this.panelHeader.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 55);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // folderIcon
            // 
            this.folderIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.folderIcon.Image = ((System.Drawing.Image)(resources.GetObject("folderIcon.Image")));
            this.folderIcon.Location = new System.Drawing.Point(10, 10);
            this.folderIcon.Name = "folderIcon";
            this.folderIcon.Size = new System.Drawing.Size(64, 66);
            this.folderIcon.TabIndex = 8;
            this.folderIcon.TabStop = false;
            // 
            // inventoryManagementLabel
            // 
            this.inventoryManagementLabel.AutoSize = true;
            this.inventoryManagementLabel.Font = new System.Drawing.Font("Sitka Banner", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryManagementLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.inventoryManagementLabel.Location = new System.Drawing.Point(72, 21);
            this.inventoryManagementLabel.Name = "inventoryManagementLabel";
            this.inventoryManagementLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 10);
            this.inventoryManagementLabel.Size = new System.Drawing.Size(287, 48);
            this.inventoryManagementLabel.TabIndex = 7;
            this.inventoryManagementLabel.Text = "Inventory Management System\r\n";
            this.inventoryManagementLabel.Click += new System.EventHandler(this.title_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMain.Location = new System.Drawing.Point(0, 83);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1232, 488);
            this.panelMain.TabIndex = 2;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(212)))), ((int)(((byte)(228)))));
            this.panel1.Controls.Add(this.customersButton);
            this.panel1.Controls.Add(this.ordersButton);
            this.panel1.Controls.Add(this.productsButton);
            this.panel1.Controls.Add(this.usersButton);
            this.panel1.Controls.Add(this.categoriesButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(127, 488);
            this.panel1.TabIndex = 5;
            // 
            // customersButton
            // 
            this.customersButton.AutoSize = true;
            this.customersButton.Location = new System.Drawing.Point(11, 91);
            this.customersButton.Name = "customersButton";
            this.customersButton.Size = new System.Drawing.Size(97, 24);
            this.customersButton.TabIndex = 1;
            this.customersButton.Text = "CUSTOMERS";
            this.customersButton.Click += new System.EventHandler(this.customersButton_Click);
            // 
            // ordersButton
            // 
            this.ordersButton.AutoSize = true;
            this.ordersButton.Location = new System.Drawing.Point(25, 253);
            this.ordersButton.Name = "ordersButton";
            this.ordersButton.Size = new System.Drawing.Size(68, 24);
            this.ordersButton.TabIndex = 4;
            this.ordersButton.Text = "ORDERS";
            this.ordersButton.Click += new System.EventHandler(this.ordersButton_Click);
            // 
            // productsButton
            // 
            this.productsButton.AutoSize = true;
            this.productsButton.Location = new System.Drawing.Point(17, 37);
            this.productsButton.Name = "productsButton";
            this.productsButton.Size = new System.Drawing.Size(85, 24);
            this.productsButton.TabIndex = 0;
            this.productsButton.Text = "PRODUCTS";
            this.productsButton.Click += new System.EventHandler(this.productsButton_Click);
            // 
            // usersButton
            // 
            this.usersButton.AutoSize = true;
            this.usersButton.Location = new System.Drawing.Point(32, 199);
            this.usersButton.Name = "usersButton";
            this.usersButton.Size = new System.Drawing.Size(55, 24);
            this.usersButton.TabIndex = 3;
            this.usersButton.Text = "USERS";
            this.usersButton.Click += new System.EventHandler(this.usersButton_Click);
            // 
            // categoriesButton
            // 
            this.categoriesButton.AutoSize = true;
            this.categoriesButton.Location = new System.Drawing.Point(10, 145);
            this.categoriesButton.Name = "categoriesButton";
            this.categoriesButton.Size = new System.Drawing.Size(98, 24);
            this.categoriesButton.TabIndex = 2;
            this.categoriesButton.Text = "CATEGORIES";
            this.categoriesButton.Click += new System.EventHandler(this.categoriesButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 571);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Management System";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.folderIcon)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox folderIcon;
        private System.Windows.Forms.Label inventoryManagementLabel;
        private System.Windows.Forms.Label productsButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ordersButton;
        private System.Windows.Forms.Label usersButton;
        private System.Windows.Forms.Label categoriesButton;
        private System.Windows.Forms.Label customersButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}