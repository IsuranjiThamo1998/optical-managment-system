
namespace Wikramarachchi_Opticians
{
    partial class Lens_Report
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
            this.LensCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // LensCrystalReportViewer
            // 
            this.LensCrystalReportViewer.ActiveViewIndex = -1;
            this.LensCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LensCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.LensCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LensCrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.LensCrystalReportViewer.Name = "LensCrystalReportViewer";
            this.LensCrystalReportViewer.Size = new System.Drawing.Size(1229, 661);
            this.LensCrystalReportViewer.TabIndex = 0;
            this.LensCrystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.LensCrystalReportViewer.Load += new System.EventHandler(this.LensCrystalReportViewer_Load);
            // 
            // Lens_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 661);
            this.Controls.Add(this.LensCrystalReportViewer);
            this.Name = "Lens_Report";
            this.Text = "Lens_Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer LensCrystalReportViewer;
    }
}