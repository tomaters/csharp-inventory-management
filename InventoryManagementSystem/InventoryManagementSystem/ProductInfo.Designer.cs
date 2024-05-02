namespace InventoryManagementSystem
{
    partial class ProductInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductInfo));
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.productDescriptionTextbox = new System.Windows.Forms.TextBox();
            this.updateProductInfoButton = new System.Windows.Forms.Button();
            this.productQuantityTextbox = new System.Windows.Forms.TextBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.clearProductInfoButton = new System.Windows.Forms.Button();
            this.saveProductInfoButton = new System.Windows.Forms.Button();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.productCategoryLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.productNameTextbox = new System.Windows.Forms.TextBox();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.folderIcon = new System.Windows.Forms.PictureBox();
            this.ProductInformationLabel = new System.Windows.Forms.Label();
            this.productPriceTextbox = new System.Windows.Forms.TextBox();
            this.productIdLabel = new System.Windows.Forms.Label();
            this.productCategoryComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.folderIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(84, 222);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(100, 29);
            this.descriptionLabel.TabIndex = 31;
            this.descriptionLabel.Text = "Description";
            // 
            // productDescriptionTextbox
            // 
            this.productDescriptionTextbox.Location = new System.Drawing.Point(203, 222);
            this.productDescriptionTextbox.Name = "productDescriptionTextbox";
            this.productDescriptionTextbox.Size = new System.Drawing.Size(543, 29);
            this.productDescriptionTextbox.TabIndex = 4;
            // 
            // updateProductInfoButton
            // 
            this.updateProductInfoButton.BackColor = System.Drawing.Color.SteelBlue;
            this.updateProductInfoButton.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateProductInfoButton.ForeColor = System.Drawing.Color.White;
            this.updateProductInfoButton.Location = new System.Drawing.Point(496, 315);
            this.updateProductInfoButton.Name = "updateProductInfoButton";
            this.updateProductInfoButton.Size = new System.Drawing.Size(122, 39);
            this.updateProductInfoButton.TabIndex = 7;
            this.updateProductInfoButton.Text = "Update";
            this.updateProductInfoButton.UseVisualStyleBackColor = false;
            this.updateProductInfoButton.Click += new System.EventHandler(this.updateUserInfoButton_Click);
            // 
            // productQuantityTextbox
            // 
            this.productQuantityTextbox.Location = new System.Drawing.Point(203, 138);
            this.productQuantityTextbox.Name = "productQuantityTextbox";
            this.productQuantityTextbox.Size = new System.Drawing.Size(543, 29);
            this.productQuantityTextbox.TabIndex = 2;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.Location = new System.Drawing.Point(104, 138);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(80, 29);
            this.quantityLabel.TabIndex = 19;
            this.quantityLabel.Text = "Quantity";
            // 
            // clearProductInfoButton
            // 
            this.clearProductInfoButton.BackColor = System.Drawing.Color.Crimson;
            this.clearProductInfoButton.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearProductInfoButton.ForeColor = System.Drawing.Color.White;
            this.clearProductInfoButton.Location = new System.Drawing.Point(368, 315);
            this.clearProductInfoButton.Name = "clearProductInfoButton";
            this.clearProductInfoButton.Size = new System.Drawing.Size(122, 39);
            this.clearProductInfoButton.TabIndex = 6;
            this.clearProductInfoButton.Text = "Clear";
            this.clearProductInfoButton.UseVisualStyleBackColor = false;
            this.clearProductInfoButton.Click += new System.EventHandler(this.clearUserInfoButton_Click);
            // 
            // saveProductInfoButton
            // 
            this.saveProductInfoButton.BackColor = System.Drawing.Color.ForestGreen;
            this.saveProductInfoButton.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveProductInfoButton.ForeColor = System.Drawing.Color.White;
            this.saveProductInfoButton.Location = new System.Drawing.Point(624, 315);
            this.saveProductInfoButton.Name = "saveProductInfoButton";
            this.saveProductInfoButton.Size = new System.Drawing.Size(122, 39);
            this.saveProductInfoButton.TabIndex = 8;
            this.saveProductInfoButton.Text = "Save";
            this.saveProductInfoButton.UseVisualStyleBackColor = false;
            this.saveProductInfoButton.Click += new System.EventHandler(this.saveUserInfoButton_Click);
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.Location = new System.Drawing.Point(184, 270);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(0, 29);
            this.phoneLabel.TabIndex = 26;
            // 
            // productCategoryLabel
            // 
            this.productCategoryLabel.AutoSize = true;
            this.productCategoryLabel.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productCategoryLabel.Location = new System.Drawing.Point(103, 264);
            this.productCategoryLabel.Name = "productCategoryLabel";
            this.productCategoryLabel.Size = new System.Drawing.Size(81, 29);
            this.productCategoryLabel.TabIndex = 24;
            this.productCategoryLabel.Text = "Category";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(133, 180);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(51, 29);
            this.priceLabel.TabIndex = 22;
            this.priceLabel.Text = "Price";
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameLabel.Location = new System.Drawing.Point(126, 96);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(58, 29);
            this.productNameLabel.TabIndex = 16;
            this.productNameLabel.Text = "Name";
            // 
            // productNameTextbox
            // 
            this.productNameTextbox.Location = new System.Drawing.Point(203, 96);
            this.productNameTextbox.Name = "productNameTextbox";
            this.productNameTextbox.Size = new System.Drawing.Size(543, 29);
            this.productNameTextbox.TabIndex = 1;
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.PowderBlue;
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 369);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(816, 22);
            this.panelFooter.TabIndex = 17;
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
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.PowderBlue;
            this.panelHeader.Controls.Add(this.exitButton);
            this.panelHeader.Controls.Add(this.folderIcon);
            this.panelHeader.Controls.Add(this.ProductInformationLabel);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(816, 66);
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
            // ProductInformationLabel
            // 
            this.ProductInformationLabel.AutoSize = true;
            this.ProductInformationLabel.Font = new System.Drawing.Font("Sitka Banner", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductInformationLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ProductInformationLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ProductInformationLabel.Location = new System.Drawing.Point(28, 14);
            this.ProductInformationLabel.Name = "ProductInformationLabel";
            this.ProductInformationLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 10);
            this.ProductInformationLabel.Size = new System.Drawing.Size(194, 48);
            this.ProductInformationLabel.TabIndex = 7;
            this.ProductInformationLabel.Text = "Product Information";
            // 
            // productPriceTextbox
            // 
            this.productPriceTextbox.Location = new System.Drawing.Point(203, 180);
            this.productPriceTextbox.Name = "productPriceTextbox";
            this.productPriceTextbox.Size = new System.Drawing.Size(543, 29);
            this.productPriceTextbox.TabIndex = 3;
            // 
            // productIdLabel
            // 
            this.productIdLabel.AutoSize = true;
            this.productIdLabel.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productIdLabel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.productIdLabel.Location = new System.Drawing.Point(29, 325);
            this.productIdLabel.Name = "productIdLabel";
            this.productIdLabel.Size = new System.Drawing.Size(96, 29);
            this.productIdLabel.TabIndex = 9;
            this.productIdLabel.Text = "Product ID";
            this.productIdLabel.Visible = false;
            // 
            // productCategoryComboBox
            // 
            this.productCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productCategoryComboBox.FormattingEnabled = true;
            this.productCategoryComboBox.Location = new System.Drawing.Point(203, 264);
            this.productCategoryComboBox.Name = "productCategoryComboBox";
            this.productCategoryComboBox.Size = new System.Drawing.Size(543, 32);
            this.productCategoryComboBox.TabIndex = 5;
            // 
            // ProductInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 391);
            this.Controls.Add(this.productCategoryComboBox);
            this.Controls.Add(this.productIdLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.productDescriptionTextbox);
            this.Controls.Add(this.updateProductInfoButton);
            this.Controls.Add(this.productQuantityTextbox);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.clearProductInfoButton);
            this.Controls.Add(this.saveProductInfoButton);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.productCategoryLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.productNameTextbox);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.productPriceTextbox);
            this.Font = new System.Drawing.Font("Sitka Banner", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ProductInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductInfo";
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.folderIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label descriptionLabel;
        public System.Windows.Forms.TextBox productDescriptionTextbox;
        public System.Windows.Forms.Button updateProductInfoButton;
        public System.Windows.Forms.TextBox productQuantityTextbox;
        private System.Windows.Forms.Label quantityLabel;
        public System.Windows.Forms.Button clearProductInfoButton;
        public System.Windows.Forms.Button saveProductInfoButton;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label productCategoryLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label productNameLabel;
        public System.Windows.Forms.TextBox productNameTextbox;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.PictureBox exitButton;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox folderIcon;
        private System.Windows.Forms.Label ProductInformationLabel;
        public System.Windows.Forms.TextBox productPriceTextbox;
        public System.Windows.Forms.Label productIdLabel;
        public System.Windows.Forms.ComboBox productCategoryComboBox;
    }
}