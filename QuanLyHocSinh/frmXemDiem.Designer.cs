namespace QuanLyHocSinh
{
    partial class frmXemDiem
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
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.m_dgvMain = new System.Windows.Forms.DataGridView();
            this.m_cbbNamHoc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.m_cbbHocKi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.m_cbbMonHoc = new System.Windows.Forms.ComboBox();
            this.m_lbMaHS = new System.Windows.Forms.Label();
            this.m_lbTenHS = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(203, 15);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(159, 29);
            this.label15.TabIndex = 38;
            this.label15.Text = "Mã học sinh:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 29);
            this.label1.TabIndex = 39;
            this.label1.Text = "Họ và tên:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyHocSinh.Properties.Resources.Hacker;
            this.pictureBox1.Location = new System.Drawing.Point(16, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // m_dgvMain
            // 
            this.m_dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_dgvMain.Location = new System.Drawing.Point(16, 234);
            this.m_dgvMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_dgvMain.Name = "m_dgvMain";
            this.m_dgvMain.Size = new System.Drawing.Size(1140, 250);
            this.m_dgvMain.TabIndex = 42;
            this.m_dgvMain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // m_cbbNamHoc
            // 
            this.m_cbbNamHoc.FormattingEnabled = true;
            this.m_cbbNamHoc.Location = new System.Drawing.Point(605, 201);
            this.m_cbbNamHoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_cbbNamHoc.Name = "m_cbbNamHoc";
            this.m_cbbNamHoc.Size = new System.Drawing.Size(160, 24);
            this.m_cbbNamHoc.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(611, 159);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 39);
            this.label2.TabIndex = 44;
            this.label2.Text = "Năm học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(824, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 39);
            this.label3.TabIndex = 46;
            this.label3.Text = "Học kì";
            // 
            // m_cbbHocKi
            // 
            this.m_cbbHocKi.FormattingEnabled = true;
            this.m_cbbHocKi.Location = new System.Drawing.Point(799, 201);
            this.m_cbbHocKi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_cbbHocKi.Name = "m_cbbHocKi";
            this.m_cbbHocKi.Size = new System.Drawing.Size(160, 24);
            this.m_cbbHocKi.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1005, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 39);
            this.label4.TabIndex = 48;
            this.label4.Text = "Môn học";
            // 
            // m_cbbMonHoc
            // 
            this.m_cbbMonHoc.FormattingEnabled = true;
            this.m_cbbMonHoc.Location = new System.Drawing.Point(996, 201);
            this.m_cbbMonHoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_cbbMonHoc.Name = "m_cbbMonHoc";
            this.m_cbbMonHoc.Size = new System.Drawing.Size(160, 24);
            this.m_cbbMonHoc.TabIndex = 47;
            // 
            // m_lbMaHS
            // 
            this.m_lbMaHS.AutoSize = true;
            this.m_lbMaHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbMaHS.Location = new System.Drawing.Point(384, 15);
            this.m_lbMaHS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m_lbMaHS.Name = "m_lbMaHS";
            this.m_lbMaHS.Size = new System.Drawing.Size(0, 29);
            this.m_lbMaHS.TabIndex = 49;
            // 
            // m_lbTenHS
            // 
            this.m_lbTenHS.AutoSize = true;
            this.m_lbTenHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbTenHS.Location = new System.Drawing.Point(384, 58);
            this.m_lbTenHS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m_lbTenHS.Name = "m_lbTenHS";
            this.m_lbTenHS.Size = new System.Drawing.Size(0, 29);
            this.m_lbTenHS.TabIndex = 50;
            // 
            // frmXemDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1172, 498);
            this.Controls.Add(this.m_lbTenHS);
            this.Controls.Add(this.m_lbMaHS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.m_cbbMonHoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.m_cbbHocKi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.m_cbbNamHoc);
            this.Controls.Add(this.m_dgvMain);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmXemDiem";
            this.Text = "frmXemDiem";
            this.Load += new System.EventHandler(this.frmXemDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dgvMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView m_dgvMain;
        private System.Windows.Forms.ComboBox m_cbbNamHoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox m_cbbHocKi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox m_cbbMonHoc;
        private System.Windows.Forms.Label m_lbMaHS;
        private System.Windows.Forms.Label m_lbTenHS;
    }
}