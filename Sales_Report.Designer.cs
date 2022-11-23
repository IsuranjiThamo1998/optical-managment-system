
namespace Wikramarachchi_Opticians
{
    partial class Sales_Report
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
            this.SalesCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // SalesCrystalReportViewer
            // 
            this.SalesCrystalReportViewer.ActiveViewIndex = -1;
            this.SalesCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SalesCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.SalesCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalesCrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.SalesCrystalReportViewer.Name = "SalesCrystalReportViewer";
            this.SalesCrystalReportViewer.Size = new System.Drawing.Size(1482, 595);
            this.SalesCrystalReportViewer.TabIndex = 0;
            this.SalesCrystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Sales_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 595);
            this.Controls.Add(this.SalesCrystalReportViewer);
            this.Name = "Sales_Report";
            this.Text = "Sales_Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Sales_Report_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer SalesCrystalReportViewer;
    }
}