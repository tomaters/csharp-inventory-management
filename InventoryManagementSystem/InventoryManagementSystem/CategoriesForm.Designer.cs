namespace InventoryManagementSystem
{
    partial class CategoriesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoriesForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewUser = new System.Windows.Forms.DataGridView();
            this.Column0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.addCategoryButton = new System.Windows.Forms.Button();
            this.manageCategoriesLabel = new System.Windows.Forms.Label();
            this.dataGridViewCategory = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditCategory = new System.Windows.Forms.DataGridViewImageColumn();
            this.DeleteCategory = new System.Windows.Forms.DataGridViewImageColumn();
            this.searchCategoryTextbox = new System.Windows.Forms.TextBox();
            this.searchCategoryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).BeginInit();
            this.panelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUser
            // 
            this.dataGridViewUser.AllowUserToAddRows = false;
            this.dataGridViewUser.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Sitka Banner", 10.2F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewUser.ColumnHeadersHeight = 29;
            this.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column0,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Edit,
            this.Delete});
            this.dataGridViewUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUser.EnableHeadersVisualStyles = false;
            this.dataGridViewUser.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewUser.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewUser.Name = "dataGridViewUser";
            this.dataGridViewUser.RowHeadersWidth = 51;
            this.dataGridViewUser.RowTemplate.Height = 24;
            this.dataGridViewUser.Size = new System.Drawing.Size(816, 456);
            this.dataGridViewUser.TabIndex = 4;
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
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.PowderBlue;
            this.panelFooter.Controls.Add(this.searchCategoryTextbox);
            this.panelFooter.Controls.Add(this.searchCategoryLabel);
            this.panelFooter.Controls.Add(this.addCategoryButton);
            this.panelFooter.Controls.Add(this.manageCategoriesLabel);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 404);
            this.panelFooter.Margin = new System.Windows.Forms.Padding(4);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(816, 52);
            this.panelFooter.TabIndex = 5;
            // 
            // addCategoryButton
            // 
            this.addCategoryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addCategoryButton.Location = new System.Drawing.Point(678, 9);
            this.addCategoryButton.Margin = new System.Windows.Forms.Padding(4);
            this.addCategoryButton.Name = "addCategoryButton";
            this.addCategoryButton.Size = new System.Drawing.Size(125, 34);
            this.addCategoryButton.TabIndex = 4;
            this.addCategoryButton.Text = "Add a Category";
            this.addCategoryButton.UseVisualStyleBackColor = true;
            this.addCategoryButton.Click += new System.EventHandler(this.addCategoryButton_Click);
            // 
            // manageCategoriesLabel
            // 
            this.manageCategoriesLabel.AutoSize = true;
            this.manageCategoriesLabel.Location = new System.Drawing.Point(16, 14);
            this.manageCategoriesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.manageCategoriesLabel.Name = "manageCategoriesLabel";
            this.manageCategoriesLabel.Size = new System.Drawing.Size(132, 24);
            this.manageCategoriesLabel.TabIndex = 1;
            this.manageCategoriesLabel.Text = "Manage Categories";
            // 
            // dataGridViewCategory
            // 
            this.dataGridViewCategory.AllowUserToAddRows = false;
            this.dataGridViewCategory.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Sitka Banner", 10.2F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewCategory.ColumnHeadersHeight = 29;
            this.dataGridViewCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.EditCategory,
            this.DeleteCategory});
            this.dataGridViewCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCategory.EnableHeadersVisualStyles = false;
            this.dataGridViewCategory.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCategory.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewCategory.Name = "dataGridViewCategory";
            this.dataGridViewCategory.RowHeadersWidth = 51;
            this.dataGridViewCategory.RowTemplate.Height = 24;
            this.dataGridViewCategory.Size = new System.Drawing.Size(816, 404);
            this.dataGridViewCategory.TabIndex = 6;
            this.dataGridViewCategory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCategory_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "No";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.Width = 58;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.HeaderText = "Category ID";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 115;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "Name";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // EditCategory
            // 
            this.EditCategory.HeaderText = "";
            this.EditCategory.Image = ((System.Drawing.Image)(resources.GetObject("EditCategory.Image")));
            this.EditCategory.MinimumWidth = 6;
            this.EditCategory.Name = "EditCategory";
            this.EditCategory.ReadOnly = true;
            this.EditCategory.Width = 25;
            // 
            // DeleteCategory
            // 
            this.DeleteCategory.HeaderText = "";
            this.DeleteCategory.Image = ((System.Drawing.Image)(resources.GetObject("DeleteCategory.Image")));
            this.DeleteCategory.MinimumWidth = 6;
            this.DeleteCategory.Name = "DeleteCategory";
            this.DeleteCategory.ReadOnly = true;
            this.DeleteCategory.Width = 25;
            // 
            // searchCategoryTextbox
            // 
            this.searchCategoryTextbox.Location = new System.Drawing.Point(261, 12);
            this.searchCategoryTextbox.Name = "searchCategoryTextbox";
            this.searchCategoryTextbox.Size = new System.Drawing.Size(354, 29);
            this.searchCategoryTextbox.TabIndex = 11;
            this.searchCategoryTextbox.TextChanged += new System.EventHandler(this.searchCategoryTextbox_TextChanged);
            // 
            // searchCategoryLabel
            // 
            this.searchCategoryLabel.AutoSize = true;
            this.searchCategoryLabel.Location = new System.Drawing.Point(202, 14);
            this.searchCategoryLabel.Name = "searchCategoryLabel";
            this.searchCategoryLabel.Size = new System.Drawing.Size(53, 24);
            this.searchCategoryLabel.TabIndex = 12;
            this.searchCategoryLabel.Text = "Search";
            // 
            // CategoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 456);
            this.Controls.Add(this.dataGridViewCategory);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.dataGridViewUser);
            this.Font = new System.Drawing.Font("Sitka Banner", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "CategoriesForm";
            this.Text = "CategoriesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column0;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Button addCategoryButton;
        private System.Windows.Forms.Label manageCategoriesLabel;
        private System.Windows.Forms.DataGridView dataGridViewCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewImageColumn EditCategory;
        private System.Windows.Forms.DataGridViewImageColumn DeleteCategory;
        public System.Windows.Forms.TextBox searchCategoryTextbox;
        private System.Windows.Forms.Label searchCategoryLabel;
    }
}