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
            this.m_lableLop = new System.Windows.Forms.Label();
            this.m_dgvData = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.m_dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // m_lableLop
            // 
            this.m_lableLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lableLop.Location = new System.Drawing.Point(53, -3);
            this.m_lableLop.Name = "m_lableLop";
            this.m_lableLop.Size = new System.Drawing.Size(356, 97);
            this.m_lableLop.TabIndex = 1;
            this.m_lableLop.Text = "BÁO CÁO";
            this.m_lableLop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_dgvData
            // 
            this.m_dgvData.BackgroundColor = System.Drawing.SystemColors.Info;
            this.m_dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_dgvData.Location = new System.Drawing.Point(12, 97);
            this.m_dgvData.Name = "m_dgvData";
            this.m_dgvData.RowTemplate.Height = 24;
            this.m_dgvData.Size = new System.Drawing.Size(925, 623);
            this.m_dgvData.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(864, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Tắt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(864, 726);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "In";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(958, 761);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.m_dgvData);
            this.Controls.Add(this.m_lableLop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBaoCao";
            this.Text = "frmBaoCao";
            ((System.ComponentModel.ISupportInitialize)(this.m_dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label m_lableLop;
        private System.Windows.Forms.DataGridView m_dgvData;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}