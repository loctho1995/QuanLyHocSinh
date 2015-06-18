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
            this.m_btHide = new QuanLyHocSinh.ButtonFlat();
            this.m_btmaxSize = new QuanLyHocSinh.ButtonFlat();
            this.m_btclose = new QuanLyHocSinh.ButtonFlat();
            this.button2 = new QuanLyHocSinh.ButtonFlat();
            this.m_tableName = new System.Windows.Forms.Label();
            this.m_lableLop = new System.Windows.Forms.Label();
            this.m_dgvData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.m_dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // m_btHide
            // 
            this.m_btHide.AlphaGlow = 40F;
            this.m_btHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btHide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(99)))));
            this.m_btHide.ButtonImage = global::QuanLyHocSinh.Properties.Resources.iconminmize;
            this.m_btHide.ButtonText = "";
            this.m_btHide.DeltaAlphaGlow = 8F;
            this.m_btHide.DeltaDistance = 2F;
            this.m_btHide.HaveEffects = false;
            this.m_btHide.ImageOrigin = new System.Drawing.Point(0, 0);
            this.m_btHide.ImageSize = new System.Drawing.Size(20, 20);
            this.m_btHide.Location = new System.Drawing.Point(879, 1);
            this.m_btHide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_btHide.MouseState = QuanLyHocSinh.ButtonFlat.MouseStates.Leave;
            this.m_btHide.Name = "m_btHide";
            this.m_btHide.SaveChanged = false;
            this.m_btHide.ShadownDistance = 6;
            this.m_btHide.Size = new System.Drawing.Size(37, 28);
            this.m_btHide.TabIndex = 15;
            this.m_btHide.TextAlignment = QuanLyHocSinh.ButtonFlat.BTTextAlignment.Bot;
            this.m_btHide.TextColor = System.Drawing.Color.White;
            this.m_btHide.TextOrigin = new System.Drawing.Point(0, 0);
            this.m_btHide.TransparentBackColor = System.Drawing.Color.Empty;
            this.m_btHide.Type = QuanLyHocSinh.ButtonFlat.Types.FlatNormal;
            this.m_btHide.Click += new System.EventHandler(this.m_btHide_Click);
            // 
            // m_btmaxSize
            // 
            this.m_btmaxSize.AlphaGlow = 40F;
            this.m_btmaxSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btmaxSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(99)))));
            this.m_btmaxSize.ButtonImage = global::QuanLyHocSinh.Properties.Resources.iconmaxsize;
            this.m_btmaxSize.ButtonText = "";
            this.m_btmaxSize.DeltaAlphaGlow = 8F;
            this.m_btmaxSize.DeltaDistance = 2F;
            this.m_btmaxSize.HaveEffects = false;
            this.m_btmaxSize.ImageOrigin = new System.Drawing.Point(0, 0);
            this.m_btmaxSize.ImageSize = new System.Drawing.Size(25, 20);
            this.m_btmaxSize.Location = new System.Drawing.Point(921, 1);
            this.m_btmaxSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_btmaxSize.MouseState = QuanLyHocSinh.ButtonFlat.MouseStates.Leave;
            this.m_btmaxSize.Name = "m_btmaxSize";
            this.m_btmaxSize.SaveChanged = false;
            this.m_btmaxSize.ShadownDistance = 6;
            this.m_btmaxSize.Size = new System.Drawing.Size(37, 28);
            this.m_btmaxSize.TabIndex = 14;
            this.m_btmaxSize.TextAlignment = QuanLyHocSinh.ButtonFlat.BTTextAlignment.Bot;
            this.m_btmaxSize.TextColor = System.Drawing.Color.White;
            this.m_btmaxSize.TextOrigin = new System.Drawing.Point(0, 0);
            this.m_btmaxSize.TransparentBackColor = System.Drawing.Color.Empty;
            this.m_btmaxSize.Type = QuanLyHocSinh.ButtonFlat.Types.FlatNormal;
            this.m_btmaxSize.Click += new System.EventHandler(this.m_btmaxSize_Click);
            // 
            // m_btclose
            // 
            this.m_btclose.AlphaGlow = 40F;
            this.m_btclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(99)))));
            this.m_btclose.ButtonImage = global::QuanLyHocSinh.Properties.Resources.iconClose;
            this.m_btclose.ButtonText = "";
            this.m_btclose.DeltaAlphaGlow = 8F;
            this.m_btclose.DeltaDistance = 2F;
            this.m_btclose.HaveEffects = false;
            this.m_btclose.ImageOrigin = new System.Drawing.Point(0, 0);
            this.m_btclose.ImageSize = new System.Drawing.Size(30, 30);
            this.m_btclose.Location = new System.Drawing.Point(964, 1);
            this.m_btclose.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.m_btclose.MouseState = QuanLyHocSinh.ButtonFlat.MouseStates.Leave;
            this.m_btclose.Name = "m_btclose";
            this.m_btclose.SaveChanged = false;
            this.m_btclose.ShadownDistance = 6;
            this.m_btclose.Size = new System.Drawing.Size(37, 28);
            this.m_btclose.TabIndex = 13;
            this.m_btclose.TextAlignment = QuanLyHocSinh.ButtonFlat.BTTextAlignment.Bot;
            this.m_btclose.TextColor = System.Drawing.Color.White;
            this.m_btclose.TextOrigin = new System.Drawing.Point(0, 0);
            this.m_btclose.TransparentBackColor = System.Drawing.Color.Empty;
            this.m_btclose.Type = QuanLyHocSinh.ButtonFlat.Types.FlatNormal;
            this.m_btclose.Click += new System.EventHandler(this.m_btclose_Click);
            // 
            // button2
            // 
            this.button2.AlphaGlow = 40F;
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(99)))));
            this.button2.ButtonImage = null;
            this.button2.ButtonText = "In";
            this.button2.DeltaAlphaGlow = 2F;
            this.button2.DeltaDistance = 2F;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.HaveEffects = true;
            this.button2.ImageOrigin = new System.Drawing.Point(0, 0);
            this.button2.ImageSize = new System.Drawing.Size(50, 50);
            this.button2.Location = new System.Drawing.Point(875, 506);
            this.button2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button2.MouseState = QuanLyHocSinh.ButtonFlat.MouseStates.Leave;
            this.button2.Name = "button2";
            this.button2.SaveChanged = false;
            this.button2.ShadownDistance = 6;
            this.button2.Size = new System.Drawing.Size(127, 34);
            this.button2.TabIndex = 6;
            this.button2.TextAlignment = QuanLyHocSinh.ButtonFlat.BTTextAlignment.Center;
            this.button2.TextColor = System.Drawing.Color.White;
            this.button2.TextOrigin = new System.Drawing.Point(0, 0);
            this.button2.TransparentBackColor = System.Drawing.Color.Empty;
            this.button2.Type = QuanLyHocSinh.ButtonFlat.Types.FlatNormal;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // m_tableName
            // 
            this.m_tableName.BackColor = System.Drawing.Color.Transparent;
            this.m_tableName.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_tableName.ForeColor = System.Drawing.Color.White;
            this.m_tableName.Location = new System.Drawing.Point(452, 42);
            this.m_tableName.Name = "m_tableName";
            this.m_tableName.Size = new System.Drawing.Size(356, 53);
            this.m_tableName.TabIndex = 5;
            this.m_tableName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_lableLop
            // 
            this.m_lableLop.BackColor = System.Drawing.Color.Transparent;
            this.m_lableLop.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lableLop.ForeColor = System.Drawing.Color.White;
            this.m_lableLop.Location = new System.Drawing.Point(53, 42);
            this.m_lableLop.Name = "m_lableLop";
            this.m_lableLop.Size = new System.Drawing.Size(356, 53);
            this.m_lableLop.TabIndex = 1;
            this.m_lableLop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_dgvData
            // 
            this.m_dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_dgvData.BackgroundColor = System.Drawing.Color.White;
            this.m_dgvData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m_dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_dgvData.Location = new System.Drawing.Point(1, 97);
            this.m_dgvData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_dgvData.Name = "m_dgvData";
            this.m_dgvData.ReadOnly = true;
            this.m_dgvData.RowTemplate.Height = 24;
            this.m_dgvData.Size = new System.Drawing.Size(1000, 400);
            this.m_dgvData.TabIndex = 2;
            // 
            // frmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 594);
            this.Controls.Add(this.m_btHide);
            this.Controls.Add(this.m_btmaxSize);
            this.Controls.Add(this.m_btclose);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.m_tableName);
            this.Controls.Add(this.m_dgvData);
            this.Controls.Add(this.m_lableLop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmBaoCao";
            this.Text = "frmBaoCao";
            ((System.ComponentModel.ISupportInitialize)(this.m_dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label m_lableLop;
        private System.Windows.Forms.Label m_tableName;
        private ButtonFlat button2;
        private ButtonFlat m_btHide;
        private ButtonFlat m_btmaxSize;
        private ButtonFlat m_btclose;
        private System.Windows.Forms.DataGridView m_dgvData;
    }
}