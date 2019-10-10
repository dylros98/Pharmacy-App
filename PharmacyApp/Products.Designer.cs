namespace PharmacyApp
{
    partial class Products
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tlpDataRecords = new System.Windows.Forms.TableLayoutPanel();
            this.lblProductID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.addNewProduct = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblCategory = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tlpDataRecords.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tlpDataRecords);
            this.panel1.Location = new System.Drawing.Point(22, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1053, 528);
            this.panel1.TabIndex = 7;
            // 
            // tlpDataRecords
            // 
            this.tlpDataRecords.AutoScroll = true;
            this.tlpDataRecords.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpDataRecords.ColumnCount = 5;
            this.tlpDataRecords.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpDataRecords.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpDataRecords.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpDataRecords.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpDataRecords.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpDataRecords.Controls.Add(this.lblProductID, 0, 0);
            this.tlpDataRecords.Controls.Add(this.lblName, 1, 0);
            this.tlpDataRecords.Controls.Add(this.lblDescription, 2, 0);
            this.tlpDataRecords.Controls.Add(this.lblPrice, 3, 0);
            this.tlpDataRecords.Controls.Add(this.lblCategory, 4, 0);
            this.tlpDataRecords.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpDataRecords.ForeColor = System.Drawing.Color.White;
            this.tlpDataRecords.Location = new System.Drawing.Point(0, 0);
            this.tlpDataRecords.Margin = new System.Windows.Forms.Padding(0);
            this.tlpDataRecords.Name = "tlpDataRecords";
            this.tlpDataRecords.RowCount = 2;
            this.tlpDataRecords.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpDataRecords.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDataRecords.Size = new System.Drawing.Size(1053, 528);
            this.tlpDataRecords.TabIndex = 0;
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductID.Location = new System.Drawing.Point(4, 1);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(157, 34);
            this.lblProductID.TabIndex = 0;
            this.lblProductID.Text = "Product ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(214, 1);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(99, 34);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(424, 1);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(169, 34);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(634, 1);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(83, 34);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(570, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "People Health Pharmacy - Products";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(179)))), ((int)(((byte)(209)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-2, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1257, 88);
            this.panel2.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(181)))), ((int)(((byte)(191)))));
            this.panel4.Location = new System.Drawing.Point(-2, 68);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1254, 20);
            this.panel4.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(181)))), ((int)(((byte)(191)))));
            this.panel3.Location = new System.Drawing.Point(-2, 106);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(996, 20);
            this.panel3.TabIndex = 6;
            // 
            // addNewProduct
            // 
            this.addNewProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(206)))), ((int)(((byte)(211)))));
            this.addNewProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewProduct.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewProduct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addNewProduct.Location = new System.Drawing.Point(1094, 147);
            this.addNewProduct.Name = "addNewProduct";
            this.addNewProduct.Size = new System.Drawing.Size(129, 80);
            this.addNewProduct.TabIndex = 12;
            this.addNewProduct.Text = "Add Product";
            this.addNewProduct.UseVisualStyleBackColor = false;
            this.addNewProduct.Click += new System.EventHandler(this.AddNewProduct_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(206)))), ((int)(((byte)(211)))));
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(1094, 552);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(129, 80);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(844, 1);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(145, 34);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "Category";
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(1241, 652);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.addNewProduct);
            this.Controls.Add(this.btnBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            this.panel1.ResumeLayout(false);
            this.tlpDataRecords.ResumeLayout(false);
            this.tlpDataRecords.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tlpDataRecords;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button addNewProduct;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblCategory;
    }
}