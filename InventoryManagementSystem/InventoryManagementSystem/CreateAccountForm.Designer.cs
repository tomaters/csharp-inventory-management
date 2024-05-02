namespace InventoryManagementSystem
{
    partial class CreateAccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccountForm));
            this.repasswordLabel = new System.Windows.Forms.Label();
            this.repasswordTextbox = new System.Windows.Forms.TextBox();
            this.fullnameTextbox = new System.Windows.Forms.TextBox();
            this.fullnameLabel = new System.Windows.Forms.Label();
            this.createAccountButton = new System.Windows.Forms.Button();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.phoneTextbox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.folderIcon = new System.Windows.Forms.PictureBox();
            this.userInformationLabel = new System.Windows.Forms.Label();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.clearUserInfoButton = new System.Windows.Forms.Button();
            this.availabilityLabel = new System.Windows.Forms.Label();
            this.passwordMatchingLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.folderIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // repasswordLabel
            // 
            this.repasswordLabel.AutoSize = true;
            this.repasswordLabel.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repasswordLabel.Location = new System.Drawing.Point(45, 197);
            this.repasswordLabel.Name = "repasswordLabel";
            this.repasswordLabel.Size = new System.Drawing.Size(155, 29);
            this.repasswordLabel.TabIndex = 31;
            this.repasswordLabel.Text = "Re-enter password";
            // 
            // repasswordTextbox
            // 
            this.repasswordTextbox.Location = new System.Drawing.Point(215, 203);
            this.repasswordTextbox.Name = "repasswordTextbox";
            this.repasswordTextbox.Size = new System.Drawing.Size(543, 22);
            this.repasswordTextbox.TabIndex = 3;
            this.repasswordTextbox.UseSystemPasswordChar = true;
            this.repasswordTextbox.TextChanged += new System.EventHandler(this.repasswordTextbox_TextChanged);
            // 
            // fullnameTextbox
            // 
            this.fullnameTextbox.Location = new System.Drawing.Point(215, 259);
            this.fullnameTextbox.Name = "fullnameTextbox";
            this.fullnameTextbox.Size = new System.Drawing.Size(543, 22);
            this.fullnameTextbox.TabIndex = 4;
            // 
            // fullnameLabel
            // 
            this.fullnameLabel.AutoSize = true;
            this.fullnameLabel.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullnameLabel.Location = new System.Drawing.Point(110, 252);
            this.fullnameLabel.Name = "fullnameLabel";
            this.fullnameLabel.Size = new System.Drawing.Size(90, 29);
            this.fullnameLabel.TabIndex = 19;
            this.fullnameLabel.Text = "Full name";
            // 
            // createAccountButton
            // 
            this.createAccountButton.BackColor = System.Drawing.Color.ForestGreen;
            this.createAccountButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createAccountButton.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccountButton.ForeColor = System.Drawing.Color.White;
            this.createAccountButton.Location = new System.Drawing.Point(624, 375);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(122, 39);
            this.createAccountButton.TabIndex = 8;
            this.createAccountButton.Text = "Create account";
            this.createAccountButton.UseVisualStyleBackColor = false;
            this.createAccountButton.Click += new System.EventHandler(this.saveUserInfoButton_Click);
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.Location = new System.Drawing.Point(140, 328);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(60, 29);
            this.phoneLabel.TabIndex = 26;
            this.phoneLabel.Text = "Phone\r\n";
            // 
            // phoneTextbox
            // 
            this.phoneTextbox.Location = new System.Drawing.Point(215, 335);
            this.phoneTextbox.Name = "phoneTextbox";
            this.phoneTextbox.Size = new System.Drawing.Size(543, 22);
            this.phoneTextbox.TabIndex = 6;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(142, 289);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(58, 29);
            this.emailLabel.TabIndex = 24;
            this.emailLabel.Text = "Email\r\n";
            // 
            // emailTextbox
            // 
            this.emailTextbox.Location = new System.Drawing.Point(215, 295);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(543, 22);
            this.emailTextbox.TabIndex = 5;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(114, 160);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(86, 29);
            this.passwordLabel.TabIndex = 22;
            this.passwordLabel.Text = "Password\r\n";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(111, 103);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(89, 29);
            this.usernameLabel.TabIndex = 16;
            this.usernameLabel.Text = "Username";
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Location = new System.Drawing.Point(215, 110);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(543, 22);
            this.usernameTextbox.TabIndex = 1;
            this.usernameTextbox.TextChanged += new System.EventHandler(this.usernameTextbox_TextChanged);
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.PowderBlue;
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 428);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(800, 22);
            this.panelFooter.TabIndex = 17;
            // 
            // exitButton
            // 
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.Location = new System.Drawing.Point(777, 10);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(23, 20);
            this.exitButton.TabIndex = 9;
            this.exitButton.TabStop = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click_1);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.PowderBlue;
            this.panelHeader.Controls.Add(this.exitButton);
            this.panelHeader.Controls.Add(this.folderIcon);
            this.panelHeader.Controls.Add(this.userInformationLabel);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 66);
            this.panelHeader.TabIndex = 20;
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
            // userInformationLabel
            // 
            this.userInformationLabel.AutoSize = true;
            this.userInformationLabel.Font = new System.Drawing.Font("Sitka Banner", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInformationLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.userInformationLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.userInformationLabel.Location = new System.Drawing.Point(28, 14);
            this.userInformationLabel.Name = "userInformationLabel";
            this.userInformationLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 10);
            this.userInformationLabel.Size = new System.Drawing.Size(165, 48);
            this.userInformationLabel.TabIndex = 7;
            this.userInformationLabel.Text = "User Information";
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(215, 165);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(543, 22);
            this.passwordTextbox.TabIndex = 2;
            this.passwordTextbox.UseSystemPasswordChar = true;
            this.passwordTextbox.TextChanged += new System.EventHandler(this.passwordTextbox_TextChanged);
            // 
            // clearUserInfoButton
            // 
            this.clearUserInfoButton.BackColor = System.Drawing.Color.Crimson;
            this.clearUserInfoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearUserInfoButton.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearUserInfoButton.ForeColor = System.Drawing.Color.White;
            this.clearUserInfoButton.Location = new System.Drawing.Point(483, 375);
            this.clearUserInfoButton.Name = "clearUserInfoButton";
            this.clearUserInfoButton.Size = new System.Drawing.Size(122, 39);
            this.clearUserInfoButton.TabIndex = 7;
            this.clearUserInfoButton.Text = "Clear";
            this.clearUserInfoButton.UseVisualStyleBackColor = false;
            this.clearUserInfoButton.Click += new System.EventHandler(this.clearUserInfoButton_Click);
            // 
            // availabilityLabel
            // 
            this.availabilityLabel.AutoSize = true;
            this.availabilityLabel.Font = new System.Drawing.Font("Sitka Banner", 9F);
            this.availabilityLabel.Location = new System.Drawing.Point(214, 86);
            this.availabilityLabel.Name = "availabilityLabel";
            this.availabilityLabel.Size = new System.Drawing.Size(104, 21);
            this.availabilityLabel.TabIndex = 33;
            this.availabilityLabel.Text = "Availability Label";
            this.availabilityLabel.Visible = false;
            // 
            // passwordMatchingLabel
            // 
            this.passwordMatchingLabel.AutoSize = true;
            this.passwordMatchingLabel.Font = new System.Drawing.Font("Sitka Banner", 9F);
            this.passwordMatchingLabel.Location = new System.Drawing.Point(214, 141);
            this.passwordMatchingLabel.Name = "passwordMatchingLabel";
            this.passwordMatchingLabel.Size = new System.Drawing.Size(151, 21);
            this.passwordMatchingLabel.TabIndex = 34;
            this.passwordMatchingLabel.Text = "Password matching label";
            this.passwordMatchingLabel.Visible = false;
            // 
            // CreateAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.passwordMatchingLabel);
            this.Controls.Add(this.availabilityLabel);
            this.Controls.Add(this.repasswordLabel);
            this.Controls.Add(this.repasswordTextbox);
            this.Controls.Add(this.fullnameTextbox);
            this.Controls.Add(this.fullnameLabel);
            this.Controls.Add(this.clearUserInfoButton);
            this.Controls.Add(this.createAccountButton);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.phoneTextbox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.emailTextbox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.usernameTextbox);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.passwordTextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateAccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.folderIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label repasswordLabel;
        public System.Windows.Forms.TextBox repasswordTextbox;
        public System.Windows.Forms.TextBox fullnameTextbox;
        private System.Windows.Forms.Label fullnameLabel;
        public System.Windows.Forms.Button createAccountButton;
        private System.Windows.Forms.Label phoneLabel;
        public System.Windows.Forms.TextBox phoneTextbox;
        private System.Windows.Forms.Label emailLabel;
        public System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        public System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.PictureBox exitButton;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox folderIcon;
        private System.Windows.Forms.Label userInformationLabel;
        public System.Windows.Forms.TextBox passwordTextbox;
        public System.Windows.Forms.Button clearUserInfoButton;
        private System.Windows.Forms.Label availabilityLabel;
        private System.Windows.Forms.Label passwordMatchingLabel;
    }
}