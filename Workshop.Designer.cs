
namespace Wikramarachchi_Opticians
{
    partial class Workshop
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Workshop));
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.dgvWorkshop = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.txtWorkID = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFrameID = new System.Windows.Forms.TextBox();
            this.lblFrameID = new System.Windows.Forms.Label();
            this.txtRightEyePower = new System.Windows.Forms.TextBox();
            this.lblRightEyePower = new System.Windows.Forms.Label();
            this.txtLensID = new System.Windows.Forms.TextBox();
            this.txtLeftEyePower = new System.Windows.Forms.TextBox();
            this.lblLensID = new System.Windows.Forms.Label();
            this.lblLeftEyePower = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkshop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(852, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 83);
            this.label1.TabIndex = 29;
            this.label1.Text = "Workshop";
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnLogout.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogout.FlatAppearance.BorderSize = 2;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(1437, 830);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(156, 59);
            this.btnLogout.TabIndex = 89;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnDone
            // 
            this.btnDone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDone.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnDone.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnDone.FlatAppearance.BorderSize = 2;
            this.btnDone.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.ForeColor = System.Drawing.Color.White;
            this.btnDone.Location = new System.Drawing.Point(540, 843);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(156, 59);
            this.btnDone.TabIndex = 88;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // dgvWorkshop
            // 
            this.dgvWorkshop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvWorkshop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvWorkshop.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvWorkshop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvWorkshop.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWorkshop.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvWorkshop.ColumnHeadersHeight = 40;
            this.dgvWorkshop.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvWorkshop.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvWorkshop.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvWorkshop.Location = new System.Drawing.Point(1294, 168);
            this.dgvWorkshop.Name = "dgvWorkshop";
            this.dgvWorkshop.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWorkshop.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvWorkshop.RowHeadersVisible = false;
            this.dgvWorkshop.RowHeadersWidth = 51;
            this.dgvWorkshop.RowTemplate.Height = 24;
            this.dgvWorkshop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWorkshop.Size = new System.Drawing.Size(313, 542);
            this.dgvWorkshop.TabIndex = 90;
            this.dgvWorkshop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWorkshop_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 804);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 91;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(651, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(122, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 92;
            this.pictureBox2.TabStop = false;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 29);
            this.label2.TabIndex = 118;
            this.label2.Text = "Patient ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPatientID
            // 
            this.txtPatientID.BackColor = System.Drawing.SystemColors.Control;
            this.txtPatientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientID.Location = new System.Drawing.Point(459, 224);
            this.txtPatientID.Multiline = true;
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(327, 52);
            this.txtPatientID.TabIndex = 117;
            this.txtPatientID.Validating += new System.ComponentModel.CancelEventHandler(this.txtPatientID_Validating_1);
            // 
            // txtWorkID
            // 
            this.txtWorkID.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtWorkID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWorkID.Location = new System.Drawing.Point(459, 137);
            this.txtWorkID.Multiline = true;
            this.txtWorkID.Name = "txtWorkID";
            this.txtWorkID.Size = new System.Drawing.Size(327, 54);
            this.txtWorkID.TabIndex = 115;
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.SystemColors.Control;
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(459, 377);
            this.txtAge.Multiline = true;
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(327, 49);
            this.txtAge.TabIndex = 114;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.BackColor = System.Drawing.Color.Transparent;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(80, 397);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(59, 29);
            this.lblAge.TabIndex = 113;
            this.lblAge.Text = "Age";
            this.lblAge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.BackColor = System.Drawing.Color.Transparent;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(81, 310);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(133, 29);
            this.lblFullName.TabIndex = 112;
            this.lblFullName.Text = "Full Name";
            this.lblFullName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFullName
            // 
            this.txtFullName.BackColor = System.Drawing.SystemColors.Control;
            this.txtFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(459, 297);
            this.txtFullName.Multiline = true;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(327, 52);
            this.txtFullName.TabIndex = 111;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 29);
            this.label3.TabIndex = 110;
            this.label3.Text = "Work ID";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFrameID
            // 
            this.txtFrameID.BackColor = System.Drawing.SystemColors.Control;
            this.txtFrameID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrameID.Location = new System.Drawing.Point(459, 736);
            this.txtFrameID.Multiline = true;
            this.txtFrameID.Name = "txtFrameID";
            this.txtFrameID.Size = new System.Drawing.Size(327, 49);
            this.txtFrameID.TabIndex = 116;
            this.txtFrameID.Validating += new System.ComponentModel.CancelEventHandler(this.txtFrameID_Validating_1);
            // 
            // lblFrameID
            // 
            this.lblFrameID.AutoSize = true;
            this.lblFrameID.BackColor = System.Drawing.Color.Transparent;
            this.lblFrameID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrameID.Location = new System.Drawing.Point(81, 739);
            this.lblFrameID.Name = "lblFrameID";
            this.lblFrameID.Size = new System.Drawing.Size(120, 29);
            this.lblFrameID.TabIndex = 109;
            this.lblFrameID.Text = "Frame ID";
            this.lblFrameID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRightEyePower
            // 
            this.txtRightEyePower.BackColor = System.Drawing.SystemColors.Control;
            this.txtRightEyePower.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRightEyePower.Location = new System.Drawing.Point(459, 461);
            this.txtRightEyePower.Multiline = true;
            this.txtRightEyePower.Name = "txtRightEyePower";
            this.txtRightEyePower.Size = new System.Drawing.Size(327, 49);
            this.txtRightEyePower.TabIndex = 108;
            this.txtRightEyePower.Validating += new System.ComponentModel.CancelEventHandler(this.txtRightEyePower_Validating_1);
            // 
            // lblRightEyePower
            // 
            this.lblRightEyePower.AutoSize = true;
            this.lblRightEyePower.BackColor = System.Drawing.Color.Transparent;
            this.lblRightEyePower.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRightEyePower.Location = new System.Drawing.Point(80, 481);
            this.lblRightEyePower.Name = "lblRightEyePower";
            this.lblRightEyePower.Size = new System.Drawing.Size(207, 29);
            this.lblRightEyePower.TabIndex = 107;
            this.lblRightEyePower.Text = "Right Eye Power";
            this.lblRightEyePower.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLensID
            // 
            this.txtLensID.BackColor = System.Drawing.SystemColors.Control;
            this.txtLensID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLensID.Location = new System.Drawing.Point(459, 645);
            this.txtLensID.Multiline = true;
            this.txtLensID.Name = "txtLensID";
            this.txtLensID.Size = new System.Drawing.Size(327, 49);
            this.txtLensID.TabIndex = 106;
            this.txtLensID.Validating += new System.ComponentModel.CancelEventHandler(this.txtLensID_Validating_1);
            // 
            // txtLeftEyePower
            // 
            this.txtLeftEyePower.BackColor = System.Drawing.SystemColors.Control;
            this.txtLeftEyePower.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLeftEyePower.Location = new System.Drawing.Point(459, 547);
            this.txtLeftEyePower.Multiline = true;
            this.txtLeftEyePower.Name = "txtLeftEyePower";
            this.txtLeftEyePower.Size = new System.Drawing.Size(327, 54);
            this.txtLeftEyePower.TabIndex = 105;
            this.txtLeftEyePower.Validating += new System.ComponentModel.CancelEventHandler(this.txtLeftEyePower_Validating_1);
            // 
            // lblLensID
            // 
            this.lblLensID.AutoSize = true;
            this.lblLensID.BackColor = System.Drawing.Color.Transparent;
            this.lblLensID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLensID.Location = new System.Drawing.Point(81, 648);
            this.lblLensID.Name = "lblLensID";
            this.lblLensID.Size = new System.Drawing.Size(101, 29);
            this.lblLensID.TabIndex = 104;
            this.lblLensID.Text = "Lens ID";
            this.lblLensID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLeftEyePower
            // 
            this.lblLeftEyePower.AutoSize = true;
            this.lblLeftEyePower.BackColor = System.Drawing.Color.Transparent;
            this.lblLeftEyePower.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeftEyePower.Location = new System.Drawing.Point(81, 561);
            this.lblLeftEyePower.Name = "lblLeftEyePower";
            this.lblLeftEyePower.Size = new System.Drawing.Size(189, 29);
            this.lblLeftEyePower.TabIndex = 103;
            this.lblLeftEyePower.Text = "Left Eye Power";
            this.lblLeftEyePower.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Workshop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(1799, 914);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPatientID);
            this.Controls.Add(this.txtWorkID);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFrameID);
            this.Controls.Add(this.lblFrameID);
            this.Controls.Add(this.txtRightEyePower);
            this.Controls.Add(this.lblRightEyePower);
            this.Controls.Add(this.txtLensID);
            this.Controls.Add(this.txtLeftEyePower);
            this.Controls.Add(this.lblLensID);
            this.Controls.Add(this.lblLeftEyePower);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvWorkshop);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Workshop";
            this.Text = "Workshop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Workshop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkshop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.DataGridView dgvWorkshop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.TextBox txtWorkID;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFrameID;
        private System.Windows.Forms.Label lblFrameID;
        private System.Windows.Forms.TextBox txtRightEyePower;
        private System.Windows.Forms.Label lblRightEyePower;
        private System.Windows.Forms.TextBox txtLensID;
        private System.Windows.Forms.TextBox txtLeftEyePower;
        private System.Windows.Forms.Label lblLensID;
        private System.Windows.Forms.Label lblLeftEyePower;
    }
}