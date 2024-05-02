namespace InventoryManagementSystem
{
    partial class UsersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersForm));
            this.panelFooter = new System.Windows.Forms.Panel();
            this.addUserButton = new System.Windows.Forms.Button();
            this.manageUsersLabel = new System.Windows.Forms.Label();
            this.dataGridViewUser = new System.Windows.Forms.DataGridView();
            this.Column0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditUser = new System.Windows.Forms.DataGridViewImageColumn();
            this.DeleteUser = new System.Windows.Forms.DataGridViewImageColumn();
            this.searchUserTextbox = new System.Windows.Forms.TextBox();
            this.searchUserLabel = new System.Windows.Forms.Label();
            this.panelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.PowderBlue;
            this.panelFooter.Controls.Add(this.searchUserTextbox);
            this.panelFooter.Controls.Add(this.searchUserLabel);
            this.panelFooter.Controls.Add(this.addUserButton);
            this.panelFooter.Controls.Add(this.manageUsersLabel);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 415);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(816, 41);
            this.panelFooter.TabIndex = 2;
            // 
            // addUserButton
            // 
            this.addUserButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addUserButton.Location = new System.Drawing.Point(710, 4);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(94, 32);
            this.addUserButton.TabIndex = 4;
            this.addUserButton.Text = "Add a User";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // manageUsersLabel
            // 
            this.manageUsersLabel.AutoSize = true;
            this.manageUsersLabel.Location = new System.Drawing.Point(12, 8);
            this.manageUsersLabel.Name = "manageUsersLabel";
            this.manageUsersLabel.Size = new System.Drawing.Size(100, 24);
            this.manageUsersLabel.TabIndex = 1;
            this.manageUsersLabel.Text = "Manage Users";
            // 
            // dataGridViewUser
            // 
            this.dataGridViewUser.AllowUserToAddRows = false;
            this.dataGridViewUser.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Sitka Banner", 10.2F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewUser.ColumnHeadersHeight = 29;
            this.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column0,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.EditUser,
            this.DeleteUser});
            this.dataGridViewUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUser.EnableHeadersVisualStyles = false;
            this.dataGridViewUser.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewUser.Name = "dataGridViewUser";
            this.dataGridViewUser.RowHeadersWidth = 51;
            this.dataGridViewUser.RowTemplate.Height = 24;
            this.dataGridViewUser.Size = new System.Drawing.Size(816, 415);
            this.dataGridViewUser.TabIndex = 3;
            this.dataGridViewUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUser_CellContentClick);
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
            this.Column1.HeaderText = "Username";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 104;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Full Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "Email Address";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 130;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "Phone Number";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 137;
            // 
            // EditUser
            // 
            this.EditUser.HeaderText = "";
            this.EditUser.Image = ((System.Drawing.Image)(resources.GetObject("EditUser.Image")));
            this.EditUser.MinimumWidth = 6;
            this.EditUser.Name = "EditUser";
            this.EditUser.ReadOnly = true;
            this.EditUser.Width = 25;
            // 
            // DeleteUser
            // 
            this.DeleteUser.HeaderText = "";
            this.DeleteUser.Image = ((System.Drawing.Image)(resources.GetObject("DeleteUser.Image")));
            this.DeleteUser.MinimumWidth = 6;
            this.DeleteUser.Name = "DeleteUser";
            this.DeleteUser.ReadOnly = true;
            this.DeleteUser.Width = 25;
            // 
            // searchUserTextbox
            // 
            this.searchUserTextbox.Location = new System.Drawing.Point(261, 6);
            this.searchUserTextbox.Name = "searchUserTextbox";
            this.searchUserTextbox.Size = new System.Drawing.Size(354, 29);
            this.searchUserTextbox.TabIndex = 7;
            this.searchUserTextbox.TextChanged += new System.EventHandler(this.searchUserTextbox_TextChanged);
            // 
            // searchUserLabel
            // 
            this.searchUserLabel.AutoSize = true;
            this.searchUserLabel.Location = new System.Drawing.Point(202, 8);
            this.searchUserLabel.Name = "searchUserLabel";
            this.searchUserLabel.Size = new System.Drawing.Size(53, 24);
            this.searchUserLabel.TabIndex = 8;
            this.searchUserLabel.Text = "Search";
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 456);
            this.Controls.Add(this.dataGridViewUser);
            this.Controls.Add(this.panelFooter);
            this.Font = new System.Drawing.Font("Sitka Banner", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UsersForm";
            this.Text = "UserForm";
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.DataGridView dataGridViewUser;
        private System.Windows.Forms.Label manageUsersLabel;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column0;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewImageColumn EditUser;
        private System.Windows.Forms.DataGridViewImageColumn DeleteUser;
        public System.Windows.Forms.TextBox searchUserTextbox;
        private System.Windows.Forms.Label searchUserLabel;
    }
}