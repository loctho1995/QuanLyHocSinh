namespace QuanLyHocSinh
{
    partial class frmBaoCao
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
            this.m_btClose = new System.Windows.Forms.Button();
            this.m_lableLop = new System.Windows.Forms.Label();
            this.m_data = new System.Windows.Forms.DataGridView();
            this.m_cbbType = new System.Windows.Forms.ComboBox();
            this.m_cbbMonHoc = new System.Windows.Forms.ComboBox();
            this.m_cbbNamHoc = new System.Windows.Forms.ComboBox();
            this.m_cbbHocKi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.m_labelMonHoc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.m_data)).BeginInit();
            this.SuspendLayout();
            // 
            // m_btClose
            // 
            this.m_btClose.Location = new System.Drawing.Point(1201, 2);
            this.m_btClose.Name = "m_btClose";
            this.m_btClose.Size = new System.Drawing.Size(75, 23);
            this.m_btClose.TabIndex = 0;
            this.m_btClose.Text = "Close";
            this.m_btClose.UseVisualStyleBackColor = true;
            this.m_btClose.Click += new System.EventHandler(this.m_btClose_Click);
            // 
            // m_lableLop
            // 
            this.m_lableLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lableLop.Location = new System.Drawing.Point(189, 75);
            this.m_lableLop.Name = "m_lableLop";
            this.m_lableLop.Size = new System.Drawing.Size(358, 109);
            this.m_lableLop.TabIndex = 1;
            this.m_lableLop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_data
            // 
            this.m_data.BackgroundColor = System.Drawing.SystemColors.Info;
            this.m_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_data.Location = new System.Drawing.Point(12, 249);
            this.m_data.Name = "m_data";
            this.m_data.RowTemplate.Height = 24;
            this.m_data.Size = new System.Drawing.Size(1253, 346);
            this.m_data.TabIndex = 2;
            // 
            // m_cbbType
            // 
            this.m_cbbType.FormattingEnabled = true;
            this.m_cbbType.Location = new System.Drawing.Point(857, 46);
            this.m_cbbType.Name = "m_cbbType";
            this.m_cbbType.Size = new System.Drawing.Size(182, 24);
            this.m_cbbType.TabIndex = 3;
            this.m_cbbType.SelectedIndexChanged += new System.EventHandler(this.m_cbbType_SelectedIndexChanged);
            // 
            // m_cbbMonHoc
            // 
            this.m_cbbMonHoc.FormattingEnabled = true;
            this.m_cbbMonHoc.Location = new System.Drawing.Point(857, 198);
            this.m_cbbMonHoc.Name = "m_cbbMonHoc";
            this.m_cbbMonHoc.Size = new System.Drawing.Size(182, 24);
            this.m_cbbMonHoc.TabIndex = 4;
            this.m_cbbMonHoc.SelectedIndexChanged += new System.EventHandler(this.m_cbbMonHoc_SelectedIndexChanged);
            // 
            // m_cbbNamHoc
            // 
            this.m_cbbNamHoc.FormattingEnabled = true;
            this.m_cbbNamHoc.Location = new System.Drawing.Point(857, 147);
            this.m_cbbNamHoc.Name = "m_cbbNamHoc";
            this.m_cbbNamHoc.Size = new System.Drawing.Size(182, 24);
            this.m_cbbNamHoc.TabIndex = 5;
            this.m_cbbNamHoc.SelectedIndexChanged += new System.EventHandler(this.m_cbbNamHoc_SelectedIndexChanged);
            // 
            // m_cbbHocKi
            // 
            this.m_cbbHocKi.FormattingEnabled = true;
            this.m_cbbHocKi.Location = new System.Drawing.Point(857, 95);
            this.m_cbbHocKi.Name = "m_cbbHocKi";
            this.m_cbbHocKi.Size = new System.Drawing.Size(182, 24);
            this.m_cbbHocKi.TabIndex = 6;
            this.m_cbbHocKi.SelectedIndexChanged += new System.EventHandler(this.m_cbbHocKi_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(683, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Loại Báo Cáo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(683, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Học Kì";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(686, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Năm Học";
            // 
            // m_labelMonHoc
            // 
            this.m_labelMonHoc.AutoSize = true;
            this.m_labelMonHoc.Location = new System.Drawing.Point(686, 205);
            this.m_labelMonHoc.Name = "m_labelMonHoc";
            this.m_labelMonHoc.Size = new System.Drawing.Size(64, 17);
            this.m_labelMonHoc.TabIndex = 10;
            this.m_labelMonHoc.Text = "Môn Học";
            // 
            // frmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1277, 607);
            this.Controls.Add(this.m_labelMonHoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_cbbHocKi);
            this.Controls.Add(this.m_cbbNamHoc);
            this.Controls.Add(this.m_cbbMonHoc);
            this.Controls.Add(this.m_cbbType);
            this.Controls.Add(this.m_data);
            this.Controls.Add(this.m_lableLop);
            this.Controls.Add(this.m_btClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBaoCao";
            this.Text = "frmBaoCao";
            ((System.ComponentModel.ISupportInitialize)(this.m_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button m_btClose;
        private System.Windows.Forms.Label m_lableLop;
        private System.Windows.Forms.DataGridView m_data;
        private System.Windows.Forms.ComboBox m_cbbType;
        private System.Windows.Forms.ComboBox m_cbbMonHoc;
        private System.Windows.Forms.ComboBox m_cbbNamHoc;
        private System.Windows.Forms.ComboBox m_cbbHocKi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label m_labelMonHoc;
    }
}