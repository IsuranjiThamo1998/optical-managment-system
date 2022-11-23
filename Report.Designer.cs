
namespace Wikramarachchi_Opticians
{
    partial class Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.btnSalesReport = new System.Windows.Forms.Button();
            this.btnFrameReport = new System.Windows.Forms.Button();
            this.btnCusReport = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnLensReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalesReport
            // 
            this.btnSalesReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSalesReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesReport.Location = new System.Drawing.Point(776, 369);
            this.btnSalesReport.Name = "btnSalesReport";
            this.btnSalesReport.Size = new System.Drawing.Size(366, 102);
            this.btnSalesReport.TabIndex = 0;
            this.btnSalesReport.Text = "Generate Sales Report";
            this.btnSalesReport.UseVisualStyleBackColor = false;
            this.btnSalesReport.Click += new System.EventHandler(this.btnSaleReport_Click);
            // 
            // btnFrameReport
            // 
            this.btnFrameReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnFrameReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrameReport.Location = new System.Drawing.Point(776, 736);
            this.btnFrameReport.Name = "btnFrameReport";
            this.btnFrameReport.Size = new System.Drawing.Size(366, 102);
            this.btnFrameReport.TabIndex = 1;
            this.btnFrameReport.Text = "Generate Frame Report";
            this.btnFrameReport.UseVisualStyleBackColor = false;
            this.btnFrameReport.Click += new System.EventHandler(this.btnFrameReport_Click);
            // 
            // btnCusReport
            // 
            this.btnCusReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCusReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCusReport.Location = new System.Drawing.Point(776, 179);
            this.btnCusReport.Name = "btnCusReport";
            this.btnCusReport.Size = new System.Drawing.Size(366, 102);
            this.btnCusReport.TabIndex = 2;
            this.btnCusReport.Text = "Generate Customer Report";
            this.btnCusReport.UseVisualStyleBackColor = false;
            this.btnCusReport.Click += new System.EventHandler(this.btnCusReport_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.AutoEllipsis = true;
            this.btnLogout.BackColor = System.Drawing.Color.MediumBlue;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLogout.FlatAppearance.BorderSize = 2;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Location = new System.Drawing.Point(893, 868);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 61);
            this.btnLogout.TabIndex = 25;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnLensReport
            // 
            this.btnLensReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLensReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLensReport.Location = new System.Drawing.Point(776, 561);
            this.btnLensReport.Name = "btnLensReport";
            this.btnLensReport.Size = new System.Drawing.Size(366, 102);
            this.btnLensReport.TabIndex = 27;
            this.btnLensReport.Text = "Generate Lens Report";
            this.btnLensReport.UseVisualStyleBackColor = false;
            this.btnLensReport.Click += new System.EventHandler(this.btnLensReport_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1831, 932);
            this.Controls.Add(this.btnLensReport);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnCusReport);
            this.Controls.Add(this.btnFrameReport);
            this.Controls.Add(this.btnSalesReport);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Report";
            this.Text = "Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Report_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalesReport;
        private System.Windows.Forms.Button btnFrameReport;
        private System.Windows.Forms.Button btnCusReport;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnLensReport;
    }
}