namespace PharmacyApp
{
    partial class DateSelection
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMonthlyReport = new System.Windows.Forms.Button();
            this.btnWeeklyReport = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.btnGenerateCSV = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(179)))), ((int)(((byte)(209)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 712);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(181)))), ((int)(((byte)(191)))));
            this.panel2.Location = new System.Drawing.Point(174, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(39, 726);
            this.panel2.TabIndex = 3;
            // 
            // btnMonthlyReport
            // 
            this.btnMonthlyReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(206)))), ((int)(((byte)(211)))));
            this.btnMonthlyReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonthlyReport.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonthlyReport.Location = new System.Drawing.Point(429, 508);
            this.btnMonthlyReport.Name = "btnMonthlyReport";
            this.btnMonthlyReport.Size = new System.Drawing.Size(168, 88);
            this.btnMonthlyReport.TabIndex = 4;
            this.btnMonthlyReport.Text = "Monthly Report";
            this.btnMonthlyReport.UseVisualStyleBackColor = false;
            this.btnMonthlyReport.Click += new System.EventHandler(this.BtnMonthlyReport_Click);
            // 
            // btnWeeklyReport
            // 
            this.btnWeeklyReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(206)))), ((int)(((byte)(211)))));
            this.btnWeeklyReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnWeeklyReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWeeklyReport.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeeklyReport.Location = new System.Drawing.Point(241, 508);
            this.btnWeeklyReport.Name = "btnWeeklyReport";
            this.btnWeeklyReport.Size = new System.Drawing.Size(168, 88);
            this.btnWeeklyReport.TabIndex = 3;
            this.btnWeeklyReport.Text = "Weekly Report";
            this.btnWeeklyReport.UseVisualStyleBackColor = false;
            this.btnWeeklyReport.Click += new System.EventHandler(this.BtnWeeklyReport_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(206)))), ((int)(((byte)(211)))));
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(468, 615);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(129, 80);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // monthCalendar
            // 
            this.monthCalendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.monthCalendar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar.ForeColor = System.Drawing.Color.White;
            this.monthCalendar.Location = new System.Drawing.Point(241, 19);
            this.monthCalendar.MaxSelectionCount = 31;
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.monthCalendar.ShowTodayCircle = false;
            this.monthCalendar.TabIndex = 7;
            this.monthCalendar.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(179)))), ((int)(((byte)(209)))));
            this.monthCalendar.TitleForeColor = System.Drawing.Color.White;
            this.monthCalendar.TrailingForeColor = System.Drawing.Color.DarkGray;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(206)))), ((int)(((byte)(211)))));
            this.btnGenerateReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateReport.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateReport.Location = new System.Drawing.Point(241, 309);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(356, 89);
            this.btnGenerateReport.TabIndex = 8;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = false;
            // 
            // btnGenerateCSV
            // 
            this.btnGenerateCSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(206)))), ((int)(((byte)(211)))));
            this.btnGenerateCSV.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGenerateCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateCSV.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateCSV.Location = new System.Drawing.Point(241, 404);
            this.btnGenerateCSV.Name = "btnGenerateCSV";
            this.btnGenerateCSV.Size = new System.Drawing.Size(356, 89);
            this.btnGenerateCSV.TabIndex = 9;
            this.btnGenerateCSV.Text = "Generate CSV";
            this.btnGenerateCSV.UseVisualStyleBackColor = false;
            // 
            // DateSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(609, 707);
            this.Controls.Add(this.btnGenerateCSV);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMonthlyReport);
            this.Controls.Add(this.btnWeeklyReport);
            this.Name = "DateSelection";
            this.Text = "DateSelection";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMonthlyReport;
        private System.Windows.Forms.Button btnWeeklyReport;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Button btnGenerateCSV;
    }
}