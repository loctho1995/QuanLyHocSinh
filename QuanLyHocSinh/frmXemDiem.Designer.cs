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
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(152, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(130, 24);
            this.label15.TabIndex = 38;
            this.label15.Text = "Mã học sinh:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 39;
            this.label1.Text = "Họ và tên:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyHocSinh.Properties.Resources.Hacker;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // m_dgvMain
            // 
            this.m_dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_dgvMain.Location = new System.Drawing.Point(12, 205);
            this.m_dgvMain.Name = "m_dgvMain";
            this.m_dgvMain.Size = new System.Drawing.Size(657, 257);
            this.m_dgvMain.TabIndex = 42;
            this.m_dgvMain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // m_cbbNamHoc
            // 
            this.m_cbbNamHoc.FormattingEnabled = true;
            this.m_cbbNamHoc.Location = new System.Drawing.Point(254, 163);
            this.m_cbbNamHoc.Name = "m_cbbNamHoc";
            this.m_cbbNamHoc.Size = new System.Drawing.Size(121, 21);
            this.m_cbbNamHoc.TabIndex = 43;
            this.m_cbbNamHoc.SelectedIndexChanged += new System.EventHandler(this.m_cbbNamHoc_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(258, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 31);
            this.label2.TabIndex = 44;
            this.label2.Text = "Năm học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(418, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 31);
            this.label3.TabIndex = 46;
            this.label3.Text = "Học kì";
            // 
            // m_cbbHocKi
            // 
            this.m_cbbHocKi.FormattingEnabled = true;
            this.m_cbbHocKi.Location = new System.Drawing.Point(399, 163);
            this.m_cbbHocKi.Name = "m_cbbHocKi";
            this.m_cbbHocKi.Size = new System.Drawing.Size(121, 21);
            this.m_cbbHocKi.TabIndex = 45;
            this.m_cbbHocKi.SelectedIndexChanged += new System.EventHandler(this.m_cbbHocKi_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(554, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 31);
            this.label4.TabIndex = 48;
            this.label4.Text = "Môn học";
            // 
            // m_cbbMonHoc
            // 
            this.m_cbbMonHoc.FormattingEnabled = true;
            this.m_cbbMonHoc.Location = new System.Drawing.Point(547, 163);
            this.m_cbbMonHoc.Name = "m_cbbMonHoc";
            this.m_cbbMonHoc.Size = new System.Drawing.Size(121, 21);
            this.m_cbbMonHoc.TabIndex = 47;
            // 
            // m_lbMaHS
            // 
            this.m_lbMaHS.AutoSize = true;
            this.m_lbMaHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbMaHS.Location = new System.Drawing.Point(288, 12);
            this.m_lbMaHS.Name = "m_lbMaHS";
            this.m_lbMaHS.Size = new System.Drawing.Size(0, 24);
            this.m_lbMaHS.TabIndex = 49;
            // 
            // m_lbTenHS
            // 
            this.m_lbTenHS.AutoSize = true;
            this.m_lbTenHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbTenHS.Location = new System.Drawing.Point(288, 47);
            this.m_lbTenHS.Name = "m_lbTenHS";
            this.m_lbTenHS.Size = new System.Drawing.Size(0, 24);
            this.m_lbTenHS.TabIndex = 50;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(607, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 51;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmXemDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(683, 474);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
    }
}