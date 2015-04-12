namespace QuanLyHocSinh
{
    partial class frmDangNhap
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
            this.m_IDLable = new System.Windows.Forms.Label();
            this.m_passwordLable = new System.Windows.Forms.Label();
            this.m_tbID = new System.Windows.Forms.TextBox();
            this.m_tbPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFlat1 = new QuanLyHocSinh.ButtonFlat();
            this.m_dangNhapBtn = new QuanLyHocSinh.ButtonFlat();
            this.SuspendLayout();
            // 
            // m_IDLable
            // 
            this.m_IDLable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_IDLable.AutoSize = true;
            this.m_IDLable.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_IDLable.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.m_IDLable.Location = new System.Drawing.Point(16, 85);
            this.m_IDLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_IDLable.Name = "m_IDLable";
            this.m_IDLable.Size = new System.Drawing.Size(215, 35);
            this.m_IDLable.TabIndex = 1;
            this.m_IDLable.Text = "Tên đăng nhập:";
            // 
            // m_passwordLable
            // 
            this.m_passwordLable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_passwordLable.AutoSize = true;
            this.m_passwordLable.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_passwordLable.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.m_passwordLable.Location = new System.Drawing.Point(80, 143);
            this.m_passwordLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_passwordLable.Name = "m_passwordLable";
            this.m_passwordLable.Size = new System.Drawing.Size(146, 35);
            this.m_passwordLable.TabIndex = 2;
            this.m_passwordLable.Text = "Mật khẩu:";
            // 
            // m_tbID
            // 
            this.m_tbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_tbID.Location = new System.Drawing.Point(277, 90);
            this.m_tbID.Margin = new System.Windows.Forms.Padding(2);
            this.m_tbID.Multiline = true;
            this.m_tbID.Name = "m_tbID";
            this.m_tbID.Size = new System.Drawing.Size(193, 33);
            this.m_tbID.TabIndex = 3;
            // 
            // m_tbPass
            // 
            this.m_tbPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.m_tbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_tbPass.Location = new System.Drawing.Point(277, 139);
            this.m_tbPass.Margin = new System.Windows.Forms.Padding(2);
            this.m_tbPass.Multiline = true;
            this.m_tbPass.Name = "m_tbPass";
            this.m_tbPass.PasswordChar = '*';
            this.m_tbPass.Size = new System.Drawing.Size(193, 33);
            this.m_tbPass.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 62);
            this.label1.TabIndex = 8;
            this.label1.Text = "Đăng Nhập";
            // 
            // buttonFlat1
            // 
            this.buttonFlat1.AlphaGlow = 40F;
            this.buttonFlat1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(99)))));
            this.buttonFlat1.ButtonImage = global::QuanLyHocSinh.Properties.Resources.iconClose;
            this.buttonFlat1.ButtonText = "";
            this.buttonFlat1.DeltaAlphaGlow = 2F;
            this.buttonFlat1.DeltaDistance = 2F;
            this.buttonFlat1.HaveEffects = true;
            this.buttonFlat1.ImageOrigin = new System.Drawing.Point(0, 0);
            this.buttonFlat1.ImageSize = new System.Drawing.Size(30, 30);
            this.buttonFlat1.Location = new System.Drawing.Point(438, 2);
            this.buttonFlat1.MouseState = QuanLyHocSinh.ButtonFlat.MouseStates.Leave;
            this.buttonFlat1.Name = "buttonFlat1";
            this.buttonFlat1.SaveChanged = false;
            this.buttonFlat1.ShadownDistance = 6;
            this.buttonFlat1.Size = new System.Drawing.Size(43, 31);
            this.buttonFlat1.TabIndex = 9;
            this.buttonFlat1.TextAlignment = QuanLyHocSinh.ButtonFlat.BTTextAlignment.Bot;
            this.buttonFlat1.TextColor = System.Drawing.Color.White;
            this.buttonFlat1.TextOrigin = new System.Drawing.Point(0, 0);
            this.buttonFlat1.Click += new System.EventHandler(this.buttonFlat1_Click);
            // 
            // m_dangNhapBtn
            // 
            this.m_dangNhapBtn.AlphaGlow = 40F;
            this.m_dangNhapBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(208)))), ((int)(((byte)(136)))));
            this.m_dangNhapBtn.ButtonImage = null;
            this.m_dangNhapBtn.ButtonText = "Đăng nhập";
            this.m_dangNhapBtn.DeltaAlphaGlow = 2F;
            this.m_dangNhapBtn.DeltaDistance = 2F;
            this.m_dangNhapBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_dangNhapBtn.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.m_dangNhapBtn.HaveEffects = true;
            this.m_dangNhapBtn.ImageOrigin = new System.Drawing.Point(0, 0);
            this.m_dangNhapBtn.ImageSize = new System.Drawing.Size(50, 50);
            this.m_dangNhapBtn.Location = new System.Drawing.Point(339, 179);
            this.m_dangNhapBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_dangNhapBtn.MouseState = QuanLyHocSinh.ButtonFlat.MouseStates.Leave;
            this.m_dangNhapBtn.Name = "m_dangNhapBtn";
            this.m_dangNhapBtn.SaveChanged = false;
            this.m_dangNhapBtn.ShadownDistance = 6;
            this.m_dangNhapBtn.Size = new System.Drawing.Size(131, 40);
            this.m_dangNhapBtn.TabIndex = 10;
            this.m_dangNhapBtn.TextAlignment = QuanLyHocSinh.ButtonFlat.BTTextAlignment.Center;
            this.m_dangNhapBtn.TextColor = System.Drawing.Color.White;
            this.m_dangNhapBtn.TextOrigin = new System.Drawing.Point(0, 0);
            this.m_dangNhapBtn.Click += new System.EventHandler(this.m_dangNhapBtn_Click);
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(483, 227);
            this.Controls.Add(this.m_dangNhapBtn);
            this.Controls.Add(this.buttonFlat1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_tbPass);
            this.Controls.Add(this.m_tbID);
            this.Controls.Add(this.m_passwordLable);
            this.Controls.Add(this.m_IDLable);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDangNhap";
            this.Opacity = 0.99D;
            this.Text = "frmDangNhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label m_IDLable;
        private System.Windows.Forms.Label m_passwordLable;
        private System.Windows.Forms.TextBox m_tbID;
        private System.Windows.Forms.TextBox m_tbPass;
        private System.Windows.Forms.Label label1;
        private ButtonFlat buttonFlat1;
        private ButtonFlat m_dangNhapBtn;
    }
}