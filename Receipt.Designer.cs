
namespace Wikramarachchi_Opticians
{
    partial class Receipt
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
            this.crystalReportViewerBill = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewerBill
            // 
            this.crystalReportViewerBill.ActiveViewIndex = -1;
            this.crystalReportViewerBill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerBill.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerBill.Location = new System.Drawing.Point(26, 22);
            this.crystalReportViewerBill.Name = "crystalReportViewerBill";
            this.crystalReportViewerBill.Size = new System.Drawing.Size(1318, 635);
            this.crystalReportViewerBill.TabIndex = 0;
            this.crystalReportViewerBill.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 697);
            this.Controls.Add(this.crystalReportViewerBill);
            this.Name = "Receipt";
            this.Text = "Receipt";
            this.ResumeLayout(false);

        }

        #endregion

       public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerBill;
    }
}