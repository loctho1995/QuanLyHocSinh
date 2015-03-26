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
            this.btnClose = new System.Windows.Forms.Button();
            this.m_IDLable = new System.Windows.Forms.Label();
            this.m_passwordLable = new System.Windows.Forms.Label();
            this.m_IDTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.m_dangNhapBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(1135, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseMnemonic = false;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // m_IDLable
            // 
            this.m_IDLable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_IDLable.AutoSize = true;
            this.m_IDLable.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_IDLable.ForeColor = System.Drawing.Color.Black;
            this.m_IDLable.Location = new System.Drawing.Point(466, 283);
            this.m_IDLable.Name = "m_IDLable";
            this.m_IDLable.Size = new System.Drawing.Size(61, 43);
            this.m_IDLable.TabIndex = 1;
            this.m_IDLable.Text = "ID";
            // 
            // m_passwordLable
            // 
            this.m_passwordLable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_passwordLable.AutoSize = true;
            this.m_passwordLable.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_passwordLable.ForeColor = System.Drawing.Color.Black;
            this.m_passwordLable.Location = new System.Drawing.Point(395, 354);
            this.m_passwordLable.Name = "m_passwordLable";
            this.m_passwordLable.Size = new System.Drawing.Size(231, 43);
            this.m_passwordLable.TabIndex = 2;
            this.m_passwordLable.Text = "PASSWORD";
            // 
            // m_IDTextBox
            // 
            this.m_IDTextBox.Location = new System.Drawing.Point(735, 301);
            this.m_IDTextBox.Name = "m_IDTextBox";
            this.m_IDTextBox.Size = new System.Drawing.Size(256, 22);
            this.m_IDTextBox.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(735, 372);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(256, 22);
            this.textBox1.TabIndex = 4;
            // 
            // m_dangNhapBtn
            // 
            this.m_dangNhapBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.m_dangNhapBtn.Location = new System.Drawing.Point(875, 446);
            this.m_dangNhapBtn.Name = "m_dangNhapBtn";
            this.m_dangNhapBtn.Size = new System.Drawing.Size(116, 31);
            this.m_dangNhapBtn.TabIndex = 5;
            this.m_dangNhapBtn.Text = "Login";
            this.m_dangNhapBtn.UseVisualStyleBackColor = true;
            this.m_dangNhapBtn.Click += new System.EventHandler(this.m_dangNhapBtn_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.Location = new System.Drawing.Point(875, 506);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 31);
            this.button2.TabIndex = 7;
            this.button2.Text = "FrmMain";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(668, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 90);
            this.label1.TabIndex = 8;
            this.label1.Text = "Đăng Nhập";
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1213, 620);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.m_dangNhapBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.m_IDTextBox);
            this.Controls.Add(this.m_passwordLable);
            this.Controls.Add(this.m_IDLable);
            this.Controls.Add(this.btnClose);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDangNhap";
            this.Opacity = 0.99D;
            this.Text = "frmDangNhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label m_IDLable;
        private System.Windows.Forms.Label m_passwordLable;
        private System.Windows.Forms.TextBox m_IDTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button m_dangNhapBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}