namespace PharmacyApp
{
    partial class EditSalesRecord
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
            this.btnSave = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.txtDateSold = new System.Windows.Forms.TextBox();
            this.lblDateSold = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(206)))), ((int)(((byte)(211)))));
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(526, 221);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 44);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(230, 164);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(397, 37);
            this.txtQuantity.TabIndex = 13;
            // 
            // txtProductID
            // 
            this.txtProductID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductID.Location = new System.Drawing.Point(230, 41);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(397, 37);
            this.txtProductID.TabIndex = 12;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.White;
            this.lblQuantity.Location = new System.Drawing.Point(67, 171);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(115, 30);
            this.lblQuantity.TabIndex = 11;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductID.ForeColor = System.Drawing.Color.White;
            this.lblProductID.Location = new System.Drawing.Point(67, 44);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(136, 30);
            this.lblProductID.TabIndex = 10;
            this.lblProductID.Text = "Product ID";
            // 
            // txtDateSold
            // 
            this.txtDateSold.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateSold.Location = new System.Drawing.Point(230, 104);
            this.txtDateSold.Name = "txtDateSold";
            this.txtDateSold.Size = new System.Drawing.Size(397, 37);
            this.txtDateSold.TabIndex = 17;
            // 
            // lblDateSold
            // 
            this.lblDateSold.AutoSize = true;
            this.lblDateSold.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateSold.ForeColor = System.Drawing.Color.White;
            this.lblDateSold.Location = new System.Drawing.Point(67, 107);
            this.lblDateSold.Name = "lblDateSold";
            this.lblDateSold.Size = new System.Drawing.Size(128, 30);
            this.lblDateSold.TabIndex = 16;
            this.lblDateSold.Text = "Date Sold";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(109)))), ((int)(((byte)(154)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblProductID);
            this.panel1.Controls.Add(this.lblDateSold);
            this.panel1.Controls.Add(this.lblQuantity);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 277);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(206)))), ((int)(((byte)(211)))));
            this.panel2.Location = new System.Drawing.Point(-13, -6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(54, 308);
            this.panel2.TabIndex = 3;
            // 
            // EditSalesRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(640, 277);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtDateSold);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtProductID);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "EditSalesRecord";
            this.Text = "EditSalesRecord";
            this.Load += new System.EventHandler(this.EditSalesRecord_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.TextBox txtDateSold;
        private System.Windows.Forms.Label lblDateSold;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}