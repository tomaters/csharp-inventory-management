namespace InventoryManagementSystem
{
    partial class CustomerInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerInfo));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.PictureBox();
            this.folderIcon = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.updateCustomerInfoButton = new System.Windows.Forms.Button();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.clearCustomerInfoButton = new System.Windows.Forms.Button();
            this.saveCustomerInfoButton = new System.Windows.Forms.Button();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.phoneTextbox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.customerIdLabel = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.folderIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.PowderBlue;
            this.panelHeader.Controls.Add(this.exitButton);
            this.panelHeader.Controls.Add(this.folderIcon);
            this.panelHeader.Controls.Add(this.title);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(816, 66);
            this.panelHeader.TabIndex = 4;
            // 
            // exitButton
            // 
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.Location = new System.Drawing.Point(781, 10);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(23, 20);
            this.exitButton.TabIndex = 9;
            this.exitButton.TabStop = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // folderIcon
            // 
            this.folderIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.folderIcon.Image = ((System.Drawing.Image)(resources.GetObject("folderIcon.Image")));
            this.folderIcon.Location = new System.Drawing.Point(10, 10);
            this.folderIcon.Name = "folderIcon";
            this.folderIcon.Size = new System.Drawing.Size(0, 49);
            this.folderIcon.TabIndex = 8;
            this.folderIcon.TabStop = false;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Sitka Banner", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.MidnightBlue;
            this.title.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.title.Location = new System.Drawing.Point(28, 14);
            this.title.Name = "title";
            this.title.Padding = new System.Windows.Forms.Padding(0, 5, 0, 10);
            this.title.Size = new System.Drawing.Size(165, 48);
            this.title.TabIndex = 7;
            this.title.Text = "User Information";
            // 
            // updateCustomerInfoButton
            // 
            this.updateCustomerInfoButton.BackColor = System.Drawing.Color.SteelBlue;
            this.updateCustomerInfoButton.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCustomerInfoButton.ForeColor = System.Drawing.Color.White;
            this.updateCustomerInfoButton.Location = new System.Drawing.Point(482, 228);
            this.updateCustomerInfoButton.Name = "updateCustomerInfoButton";
            this.updateCustomerInfoButton.Size = new System.Drawing.Size(122, 39);
            this.updateCustomerInfoButton.TabIndex = 29;
            this.updateCustomerInfoButton.Text = "Update";
            this.updateCustomerInfoButton.UseVisualStyleBackColor = false;
            this.updateCustomerInfoButton.Click += new System.EventHandler(this.updateCustomerInfoButton_Click);
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(189, 100);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(543, 22);
            this.nameTextbox.TabIndex = 20;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(114, 93);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(58, 29);
            this.nameLabel.TabIndex = 19;
            this.nameLabel.Text = "Name";
            // 
            // clearCustomerInfoButton
            // 
            this.clearCustomerInfoButton.BackColor = System.Drawing.Color.Crimson;
            this.clearCustomerInfoButton.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearCustomerInfoButton.ForeColor = System.Drawing.Color.White;
            this.clearCustomerInfoButton.Location = new System.Drawing.Point(354, 228);
            this.clearCustomerInfoButton.Name = "clearCustomerInfoButton";
            this.clearCustomerInfoButton.Size = new System.Drawing.Size(122, 39);
            this.clearCustomerInfoButton.TabIndex = 27;
            this.clearCustomerInfoButton.Text = "Clear";
            this.clearCustomerInfoButton.UseVisualStyleBackColor = false;
            this.clearCustomerInfoButton.Click += new System.EventHandler(this.clearCustomerInfoButton_Click);
            // 
            // saveCustomerInfoButton
            // 
            this.saveCustomerInfoButton.BackColor = System.Drawing.Color.ForestGreen;
            this.saveCustomerInfoButton.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveCustomerInfoButton.ForeColor = System.Drawing.Color.White;
            this.saveCustomerInfoButton.Location = new System.Drawing.Point(610, 228);
            this.saveCustomerInfoButton.Name = "saveCustomerInfoButton";
            this.saveCustomerInfoButton.Size = new System.Drawing.Size(122, 39);
            this.saveCustomerInfoButton.TabIndex = 28;
            this.saveCustomerInfoButton.Text = "Save";
            this.saveCustomerInfoButton.UseVisualStyleBackColor = false;
            this.saveCustomerInfoButton.Click += new System.EventHandler(this.saveCustomerInfoButton_Click);
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.Location = new System.Drawing.Point(114, 175);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(60, 29);
            this.phoneLabel.TabIndex = 25;
            this.phoneLabel.Text = "Phone\r\n";
            // 
            // phoneTextbox
            // 
            this.phoneTextbox.Location = new System.Drawing.Point(189, 182);
            this.phoneTextbox.Name = "phoneTextbox";
            this.phoneTextbox.Size = new System.Drawing.Size(543, 22);
            this.phoneTextbox.TabIndex = 26;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(116, 136);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(58, 29);
            this.emailLabel.TabIndex = 23;
            this.emailLabel.Text = "Email\r\n";
            // 
            // emailTextbox
            // 
            this.emailTextbox.Location = new System.Drawing.Point(189, 142);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(543, 22);
            this.emailTextbox.TabIndex = 24;
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.PowderBlue;
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 285);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(816, 22);
            this.panelFooter.TabIndex = 18;
            // 
            // customerIdLabel
            // 
            this.customerIdLabel.AutoSize = true;
            this.customerIdLabel.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIdLabel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.customerIdLabel.Location = new System.Drawing.Point(29, 238);
            this.customerIdLabel.Name = "customerIdLabel";
            this.customerIdLabel.Size = new System.Drawing.Size(109, 29);
            this.customerIdLabel.TabIndex = 30;
            this.customerIdLabel.Text = "Customer ID";
            this.customerIdLabel.Visible = false;
            this.customerIdLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // CustomerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 307);
            this.Controls.Add(this.customerIdLabel);
            this.Controls.Add(this.updateCustomerInfoButton);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.clearCustomerInfoButton);
            this.Controls.Add(this.saveCustomerInfoButton);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.phoneTextbox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.emailTextbox);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerInfo";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.folderIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox exitButton;
        private System.Windows.Forms.PictureBox folderIcon;
        private System.Windows.Forms.Label title;
        public System.Windows.Forms.Button updateCustomerInfoButton;
        public System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.Label nameLabel;
        public System.Windows.Forms.Button clearCustomerInfoButton;
        public System.Windows.Forms.Button saveCustomerInfoButton;
        private System.Windows.Forms.Label phoneLabel;
        public System.Windows.Forms.TextBox phoneTextbox;
        private System.Windows.Forms.Label emailLabel;
        public System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.Panel panelFooter;
        public System.Windows.Forms.Label customerIdLabel;
    }
}