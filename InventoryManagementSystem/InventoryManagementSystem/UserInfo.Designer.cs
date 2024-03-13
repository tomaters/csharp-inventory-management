namespace InventoryManagementSystem
{
    partial class UserInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInfo));
            this.title = new System.Windows.Forms.Label();
            this.folderIcon = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.PictureBox();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.phoneTextbox = new System.Windows.Forms.TextBox();
            this.saveUserInfoButton = new System.Windows.Forms.Button();
            this.clearUserInfoButton = new System.Windows.Forms.Button();
            this.fullnameLabel = new System.Windows.Forms.Label();
            this.fullnameTextbox = new System.Windows.Forms.TextBox();
            this.updateUserInfoButton = new System.Windows.Forms.Button();
            this.repasswordLabel = new System.Windows.Forms.Label();
            this.repasswordTextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.folderIcon)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            this.SuspendLayout();
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
            this.title.Click += new System.EventHandler(this.title_Click);
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
            this.panelHeader.TabIndex = 3;
            // 
            // exitButton
            // 
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.Location = new System.Drawing.Point(790, 5);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(23, 20);
            this.exitButton.TabIndex = 9;
            this.exitButton.TabStop = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.PowderBlue;
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 393);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(816, 22);
            this.panelFooter.TabIndex = 2;
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Location = new System.Drawing.Point(215, 101);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(543, 22);
            this.usernameTextbox.TabIndex = 2;
            this.usernameTextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(111, 94);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(89, 29);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Username";
            this.usernameLabel.Click += new System.EventHandler(this.usernameLabel_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(114, 181);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(86, 29);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Password\r\n";
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(215, 186);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(543, 22);
            this.passwordTextbox.TabIndex = 6;
            this.passwordTextbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(142, 262);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(58, 29);
            this.emailLabel.TabIndex = 7;
            this.emailLabel.Text = "Email\r\n";
            // 
            // emailTextbox
            // 
            this.emailTextbox.Location = new System.Drawing.Point(215, 268);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(543, 22);
            this.emailTextbox.TabIndex = 8;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.Location = new System.Drawing.Point(140, 301);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(60, 29);
            this.phoneLabel.TabIndex = 9;
            this.phoneLabel.Text = "Phone\r\n";
            // 
            // phoneTextbox
            // 
            this.phoneTextbox.Location = new System.Drawing.Point(215, 308);
            this.phoneTextbox.Name = "phoneTextbox";
            this.phoneTextbox.Size = new System.Drawing.Size(543, 22);
            this.phoneTextbox.TabIndex = 10;
            // 
            // saveUserInfoButton
            // 
            this.saveUserInfoButton.BackColor = System.Drawing.Color.ForestGreen;
            this.saveUserInfoButton.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveUserInfoButton.ForeColor = System.Drawing.Color.White;
            this.saveUserInfoButton.Location = new System.Drawing.Point(624, 348);
            this.saveUserInfoButton.Name = "saveUserInfoButton";
            this.saveUserInfoButton.Size = new System.Drawing.Size(122, 39);
            this.saveUserInfoButton.TabIndex = 12;
            this.saveUserInfoButton.Text = "Save";
            this.saveUserInfoButton.UseVisualStyleBackColor = false;
            this.saveUserInfoButton.Click += new System.EventHandler(this.saveUserInfoButton_Click);
            // 
            // clearUserInfoButton
            // 
            this.clearUserInfoButton.BackColor = System.Drawing.Color.Crimson;
            this.clearUserInfoButton.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearUserInfoButton.ForeColor = System.Drawing.Color.White;
            this.clearUserInfoButton.Location = new System.Drawing.Point(368, 348);
            this.clearUserInfoButton.Name = "clearUserInfoButton";
            this.clearUserInfoButton.Size = new System.Drawing.Size(122, 39);
            this.clearUserInfoButton.TabIndex = 11;
            this.clearUserInfoButton.Text = "Clear";
            this.clearUserInfoButton.UseVisualStyleBackColor = false;
            this.clearUserInfoButton.Click += new System.EventHandler(this.clearUserInfoButton_Click);
            // 
            // fullnameLabel
            // 
            this.fullnameLabel.AutoSize = true;
            this.fullnameLabel.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullnameLabel.Location = new System.Drawing.Point(110, 140);
            this.fullnameLabel.Name = "fullnameLabel";
            this.fullnameLabel.Size = new System.Drawing.Size(90, 29);
            this.fullnameLabel.TabIndex = 3;
            this.fullnameLabel.Text = "Full name";
            // 
            // fullnameTextbox
            // 
            this.fullnameTextbox.Location = new System.Drawing.Point(215, 147);
            this.fullnameTextbox.Name = "fullnameTextbox";
            this.fullnameTextbox.Size = new System.Drawing.Size(543, 22);
            this.fullnameTextbox.TabIndex = 4;
            // 
            // updateUserInfoButton
            // 
            this.updateUserInfoButton.BackColor = System.Drawing.Color.SteelBlue;
            this.updateUserInfoButton.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateUserInfoButton.ForeColor = System.Drawing.Color.White;
            this.updateUserInfoButton.Location = new System.Drawing.Point(496, 348);
            this.updateUserInfoButton.Name = "updateUserInfoButton";
            this.updateUserInfoButton.Size = new System.Drawing.Size(122, 39);
            this.updateUserInfoButton.TabIndex = 13;
            this.updateUserInfoButton.Text = "Update";
            this.updateUserInfoButton.UseVisualStyleBackColor = false;
            this.updateUserInfoButton.Click += new System.EventHandler(this.updateUserInfoButton_Click);
            // 
            // repasswordLabel
            // 
            this.repasswordLabel.AutoSize = true;
            this.repasswordLabel.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repasswordLabel.Location = new System.Drawing.Point(45, 224);
            this.repasswordLabel.Name = "repasswordLabel";
            this.repasswordLabel.Size = new System.Drawing.Size(155, 29);
            this.repasswordLabel.TabIndex = 14;
            this.repasswordLabel.Text = "Re-enter password";
            this.repasswordLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // repasswordTextbox
            // 
            this.repasswordTextbox.Location = new System.Drawing.Point(215, 230);
            this.repasswordTextbox.Name = "repasswordTextbox";
            this.repasswordTextbox.Size = new System.Drawing.Size(543, 22);
            this.repasswordTextbox.TabIndex = 15;
            // 
            // UserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 415);
            this.Controls.Add(this.repasswordLabel);
            this.Controls.Add(this.repasswordTextbox);
            this.Controls.Add(this.updateUserInfoButton);
            this.Controls.Add(this.fullnameTextbox);
            this.Controls.Add(this.fullnameLabel);
            this.Controls.Add(this.clearUserInfoButton);
            this.Controls.Add(this.saveUserInfoButton);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.phoneTextbox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.emailTextbox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.usernameTextbox);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelFooter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserInfo";
            this.Text = "UserModule";
            ((System.ComponentModel.ISupportInitialize)(this.folderIcon)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox folderIcon;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.PictureBox exitButton;
        private System.Windows.Forms.Label fullnameLabel;
        public System.Windows.Forms.TextBox usernameTextbox;
        public System.Windows.Forms.TextBox passwordTextbox;
        public System.Windows.Forms.TextBox emailTextbox;
        public System.Windows.Forms.TextBox phoneTextbox;
        public System.Windows.Forms.TextBox fullnameTextbox;
        public System.Windows.Forms.Button saveUserInfoButton;
        public System.Windows.Forms.Button clearUserInfoButton;
        public System.Windows.Forms.Button updateUserInfoButton;
        private System.Windows.Forms.Label repasswordLabel;
        public System.Windows.Forms.TextBox repasswordTextbox;
    }
}