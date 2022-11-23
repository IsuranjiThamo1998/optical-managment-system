
namespace Wikramarachchi_Opticians
{
    partial class Customer_Report
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
            this.CustomerCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CustomerCrystalReportViewer
            // 
            this.CustomerCrystalReportViewer.ActiveViewIndex = -1;
            this.CustomerCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CustomerCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.CustomerCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomerCrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.CustomerCrystalReportViewer.Name = "CustomerCrystalReportViewer";
            this.CustomerCrystalReportViewer.Size = new System.Drawing.Size(1414, 592);
            this.CustomerCrystalReportViewer.TabIndex = 0;
            this.CustomerCrystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.CustomerCrystalReportViewer.Load += new System.EventHandler(this.CustomerCrystalReportViewer_Load);
            // 
            // Customer_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 592);
            this.Controls.Add(this.CustomerCrystalReportViewer);
            this.Name = "Customer_Report";
            this.Text = "Customer_Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CustomerCrystalReportViewer;
    }
}