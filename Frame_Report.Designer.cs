
namespace Wikramarachchi_Opticians
{
    partial class Frame_Report
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
            this.FrameCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // FrameCrystalReportViewer
            // 
            this.FrameCrystalReportViewer.ActiveViewIndex = -1;
            this.FrameCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FrameCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.FrameCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FrameCrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.FrameCrystalReportViewer.Name = "FrameCrystalReportViewer";
            this.FrameCrystalReportViewer.Size = new System.Drawing.Size(1244, 658);
            this.FrameCrystalReportViewer.TabIndex = 0;
            this.FrameCrystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.FrameCrystalReportViewer.Load += new System.EventHandler(this.StockCrystalReportViewer_Load);
            // 
            // Frame_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 658);
            this.Controls.Add(this.FrameCrystalReportViewer);
            this.Name = "Frame_Report";
            this.Text = "Frame_Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer FrameCrystalReportViewer;
    }
}