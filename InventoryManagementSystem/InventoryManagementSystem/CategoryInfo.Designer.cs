namespace InventoryManagementSystem
{
    partial class CategoryInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryInfo));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.PictureBox();
            this.folderIcon = new System.Windows.Forms.PictureBox();
            this.categoryInformationLabel = new System.Windows.Forms.Label();
            this.categoryIdLabel = new System.Windows.Forms.Label();
            this.updateCategoryInfoButton = new System.Windows.Forms.Button();
            this.categoryNameTextbox = new System.Windows.Forms.TextBox();
            this.categoryNameLabel = new System.Windows.Forms.Label();
            this.clearCategoryInfoButton = new System.Windows.Forms.Button();
            this.saveCategoryInfoButton = new System.Windows.Forms.Button();
            this.panelFooter = new System.Windows.Forms.Panel();
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
            this.panelHeader.Controls.Add(this.categoryInformationLabel);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(816, 66);
            this.panelHeader.TabIndex = 31;
            // 
            // exitButton
            // 
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.Location = new System.Drawing.Point(781, 10);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(23, 20);
            this.exitButton.TabIndex = 9;
            this.exitButton.TabStop = false;
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
            // categoryInformationLabel
            // 
            this.categoryInformationLabel.AutoSize = true;
            this.categoryInformationLabel.Font = new System.Drawing.Font("Sitka Banner", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryInformationLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.categoryInformationLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.categoryInformationLabel.Location = new System.Drawing.Point(28, 14);
            this.categoryInformationLabel.Name = "categoryInformationLabel";
            this.categoryInformationLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 10);
            this.categoryInformationLabel.Size = new System.Drawing.Size(204, 48);
            this.categoryInformationLabel.TabIndex = 7;
            this.categoryInformationLabel.Text = "Category Information";
            this.categoryInformationLabel.Click += new System.EventHandler(this.categoryInformationLabel_Click);
            // 
            // categoryIdLabel
            // 
            this.categoryIdLabel.AutoSize = true;
            this.categoryIdLabel.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryIdLabel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.categoryIdLabel.Location = new System.Drawing.Point(52, 135);
            this.categoryIdLabel.Name = "categoryIdLabel";
            this.categoryIdLabel.Size = new System.Drawing.Size(104, 29);
            this.categoryIdLabel.TabIndex = 42;
            this.categoryIdLabel.Text = "Category ID";
            this.categoryIdLabel.Visible = false;
            // 
            // updateCategoryInfoButton
            // 
            this.updateCategoryInfoButton.BackColor = System.Drawing.Color.SteelBlue;
            this.updateCategoryInfoButton.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCategoryInfoButton.ForeColor = System.Drawing.Color.White;
            this.updateCategoryInfoButton.Location = new System.Drawing.Point(482, 132);
            this.updateCategoryInfoButton.Name = "updateCategoryInfoButton";
            this.updateCategoryInfoButton.Size = new System.Drawing.Size(122, 39);
            this.updateCategoryInfoButton.TabIndex = 41;
            this.updateCategoryInfoButton.Text = "Update";
            this.updateCategoryInfoButton.UseVisualStyleBackColor = false;
            this.updateCategoryInfoButton.Click += new System.EventHandler(this.updateCategoryInfoButton_Click);
            // 
            // categoryNameTextbox
            // 
            this.categoryNameTextbox.Location = new System.Drawing.Point(189, 86);
            this.categoryNameTextbox.Name = "categoryNameTextbox";
            this.categoryNameTextbox.Size = new System.Drawing.Size(543, 29);
            this.categoryNameTextbox.TabIndex = 34;
            // 
            // categoryNameLabel
            // 
            this.categoryNameLabel.AutoSize = true;
            this.categoryNameLabel.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryNameLabel.Location = new System.Drawing.Point(39, 85);
            this.categoryNameLabel.Name = "categoryNameLabel";
            this.categoryNameLabel.Size = new System.Drawing.Size(131, 29);
            this.categoryNameLabel.TabIndex = 33;
            this.categoryNameLabel.Text = "Category Name";
            // 
            // clearCategoryInfoButton
            // 
            this.clearCategoryInfoButton.BackColor = System.Drawing.Color.Crimson;
            this.clearCategoryInfoButton.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearCategoryInfoButton.ForeColor = System.Drawing.Color.White;
            this.clearCategoryInfoButton.Location = new System.Drawing.Point(354, 132);
            this.clearCategoryInfoButton.Name = "clearCategoryInfoButton";
            this.clearCategoryInfoButton.Size = new System.Drawing.Size(122, 39);
            this.clearCategoryInfoButton.TabIndex = 39;
            this.clearCategoryInfoButton.Text = "Clear";
            this.clearCategoryInfoButton.UseVisualStyleBackColor = false;
            this.clearCategoryInfoButton.Click += new System.EventHandler(this.clearCategoryInfoButton_Click);
            // 
            // saveCategoryInfoButton
            // 
            this.saveCategoryInfoButton.BackColor = System.Drawing.Color.ForestGreen;
            this.saveCategoryInfoButton.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveCategoryInfoButton.ForeColor = System.Drawing.Color.White;
            this.saveCategoryInfoButton.Location = new System.Drawing.Point(610, 132);
            this.saveCategoryInfoButton.Name = "saveCategoryInfoButton";
            this.saveCategoryInfoButton.Size = new System.Drawing.Size(122, 39);
            this.saveCategoryInfoButton.TabIndex = 40;
            this.saveCategoryInfoButton.Text = "Save";
            this.saveCategoryInfoButton.UseVisualStyleBackColor = false;
            this.saveCategoryInfoButton.Click += new System.EventHandler(this.saveCategoryInfoButton_Click);
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.PowderBlue;
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 183);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(816, 22);
            this.panelFooter.TabIndex = 32;
            // 
            // CategoryInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 205);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.categoryIdLabel);
            this.Controls.Add(this.updateCategoryInfoButton);
            this.Controls.Add(this.categoryNameTextbox);
            this.Controls.Add(this.categoryNameLabel);
            this.Controls.Add(this.clearCategoryInfoButton);
            this.Controls.Add(this.saveCategoryInfoButton);
            this.Controls.Add(this.panelFooter);
            this.Font = new System.Drawing.Font("Sitka Banner", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CategoryInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoryInfo";
            this.Load += new System.EventHandler(this.CategoryInfo_Load);
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
        private System.Windows.Forms.Label categoryInformationLabel;
        public System.Windows.Forms.Label categoryIdLabel;
        public System.Windows.Forms.Button updateCategoryInfoButton;
        public System.Windows.Forms.TextBox categoryNameTextbox;
        private System.Windows.Forms.Label categoryNameLabel;
        public System.Windows.Forms.Button clearCategoryInfoButton;
        public System.Windows.Forms.Button saveCategoryInfoButton;
        private System.Windows.Forms.Panel panelFooter;
    }
}