namespace QuanLyHocSinh
{
    partial class frmGiaoVien
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
            this.m_dgvGV = new System.Windows.Forms.DataGridView();
            this.m_btnThem = new System.Windows.Forms.Button();
            this.m_btnSua = new System.Windows.Forms.Button();
            this.m_btnXoa = new System.Windows.Forms.Button();
            this.m_btnLuu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.m_txtMaGV = new System.Windows.Forms.TextBox();
            this.m_txtHoten = new System.Windows.Forms.TextBox();
            this.m_txtSoDT = new System.Windows.Forms.TextBox();
            this.m_dtpNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.m_cbbPhanquyen = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.m_txtPass = new System.Windows.Forms.TextBox();
            this.m_txtDangnhap = new System.Windows.Forms.TextBox();
            this.m_btnTaoTK = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.m_txtEmail = new System.Windows.Forms.TextBox();
            this.m_cbbGioitinh = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.m_dgvGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_dgvGV
            // 
            this.m_dgvGV.AllowUserToAddRows = false;
            this.m_dgvGV.AllowUserToDeleteRows = false;
            this.m_dgvGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_dgvGV.Location = new System.Drawing.Point(2, 238);
            this.m_dgvGV.Name = "m_dgvGV";
            this.m_dgvGV.ReadOnly = true;
            this.m_dgvGV.RowTemplate.Height = 24;
            this.m_dgvGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.m_dgvGV.Size = new System.Drawing.Size(978, 284);
            this.m_dgvGV.TabIndex = 0;
            this.m_dgvGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.m_dgvGV_CellContentClick);
            // 
            // m_btnThem
            // 
            this.m_btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_btnThem.Location = new System.Drawing.Point(12, 147);
            this.m_btnThem.Name = "m_btnThem";
            this.m_btnThem.Size = new System.Drawing.Size(128, 48);
            this.m_btnThem.TabIndex = 1;
            this.m_btnThem.Text = "Thêm";
            this.m_btnThem.UseVisualStyleBackColor = true;
            this.m_btnThem.Click += new System.EventHandler(this.m_btnThem_Click);
            // 
            // m_btnSua
            // 
            this.m_btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_btnSua.Location = new System.Drawing.Point(479, 147);
            this.m_btnSua.Name = "m_btnSua";
            this.m_btnSua.Size = new System.Drawing.Size(128, 48);
            this.m_btnSua.TabIndex = 1;
            this.m_btnSua.Text = "Sửa";
            this.m_btnSua.UseVisualStyleBackColor = true;
            this.m_btnSua.Click += new System.EventHandler(this.m_btnSua_Click);
            // 
            // m_btnXoa
            // 
            this.m_btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_btnXoa.Location = new System.Drawing.Point(325, 147);
            this.m_btnXoa.Name = "m_btnXoa";
            this.m_btnXoa.Size = new System.Drawing.Size(128, 48);
            this.m_btnXoa.TabIndex = 1;
            this.m_btnXoa.Text = "Xóa";
            this.m_btnXoa.UseVisualStyleBackColor = true;
            this.m_btnXoa.Click += new System.EventHandler(this.m_btnXoa_Click);
            // 
            // m_btnLuu
            // 
            this.m_btnLuu.Enabled = false;
            this.m_btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_btnLuu.Location = new System.Drawing.Point(170, 147);
            this.m_btnLuu.Name = "m_btnLuu";
            this.m_btnLuu.Size = new System.Drawing.Size(128, 48);
            this.m_btnLuu.TabIndex = 1;
            this.m_btnLuu.Text = "Lưu";
            this.m_btnLuu.UseVisualStyleBackColor = true;
            this.m_btnLuu.Click += new System.EventHandler(this.m_btnLuu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã GV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giới tính:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(341, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số điện thoại:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(368, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ngày sinh:";
            // 
            // m_txtMaGV
            // 
            this.m_txtMaGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_txtMaGV.Location = new System.Drawing.Point(118, 15);
            this.m_txtMaGV.Name = "m_txtMaGV";
            this.m_txtMaGV.Size = new System.Drawing.Size(221, 30);
            this.m_txtMaGV.TabIndex = 3;
            this.m_txtMaGV.TextChanged += new System.EventHandler(this.m_txtMaGV_TextChanged);
            // 
            // m_txtHoten
            // 
            this.m_txtHoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_txtHoten.Location = new System.Drawing.Point(116, 56);
            this.m_txtHoten.Name = "m_txtHoten";
            this.m_txtHoten.Size = new System.Drawing.Size(223, 30);
            this.m_txtHoten.TabIndex = 3;
            // 
            // m_txtSoDT
            // 
            this.m_txtSoDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_txtSoDT.Location = new System.Drawing.Point(476, 60);
            this.m_txtSoDT.Name = "m_txtSoDT";
            this.m_txtSoDT.Size = new System.Drawing.Size(184, 30);
            this.m_txtSoDT.TabIndex = 3;
            // 
            // m_dtpNgaysinh
            // 
            this.m_dtpNgaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_dtpNgaysinh.Location = new System.Drawing.Point(476, 17);
            this.m_dtpNgaysinh.Name = "m_dtpNgaysinh";
            this.m_dtpNgaysinh.Size = new System.Drawing.Size(184, 30);
            this.m_dtpNgaysinh.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.m_cbbPhanquyen);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.m_txtPass);
            this.groupBox1.Controls.Add(this.m_txtDangnhap);
            this.groupBox1.Controls.Add(this.m_btnTaoTK);
            this.groupBox1.Location = new System.Drawing.Point(667, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 217);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tạo tài khoản đăng nhập";
            // 
            // m_cbbPhanquyen
            // 
            this.m_cbbPhanquyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_cbbPhanquyen.FormattingEnabled = true;
            this.m_cbbPhanquyen.Items.AddRange(new object[] {
            "0",
            "1"});
            this.m_cbbPhanquyen.Location = new System.Drawing.Point(118, 132);
            this.m_cbbPhanquyen.Name = "m_cbbPhanquyen";
            this.m_cbbPhanquyen.Size = new System.Drawing.Size(184, 33);
            this.m_cbbPhanquyen.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(-2, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Phân quyền:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Mật khẩu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Đăng nhập:";
            // 
            // m_txtPass
            // 
            this.m_txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_txtPass.Location = new System.Drawing.Point(118, 90);
            this.m_txtPass.Name = "m_txtPass";
            this.m_txtPass.Size = new System.Drawing.Size(184, 30);
            this.m_txtPass.TabIndex = 3;
            // 
            // m_txtDangnhap
            // 
            this.m_txtDangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_txtDangnhap.Location = new System.Drawing.Point(118, 39);
            this.m_txtDangnhap.Name = "m_txtDangnhap";
            this.m_txtDangnhap.Size = new System.Drawing.Size(184, 30);
            this.m_txtDangnhap.TabIndex = 3;
            // 
            // m_btnTaoTK
            // 
            this.m_btnTaoTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_btnTaoTK.Location = new System.Drawing.Point(167, 180);
            this.m_btnTaoTK.Name = "m_btnTaoTK";
            this.m_btnTaoTK.Size = new System.Drawing.Size(121, 31);
            this.m_btnTaoTK.TabIndex = 1;
            this.m_btnTaoTK.Text = "Tạo TK";
            this.m_btnTaoTK.UseVisualStyleBackColor = true;
            this.m_btnTaoTK.Click += new System.EventHandler(this.m_btnTaoTK_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(403, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "Email:";
            // 
            // m_txtEmail
            // 
            this.m_txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_txtEmail.Location = new System.Drawing.Point(476, 104);
            this.m_txtEmail.Name = "m_txtEmail";
            this.m_txtEmail.Size = new System.Drawing.Size(184, 30);
            this.m_txtEmail.TabIndex = 3;
            // 
            // m_cbbGioitinh
            // 
            this.m_cbbGioitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_cbbGioitinh.FormattingEnabled = true;
            this.m_cbbGioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nu"});
            this.m_cbbGioitinh.Location = new System.Drawing.Point(116, 102);
            this.m_cbbGioitinh.Name = "m_cbbGioitinh";
            this.m_cbbGioitinh.Size = new System.Drawing.Size(223, 33);
            this.m_cbbGioitinh.TabIndex = 4;
            // 
            // frmGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 522);
            this.Controls.Add(this.m_cbbGioitinh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.m_dtpNgaysinh);
            this.Controls.Add(this.m_txtHoten);
            this.Controls.Add(this.m_txtEmail);
            this.Controls.Add(this.m_txtSoDT);
            this.Controls.Add(this.m_txtMaGV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_btnXoa);
            this.Controls.Add(this.m_btnLuu);
            this.Controls.Add(this.m_btnSua);
            this.Controls.Add(this.m_btnThem);
            this.Controls.Add(this.m_dgvGV);
            this.MaximizeBox = false;
            this.Name = "frmGiaoVien";
            this.Text = "Quản lý Giáo Viên";
            this.Load += new System.EventHandler(this.frmGiaoVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_dgvGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView m_dgvGV;
        private System.Windows.Forms.Button m_btnThem;
        private System.Windows.Forms.Button m_btnSua;
        private System.Windows.Forms.Button m_btnXoa;
        private System.Windows.Forms.Button m_btnLuu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox m_txtMaGV;
        private System.Windows.Forms.TextBox m_txtHoten;
        private System.Windows.Forms.TextBox m_txtSoDT;
        private System.Windows.Forms.DateTimePicker m_dtpNgaysinh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox m_txtPass;
        private System.Windows.Forms.TextBox m_txtDangnhap;
        private System.Windows.Forms.Button m_btnTaoTK;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox m_txtEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox m_cbbPhanquyen;
        private System.Windows.Forms.ComboBox m_cbbGioitinh;
    }
}