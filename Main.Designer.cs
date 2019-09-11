namespace PharmacyApp
{
    partial class Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tlpDataRecords = new System.Windows.Forms.TableLayoutPanel();
            this.lblStockCode = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnAddRecord = new System.Windows.Forms.Button();
            this.btnEditRecord = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPredict = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tlpDataRecords.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tlpDataRecords);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 517);
            this.panel1.TabIndex = 0;
            // 
            // tlpDataRecords
            // 
            this.tlpDataRecords.AutoScroll = true;
            this.tlpDataRecords.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpDataRecords.ColumnCount = 4;
            this.tlpDataRecords.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpDataRecords.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpDataRecords.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpDataRecords.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpDataRecords.Controls.Add(this.lblStockCode, 0, 0);
            this.tlpDataRecords.Controls.Add(this.lblDescription, 1, 0);
            this.tlpDataRecords.Controls.Add(this.lblQuantity, 2, 0);
            this.tlpDataRecords.Controls.Add(this.lblPrice, 3, 0);
            this.tlpDataRecords.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpDataRecords.Location = new System.Drawing.Point(0, 0);
            this.tlpDataRecords.Name = "tlpDataRecords";
            this.tlpDataRecords.Padding = new System.Windows.Forms.Padding(5);
            this.tlpDataRecords.RowCount = 1;
            this.tlpDataRecords.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDataRecords.Size = new System.Drawing.Size(716, 39);
            this.tlpDataRecords.TabIndex = 0;
            // 
            // lblStockCode
            // 
            this.lblStockCode.AutoSize = true;
            this.lblStockCode.Location = new System.Drawing.Point(9, 6);
            this.lblStockCode.Name = "lblStockCode";
            this.lblStockCode.Size = new System.Drawing.Size(109, 24);
            this.lblStockCode.TabIndex = 0;
            this.lblStockCode.Text = "Stock Code";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(185, 6);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(110, 24);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(361, 6);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(86, 24);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(537, 6);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(53, 24);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price";
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRecord.Location = new System.Drawing.Point(752, 56);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(93, 64);
            this.btnAddRecord.TabIndex = 1;
            this.btnAddRecord.Text = "Add Record";
            this.btnAddRecord.UseVisualStyleBackColor = true;
            this.btnAddRecord.Click += new System.EventHandler(this.BtnAddRecord_Click);
            // 
            // btnEditRecord
            // 
            this.btnEditRecord.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditRecord.Location = new System.Drawing.Point(752, 145);
            this.btnEditRecord.Name = "btnEditRecord";
            this.btnEditRecord.Size = new System.Drawing.Size(93, 64);
            this.btnEditRecord.TabIndex = 2;
            this.btnEditRecord.Text = "Edit Record";
            this.btnEditRecord.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 555);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 64);
            this.button1.TabIndex = 3;
            this.button1.Text = "Display Reports";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnPredict
            // 
            this.btnPredict.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPredict.Location = new System.Drawing.Point(307, 555);
            this.btnPredict.Name = "btnPredict";
            this.btnPredict.Size = new System.Drawing.Size(125, 64);
            this.btnPredict.TabIndex = 4;
            this.btnPredict.Text = "Predict Sales";
            this.btnPredict.UseVisualStyleBackColor = true;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(602, 555);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(125, 64);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "Generate CSV";
            this.btnGenerate.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 645);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnPredict);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEditRecord);
            this.Controls.Add(this.btnAddRecord);
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.tlpDataRecords.ResumeLayout(false);
            this.tlpDataRecords.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tlpDataRecords;
        private System.Windows.Forms.Label lblStockCode;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnAddRecord;
        private System.Windows.Forms.Button btnEditRecord;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPredict;
        private System.Windows.Forms.Button btnGenerate;
    }
}

