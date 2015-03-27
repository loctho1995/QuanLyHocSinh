namespace QuanLyHocSinh
{
    partial class FrmMain
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Lớp 10A1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Lớp 10A2");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Lớp10A3");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Lớp10A4");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Khối 10", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Lớp 11A1");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Lớp 11A2");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Lớp 11A3");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Khối 11", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Lớp 12A1");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Lớp 12A2");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Khối 12", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Khối", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode9,
            treeNode12});
            this.m_treeViewKhoi = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.m_dgwMain = new System.Windows.Forms.DataGridView();
            this.m_btclose = new System.Windows.Forms.Button();
            this.m_dgvMain = new System.Windows.Forms.DataGridView();
            this.m_dangXuatbtn = new System.Windows.Forms.Button();
            this.m_scMain = new QuanLyHocSinh.SearchControl();
            this.m_tcMain = new QuanLyHocSinh.CustomTabControl();
            this.m_tbHoSo = new System.Windows.Forms.TabPage();
            this.m_btXemThongTin = new System.Windows.Forms.Button();
            this.m_btThemHS = new System.Windows.Forms.Button();
            this.m_btSuaHS = new System.Windows.Forms.Button();
            this.m_btXoaHS = new System.Windows.Forms.Button();
            this.m_tbHocTap = new System.Windows.Forms.TabPage();
            this.m_btXemDiem = new System.Windows.Forms.Button();
            this.m_btSuaDiem = new System.Windows.Forms.Button();
            this.m_tbBaoCao = new System.Windows.Forms.TabPage();
            this.m_tbTraCuu = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.m_dgwMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dgvMain)).BeginInit();
            this.m_tcMain.SuspendLayout();
            this.m_tbHoSo.SuspendLayout();
            this.m_tbHocTap.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_treeViewKhoi
            // 
            this.m_treeViewKhoi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.m_treeViewKhoi.BackColor = System.Drawing.Color.GhostWhite;
            this.m_treeViewKhoi.ImageIndex = 0;
            this.m_treeViewKhoi.ImageList = this.imageList1;
            this.m_treeViewKhoi.Location = new System.Drawing.Point(1, 125);
            this.m_treeViewKhoi.Name = "m_treeViewKhoi";
            treeNode1.Name = "m_node10A1";
            treeNode1.Text = "Lớp 10A1";
            treeNode2.Name = "m_node10A2";
            treeNode2.Text = "Lớp 10A2";
            treeNode3.Name = "m_node10A3";
            treeNode3.Text = "Lớp10A3";
            treeNode4.Name = "m_node10A4";
            treeNode4.Text = "Lớp10A4";
            treeNode5.ImageIndex = 2;
            treeNode5.Name = "m_nodeKhoi10";
            treeNode5.Text = "Khối 10";
            treeNode6.Name = "m_node11A1";
            treeNode6.Text = "Lớp 11A1";
            treeNode7.Name = "m_node11A2";
            treeNode7.Text = "Lớp 11A2";
            treeNode8.Name = "m_node11A3";
            treeNode8.Text = "Lớp 11A3";
            treeNode9.ImageIndex = 2;
            treeNode9.Name = "m_nodeKhoi11";
            treeNode9.Text = "Khối 11";
            treeNode10.Name = "m_node12A1";
            treeNode10.Text = "Lớp 12A1";
            treeNode11.Name = "m_node12A2";
            treeNode11.Text = "Lớp 12A2";
            treeNode12.ImageIndex = 2;
            treeNode12.Name = "m_nodeKhoi12";
            treeNode12.Text = "Khối 12";
            treeNode13.Checked = true;
            treeNode13.ImageIndex = 1;
            treeNode13.Name = "m_nodeKhoi";
            treeNode13.Text = "Khối";
            this.m_treeViewKhoi.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode13});
            this.m_treeViewKhoi.SelectedImageIndex = 0;
            this.m_treeViewKhoi.Size = new System.Drawing.Size(187, 376);
            this.m_treeViewKhoi.TabIndex = 0;
            this.m_treeViewKhoi.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.m_treeViewKhoi_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // m_dgwMain
            // 
            this.m_dgwMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_dgwMain.Location = new System.Drawing.Point(0, 0);
            this.m_dgwMain.Name = "m_dgwMain";
            this.m_dgwMain.Size = new System.Drawing.Size(715, 346);
            this.m_dgwMain.TabIndex = 0;
            // 
            // m_btclose
            // 
            this.m_btclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btclose.Location = new System.Drawing.Point(827, -1);
            this.m_btclose.Name = "m_btclose";
            this.m_btclose.Size = new System.Drawing.Size(84, 21);
            this.m_btclose.TabIndex = 3;
            this.m_btclose.Text = "Close";
            this.m_btclose.UseVisualStyleBackColor = true;
            this.m_btclose.Click += new System.EventHandler(this.button_Click);
            // 
            // m_dgvMain
            // 
            this.m_dgvMain.AllowUserToAddRows = false;
            this.m_dgvMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_dgvMain.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.m_dgvMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m_dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_dgvMain.GridColor = System.Drawing.Color.SandyBrown;
            this.m_dgvMain.Location = new System.Drawing.Point(191, 125);
            this.m_dgvMain.Name = "m_dgvMain";
            this.m_dgvMain.ReadOnly = true;
            this.m_dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.m_dgvMain.Size = new System.Drawing.Size(717, 376);
            this.m_dgvMain.TabIndex = 5;
            this.m_dgvMain.DoubleClick += new System.EventHandler(this.m_dgvMain_DoubleClick);
            // 
            // m_dangXuatbtn
            // 
            this.m_dangXuatbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_dangXuatbtn.Location = new System.Drawing.Point(724, -1);
            this.m_dangXuatbtn.Name = "m_dangXuatbtn";
            this.m_dangXuatbtn.Size = new System.Drawing.Size(84, 21);
            this.m_dangXuatbtn.TabIndex = 7;
            this.m_dangXuatbtn.Text = "Đăng Xuất";
            this.m_dangXuatbtn.UseVisualStyleBackColor = true;
            this.m_dangXuatbtn.Click += new System.EventHandler(this.m_dangXuatbtn_Click);
            // 
            // m_scMain
            // 
            this.m_scMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_scMain.BackColor = System.Drawing.Color.GhostWhite;
            this.m_scMain.DeltaSpeed = 10;
            this.m_scMain.HideSize = new System.Drawing.Size(32, 81);
            this.m_scMain.Location = new System.Drawing.Point(876, 42);
            this.m_scMain.Margin = new System.Windows.Forms.Padding(4);
            this.m_scMain.Name = "m_scMain";
            this.m_scMain.Opacity = 1F;
            this.m_scMain.ShowSize = new System.Drawing.Size(250, 81);
            this.m_scMain.Size = new System.Drawing.Size(32, 81);
            this.m_scMain.Speed = 1;
            this.m_scMain.State = QuanLyHocSinh.SearchControl.States.Hide;
            this.m_scMain.TabIndex = 6;
            this.m_scMain.Load += new System.EventHandler(this.searchControl1_Load_2);
            // 
            // m_tcMain
            // 
            this.m_tcMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_tcMain.Controls.Add(this.m_tbHoSo);
            this.m_tcMain.Controls.Add(this.m_tbHocTap);
            this.m_tcMain.Controls.Add(this.m_tbBaoCao);
            this.m_tcMain.Controls.Add(this.m_tbTraCuu);
            this.m_tcMain.Location = new System.Drawing.Point(1, 23);
            this.m_tcMain.Name = "m_tcMain";
            this.m_tcMain.SelectedIndex = 0;
            this.m_tcMain.Size = new System.Drawing.Size(875, 100);
            this.m_tcMain.TabIndex = 4;
            // 
            // m_tbHoSo
            // 
            this.m_tbHoSo.Controls.Add(this.m_btXemThongTin);
            this.m_tbHoSo.Controls.Add(this.m_btThemHS);
            this.m_tbHoSo.Controls.Add(this.m_btSuaHS);
            this.m_tbHoSo.Controls.Add(this.m_btXoaHS);
            this.m_tbHoSo.Location = new System.Drawing.Point(1, 19);
            this.m_tbHoSo.Name = "m_tbHoSo";
            this.m_tbHoSo.Padding = new System.Windows.Forms.Padding(3);
            this.m_tbHoSo.Size = new System.Drawing.Size(873, 80);
            this.m_tbHoSo.TabIndex = 0;
            this.m_tbHoSo.Text = "Hồ Sơ";
            this.m_tbHoSo.UseVisualStyleBackColor = true;
            this.m_tbHoSo.Click += new System.EventHandler(this.m_tbHoSo_Click);
            // 
            // m_btXemThongTin
            // 
            this.m_btXemThongTin.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_btXemThongTin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_btXemThongTin.Location = new System.Drawing.Point(3, 3);
            this.m_btXemThongTin.Name = "m_btXemThongTin";
            this.m_btXemThongTin.Size = new System.Drawing.Size(111, 74);
            this.m_btXemThongTin.TabIndex = 7;
            this.m_btXemThongTin.Text = "Xem Thông Tin";
            this.m_btXemThongTin.UseVisualStyleBackColor = true;
            this.m_btXemThongTin.Click += new System.EventHandler(this.button_Click);
            // 
            // m_btThemHS
            // 
            this.m_btThemHS.Location = new System.Drawing.Point(403, 6);
            this.m_btThemHS.Name = "m_btThemHS";
            this.m_btThemHS.Size = new System.Drawing.Size(111, 62);
            this.m_btThemHS.TabIndex = 6;
            this.m_btThemHS.Text = "Thêm";
            this.m_btThemHS.UseVisualStyleBackColor = true;
            this.m_btThemHS.Click += new System.EventHandler(this.button_Click);
            // 
            // m_btSuaHS
            // 
            this.m_btSuaHS.Location = new System.Drawing.Point(135, 6);
            this.m_btSuaHS.Name = "m_btSuaHS";
            this.m_btSuaHS.Size = new System.Drawing.Size(111, 62);
            this.m_btSuaHS.TabIndex = 4;
            this.m_btSuaHS.Text = "Sửa";
            this.m_btSuaHS.UseVisualStyleBackColor = true;
            this.m_btSuaHS.Click += new System.EventHandler(this.button_Click);
            // 
            // m_btXoaHS
            // 
            this.m_btXoaHS.Location = new System.Drawing.Point(266, 6);
            this.m_btXoaHS.Name = "m_btXoaHS";
            this.m_btXoaHS.Size = new System.Drawing.Size(111, 62);
            this.m_btXoaHS.TabIndex = 5;
            this.m_btXoaHS.Text = "Xóa";
            this.m_btXoaHS.UseVisualStyleBackColor = true;
            this.m_btXoaHS.Click += new System.EventHandler(this.button_Click);
            // 
            // m_tbHocTap
            // 
            this.m_tbHocTap.Controls.Add(this.m_btXemDiem);
            this.m_tbHocTap.Controls.Add(this.m_btSuaDiem);
            this.m_tbHocTap.Location = new System.Drawing.Point(1, 19);
            this.m_tbHocTap.Name = "m_tbHocTap";
            this.m_tbHocTap.Padding = new System.Windows.Forms.Padding(3);
            this.m_tbHocTap.Size = new System.Drawing.Size(873, 80);
            this.m_tbHocTap.TabIndex = 1;
            this.m_tbHocTap.Text = "Học Tập";
            this.m_tbHocTap.UseVisualStyleBackColor = true;
            // 
            // m_btXemDiem
            // 
            this.m_btXemDiem.Location = new System.Drawing.Point(6, 6);
            this.m_btXemDiem.Name = "m_btXemDiem";
            this.m_btXemDiem.Size = new System.Drawing.Size(111, 62);
            this.m_btXemDiem.TabIndex = 7;
            this.m_btXemDiem.Text = "Xem Điểm";
            this.m_btXemDiem.UseVisualStyleBackColor = true;
            this.m_btXemDiem.Click += new System.EventHandler(this.button_Click);
            // 
            // m_btSuaDiem
            // 
            this.m_btSuaDiem.Location = new System.Drawing.Point(135, 6);
            this.m_btSuaDiem.Name = "m_btSuaDiem";
            this.m_btSuaDiem.Size = new System.Drawing.Size(111, 62);
            this.m_btSuaDiem.TabIndex = 4;
            this.m_btSuaDiem.Text = "Sửa Điểm";
            this.m_btSuaDiem.UseVisualStyleBackColor = true;
            this.m_btSuaDiem.Click += new System.EventHandler(this.button_Click);
            // 
            // m_tbBaoCao
            // 
            this.m_tbBaoCao.Location = new System.Drawing.Point(1, 19);
            this.m_tbBaoCao.Name = "m_tbBaoCao";
            this.m_tbBaoCao.Size = new System.Drawing.Size(873, 80);
            this.m_tbBaoCao.TabIndex = 2;
            this.m_tbBaoCao.Text = "Báo Cáo";
            this.m_tbBaoCao.UseVisualStyleBackColor = true;
            this.m_tbBaoCao.Click += new System.EventHandler(this.button_Click);
            // 
            // m_tbTraCuu
            // 
            this.m_tbTraCuu.Location = new System.Drawing.Point(1, 19);
            this.m_tbTraCuu.Name = "m_tbTraCuu";
            this.m_tbTraCuu.Size = new System.Drawing.Size(873, 80);
            this.m_tbTraCuu.TabIndex = 3;
            this.m_tbTraCuu.Text = "Tra Cứu";
            this.m_tbTraCuu.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(910, 504);
            this.Controls.Add(this.m_scMain);
            this.Controls.Add(this.m_dangXuatbtn);
            this.Controls.Add(this.m_dgvMain);
            this.Controls.Add(this.m_tcMain);
            this.Controls.Add(this.m_btclose);
            this.Controls.Add(this.m_treeViewKhoi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Resize += new System.EventHandler(this.FrmMain_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.m_dgwMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dgvMain)).EndInit();
            this.m_tcMain.ResumeLayout(false);
            this.m_tbHoSo.ResumeLayout(false);
            this.m_tbHocTap.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView m_treeViewKhoi;
        private System.Windows.Forms.Button m_btclose;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridView m_dgwMain;
        private System.Windows.Forms.DataGridView m_dgvMain;
        private System.Windows.Forms.TabPage m_tbTraCuu;
        private System.Windows.Forms.TabPage m_tbBaoCao;
        private System.Windows.Forms.TabPage m_tbHocTap;
        private System.Windows.Forms.Button m_btXemDiem;
        private System.Windows.Forms.Button m_btSuaDiem;
        private System.Windows.Forms.TabPage m_tbHoSo;
        private System.Windows.Forms.Button m_btXemThongTin;
        private System.Windows.Forms.Button m_btThemHS;
        private System.Windows.Forms.Button m_btSuaHS;
        private System.Windows.Forms.Button m_btXoaHS;
        private CustomTabControl m_tcMain;
        private System.Windows.Forms.Button m_dangXuatbtn;
        private SearchControl m_scMain;
    }
}

