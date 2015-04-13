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
            this.m_dgvMain = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.m_lblID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.m_lblName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.m_lblLopCN = new System.Windows.Forms.Label();
            this.m_lblLopBoMon = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.m_scMain = new QuanLyHocSinh.SearchControl();
            this.m_tcMain = new QuanLyHocSinh.CustomTabControl();
            this.m_tbHoSo = new System.Windows.Forms.TabPage();
            this.m_btThemHS = new QuanLyHocSinh.ButtonFlat();
            this.m_btXoaHS = new QuanLyHocSinh.ButtonFlat();
            this.m_btSuaHS = new QuanLyHocSinh.ButtonFlat();
            this.m_btXemThongTin = new QuanLyHocSinh.ButtonFlat();
            this.m_tbHocTap = new System.Windows.Forms.TabPage();
            this.m_cbbNamHoc = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.m_cbbBoMon = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.m_ccbPhanQuyen = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.m_btXemDiem = new QuanLyHocSinh.ButtonFlat();
            this.m_btSuaDiem = new QuanLyHocSinh.ButtonFlat();
            this.m_tbBaoCao = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.m_cbbBaoCaonamhoc = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.m_cbbBaoCaoLoai = new System.Windows.Forms.ComboBox();
            this.m_cbbBaoCaohocky = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.m_cbbBaoCaomonhoc = new System.Windows.Forms.ComboBox();
            this.m_btBaoCao = new QuanLyHocSinh.ButtonFlat();
            this.m_btCaiDat = new QuanLyHocSinh.ButtonFlat();
            this.m_btHide = new QuanLyHocSinh.ButtonFlat();
            this.m_btmaxSize = new QuanLyHocSinh.ButtonFlat();
            this.m_btdangXuat = new QuanLyHocSinh.ButtonFlat();
            this.m_btclose = new QuanLyHocSinh.ButtonFlat();
            ((System.ComponentModel.ISupportInitialize)(this.m_dgwMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dgvMain)).BeginInit();
            this.m_tcMain.SuspendLayout();
            this.m_tbHoSo.SuspendLayout();
            this.m_tbHocTap.SuspendLayout();
            this.m_tbBaoCao.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_treeViewKhoi
            // 
            this.m_treeViewKhoi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.m_treeViewKhoi.BackColor = System.Drawing.Color.GhostWhite;
            this.m_treeViewKhoi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m_treeViewKhoi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_treeViewKhoi.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.m_treeViewKhoi.ImageIndex = 0;
            this.m_treeViewKhoi.ImageList = this.imageList1;
            this.m_treeViewKhoi.Location = new System.Drawing.Point(2, 124);
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
            this.m_treeViewKhoi.Size = new System.Drawing.Size(187, 374);
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
            this.m_dgvMain.Location = new System.Drawing.Point(191, 124);
            this.m_dgvMain.Name = "m_dgvMain";
            this.m_dgvMain.ReadOnly = true;
            this.m_dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.m_dgvMain.Size = new System.Drawing.Size(717, 374);
            this.m_dgvMain.TabIndex = 5;
            this.m_dgvMain.DoubleClick += new System.EventHandler(this.m_dgvMain_DoubleClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(9, 505);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID:";
            // 
            // m_lblID
            // 
            this.m_lblID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_lblID.AutoSize = true;
            this.m_lblID.ForeColor = System.Drawing.Color.Snow;
            this.m_lblID.Location = new System.Drawing.Point(32, 505);
            this.m_lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_lblID.Name = "m_lblID";
            this.m_lblID.Size = new System.Drawing.Size(0, 13);
            this.m_lblID.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(95, 505);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Họ tên:";
            // 
            // m_lblName
            // 
            this.m_lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_lblName.AutoSize = true;
            this.m_lblName.ForeColor = System.Drawing.Color.Snow;
            this.m_lblName.Location = new System.Drawing.Point(138, 505);
            this.m_lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_lblName.Name = "m_lblName";
            this.m_lblName.Size = new System.Drawing.Size(0, 13);
            this.m_lblName.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(276, 505);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Lớp CN:";
            // 
            // m_lblLopCN
            // 
            this.m_lblLopCN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_lblLopCN.AutoSize = true;
            this.m_lblLopCN.ForeColor = System.Drawing.Color.Snow;
            this.m_lblLopCN.Location = new System.Drawing.Point(325, 505);
            this.m_lblLopCN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_lblLopCN.Name = "m_lblLopCN";
            this.m_lblLopCN.Size = new System.Drawing.Size(21, 13);
            this.m_lblLopCN.TabIndex = 8;
            this.m_lblLopCN.Text = "lớp";
            // 
            // m_lblLopBoMon
            // 
            this.m_lblLopBoMon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_lblLopBoMon.AutoSize = true;
            this.m_lblLopBoMon.ForeColor = System.Drawing.Color.Snow;
            this.m_lblLopBoMon.Location = new System.Drawing.Point(425, 505);
            this.m_lblLopBoMon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_lblLopBoMon.Name = "m_lblLopBoMon";
            this.m_lblLopBoMon.Size = new System.Drawing.Size(0, 13);
            this.m_lblLopBoMon.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(381, 505);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Lớp BM:";
            // 
            // m_scMain
            // 
            this.m_scMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_scMain.BackColor = System.Drawing.Color.GhostWhite;
            this.m_scMain.DeltaSpeed = 20;
            this.m_scMain.HideSize = new System.Drawing.Size(35, 80);
            this.m_scMain.Location = new System.Drawing.Point(873, 43);
            this.m_scMain.Margin = new System.Windows.Forms.Padding(4);
            this.m_scMain.Name = "m_scMain";
            this.m_scMain.Opacity = 1F;
            this.m_scMain.ShadowColor = System.Drawing.Color.Empty;
            this.m_scMain.ShowSize = new System.Drawing.Size(250, 80);
            this.m_scMain.Size = new System.Drawing.Size(35, 80);
            this.m_scMain.Speed = 1;
            this.m_scMain.State = QuanLyHocSinh.SearchControl.States.Hide;
            this.m_scMain.TabIndex = 6;
            // 
            // m_tcMain
            // 
            this.m_tcMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_tcMain.Controls.Add(this.m_tbHoSo);
            this.m_tcMain.Controls.Add(this.m_tbHocTap);
            this.m_tcMain.Controls.Add(this.m_tbBaoCao);
            this.m_tcMain.Location = new System.Drawing.Point(2, 23);
            this.m_tcMain.Name = "m_tcMain";
            this.m_tcMain.SelectedIndex = 0;
            this.m_tcMain.Size = new System.Drawing.Size(875, 99);
            this.m_tcMain.TabIndex = 4;
            this.m_tcMain.SelectedIndexChanged += new System.EventHandler(this.m_tcMain_SelectedIndexChanged_1);
            // 
            // m_tbHoSo
            // 
            this.m_tbHoSo.Controls.Add(this.m_btThemHS);
            this.m_tbHoSo.Controls.Add(this.m_btXoaHS);
            this.m_tbHoSo.Controls.Add(this.m_btSuaHS);
            this.m_tbHoSo.Controls.Add(this.m_btXemThongTin);
            this.m_tbHoSo.Location = new System.Drawing.Point(1, 20);
            this.m_tbHoSo.Name = "m_tbHoSo";
            this.m_tbHoSo.Padding = new System.Windows.Forms.Padding(3);
            this.m_tbHoSo.Size = new System.Drawing.Size(873, 79);
            this.m_tbHoSo.TabIndex = 0;
            this.m_tbHoSo.Text = "Hồ Sơ";
            this.m_tbHoSo.UseVisualStyleBackColor = true;
            // 
            // m_btThemHS
            // 
            this.m_btThemHS.AlphaGlow = 40F;
            this.m_btThemHS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(208)))), ((int)(((byte)(136)))));
            this.m_btThemHS.ButtonImage = global::QuanLyHocSinh.Properties.Resources.themhs;
            this.m_btThemHS.ButtonText = "Thêm học sinh";
            this.m_btThemHS.DeltaAlphaGlow = 8F;
            this.m_btThemHS.DeltaDistance = 2F;
            this.m_btThemHS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_btThemHS.HaveEffects = true;
            this.m_btThemHS.ImageOrigin = new System.Drawing.Point(0, -8);
            this.m_btThemHS.ImageSize = new System.Drawing.Size(40, 40);
            this.m_btThemHS.Location = new System.Drawing.Point(499, 6);
            this.m_btThemHS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_btThemHS.MouseState = QuanLyHocSinh.ButtonFlat.MouseStates.Leave;
            this.m_btThemHS.Name = "m_btThemHS";
            this.m_btThemHS.SaveChanged = false;
            this.m_btThemHS.ShadownDistance = 6;
            this.m_btThemHS.Size = new System.Drawing.Size(130, 62);
            this.m_btThemHS.TabIndex = 15;
            this.m_btThemHS.TextAlignment = QuanLyHocSinh.ButtonFlat.BTTextAlignment.Bot;
            this.m_btThemHS.TextColor = System.Drawing.Color.White;
            this.m_btThemHS.TextOrigin = new System.Drawing.Point(0, 0);
            this.m_btThemHS.Click += new System.EventHandler(this.button_Click);
            // 
            // m_btXoaHS
            // 
            this.m_btXoaHS.AlphaGlow = 40F;
            this.m_btXoaHS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(208)))), ((int)(((byte)(136)))));
            this.m_btXoaHS.ButtonImage = global::QuanLyHocSinh.Properties.Resources.xoa;
            this.m_btXoaHS.ButtonText = "Xóa học sinh";
            this.m_btXoaHS.DeltaAlphaGlow = 8F;
            this.m_btXoaHS.DeltaDistance = 2F;
            this.m_btXoaHS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_btXoaHS.HaveEffects = true;
            this.m_btXoaHS.ImageOrigin = new System.Drawing.Point(0, -8);
            this.m_btXoaHS.ImageSize = new System.Drawing.Size(40, 40);
            this.m_btXoaHS.Location = new System.Drawing.Point(333, 6);
            this.m_btXoaHS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_btXoaHS.MouseState = QuanLyHocSinh.ButtonFlat.MouseStates.Leave;
            this.m_btXoaHS.Name = "m_btXoaHS";
            this.m_btXoaHS.SaveChanged = false;
            this.m_btXoaHS.ShadownDistance = 6;
            this.m_btXoaHS.Size = new System.Drawing.Size(130, 62);
            this.m_btXoaHS.TabIndex = 14;
            this.m_btXoaHS.TextAlignment = QuanLyHocSinh.ButtonFlat.BTTextAlignment.Bot;
            this.m_btXoaHS.TextColor = System.Drawing.Color.White;
            this.m_btXoaHS.TextOrigin = new System.Drawing.Point(0, 0);
            this.m_btXoaHS.Click += new System.EventHandler(this.button_Click);
            // 
            // m_btSuaHS
            // 
            this.m_btSuaHS.AlphaGlow = 40F;
            this.m_btSuaHS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(208)))), ((int)(((byte)(136)))));
            this.m_btSuaHS.ButtonImage = global::QuanLyHocSinh.Properties.Resources.chinhsua;
            this.m_btSuaHS.ButtonText = "Chỉnh sửa";
            this.m_btSuaHS.DeltaAlphaGlow = 8F;
            this.m_btSuaHS.DeltaDistance = 2F;
            this.m_btSuaHS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_btSuaHS.HaveEffects = true;
            this.m_btSuaHS.ImageOrigin = new System.Drawing.Point(0, -8);
            this.m_btSuaHS.ImageSize = new System.Drawing.Size(40, 40);
            this.m_btSuaHS.Location = new System.Drawing.Point(169, 6);
            this.m_btSuaHS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_btSuaHS.MouseState = QuanLyHocSinh.ButtonFlat.MouseStates.Leave;
            this.m_btSuaHS.Name = "m_btSuaHS";
            this.m_btSuaHS.SaveChanged = false;
            this.m_btSuaHS.ShadownDistance = 6;
            this.m_btSuaHS.Size = new System.Drawing.Size(130, 62);
            this.m_btSuaHS.TabIndex = 13;
            this.m_btSuaHS.TextAlignment = QuanLyHocSinh.ButtonFlat.BTTextAlignment.Bot;
            this.m_btSuaHS.TextColor = System.Drawing.Color.White;
            this.m_btSuaHS.TextOrigin = new System.Drawing.Point(0, 0);
            this.m_btSuaHS.Click += new System.EventHandler(this.button_Click);
            // 
            // m_btXemThongTin
            // 
            this.m_btXemThongTin.AlphaGlow = 40F;
            this.m_btXemThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(208)))), ((int)(((byte)(136)))));
            this.m_btXemThongTin.ButtonImage = global::QuanLyHocSinh.Properties.Resources.info;
            this.m_btXemThongTin.ButtonText = "Xem thông tin";
            this.m_btXemThongTin.DeltaAlphaGlow = 8F;
            this.m_btXemThongTin.DeltaDistance = 2F;
            this.m_btXemThongTin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_btXemThongTin.HaveEffects = true;
            this.m_btXemThongTin.ImageOrigin = new System.Drawing.Point(0, -8);
            this.m_btXemThongTin.ImageSize = new System.Drawing.Size(40, 40);
            this.m_btXemThongTin.Location = new System.Drawing.Point(7, 6);
            this.m_btXemThongTin.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.m_btXemThongTin.MouseState = QuanLyHocSinh.ButtonFlat.MouseStates.Leave;
            this.m_btXemThongTin.Name = "m_btXemThongTin";
            this.m_btXemThongTin.SaveChanged = false;
            this.m_btXemThongTin.ShadownDistance = 6;
            this.m_btXemThongTin.Size = new System.Drawing.Size(130, 62);
            this.m_btXemThongTin.TabIndex = 12;
            this.m_btXemThongTin.TextAlignment = QuanLyHocSinh.ButtonFlat.BTTextAlignment.Bot;
            this.m_btXemThongTin.TextColor = System.Drawing.Color.White;
            this.m_btXemThongTin.TextOrigin = new System.Drawing.Point(0, 0);
            this.m_btXemThongTin.Click += new System.EventHandler(this.button_Click);
            // 
            // m_tbHocTap
            // 
            this.m_tbHocTap.Controls.Add(this.m_cbbNamHoc);
            this.m_tbHocTap.Controls.Add(this.label7);
            this.m_tbHocTap.Controls.Add(this.m_cbbBoMon);
            this.m_tbHocTap.Controls.Add(this.label6);
            this.m_tbHocTap.Controls.Add(this.m_ccbPhanQuyen);
            this.m_tbHocTap.Controls.Add(this.label5);
            this.m_tbHocTap.Controls.Add(this.m_btXemDiem);
            this.m_tbHocTap.Controls.Add(this.m_btSuaDiem);
            this.m_tbHocTap.Location = new System.Drawing.Point(1, 20);
            this.m_tbHocTap.Name = "m_tbHocTap";
            this.m_tbHocTap.Padding = new System.Windows.Forms.Padding(3);
            this.m_tbHocTap.Size = new System.Drawing.Size(873, 79);
            this.m_tbHocTap.TabIndex = 1;
            this.m_tbHocTap.Text = "Học Tập";
            this.m_tbHocTap.UseVisualStyleBackColor = true;
            // 
            // m_cbbNamHoc
            // 
            this.m_cbbNamHoc.FormattingEnabled = true;
            this.m_cbbNamHoc.Location = new System.Drawing.Point(346, 46);
            this.m_cbbNamHoc.Name = "m_cbbNamHoc";
            this.m_cbbNamHoc.Size = new System.Drawing.Size(121, 21);
            this.m_cbbNamHoc.TabIndex = 13;
            this.m_cbbNamHoc.SelectedIndexChanged += new System.EventHandler(this.m_cbbNamHoc_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(289, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Năm học:";
            // 
            // m_cbbBoMon
            // 
            this.m_cbbBoMon.FormattingEnabled = true;
            this.m_cbbBoMon.Location = new System.Drawing.Point(520, 12);
            this.m_cbbBoMon.Name = "m_cbbBoMon";
            this.m_cbbBoMon.Size = new System.Drawing.Size(121, 21);
            this.m_cbbBoMon.TabIndex = 11;
            this.m_cbbBoMon.SelectedIndexChanged += new System.EventHandler(this.m_cbbBoMon_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(482, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Môn:";
            // 
            // m_ccbPhanQuyen
            // 
            this.m_ccbPhanQuyen.FormattingEnabled = true;
            this.m_ccbPhanQuyen.Location = new System.Drawing.Point(346, 12);
            this.m_ccbPhanQuyen.Name = "m_ccbPhanQuyen";
            this.m_ccbPhanQuyen.Size = new System.Drawing.Size(121, 21);
            this.m_ccbPhanQuyen.TabIndex = 9;
            this.m_ccbPhanQuyen.SelectedIndexChanged += new System.EventHandler(this.m_ccbPhanQuyen_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(255, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Xem theo quyền:";
            // 
            // m_btXemDiem
            // 
            this.m_btXemDiem.AlphaGlow = 40F;
            this.m_btXemDiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(208)))), ((int)(((byte)(136)))));
            this.m_btXemDiem.ButtonImage = global::QuanLyHocSinh.Properties.Resources.xem;
            this.m_btXemDiem.ButtonText = "Xem điểm";
            this.m_btXemDiem.DeltaAlphaGlow = 8F;
            this.m_btXemDiem.DeltaDistance = 2F;
            this.m_btXemDiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_btXemDiem.HaveEffects = true;
            this.m_btXemDiem.ImageOrigin = new System.Drawing.Point(0, -8);
            this.m_btXemDiem.ImageSize = new System.Drawing.Size(60, 40);
            this.m_btXemDiem.Location = new System.Drawing.Point(6, 6);
            this.m_btXemDiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_btXemDiem.MouseState = QuanLyHocSinh.ButtonFlat.MouseStates.Leave;
            this.m_btXemDiem.Name = "m_btXemDiem";
            this.m_btXemDiem.SaveChanged = false;
            this.m_btXemDiem.ShadownDistance = 6;
            this.m_btXemDiem.Size = new System.Drawing.Size(111, 62);
            this.m_btXemDiem.TabIndex = 7;
            this.m_btXemDiem.TextAlignment = QuanLyHocSinh.ButtonFlat.BTTextAlignment.Bot;
            this.m_btXemDiem.TextColor = System.Drawing.Color.White;
            this.m_btXemDiem.TextOrigin = new System.Drawing.Point(0, 0);
            this.m_btXemDiem.Click += new System.EventHandler(this.button_Click);
            // 
            // m_btSuaDiem
            // 
            this.m_btSuaDiem.AlphaGlow = 40F;
            this.m_btSuaDiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(208)))), ((int)(((byte)(136)))));
            this.m_btSuaDiem.ButtonImage = global::QuanLyHocSinh.Properties.Resources.chinhsua;
            this.m_btSuaDiem.ButtonText = "Sửa điểm";
            this.m_btSuaDiem.DeltaAlphaGlow = 8F;
            this.m_btSuaDiem.DeltaDistance = 2F;
            this.m_btSuaDiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_btSuaDiem.HaveEffects = true;
            this.m_btSuaDiem.ImageOrigin = new System.Drawing.Point(0, -8);
            this.m_btSuaDiem.ImageSize = new System.Drawing.Size(40, 40);
            this.m_btSuaDiem.Location = new System.Drawing.Point(135, 6);
            this.m_btSuaDiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_btSuaDiem.MouseState = QuanLyHocSinh.ButtonFlat.MouseStates.Leave;
            this.m_btSuaDiem.Name = "m_btSuaDiem";
            this.m_btSuaDiem.SaveChanged = false;
            this.m_btSuaDiem.ShadownDistance = 6;
            this.m_btSuaDiem.Size = new System.Drawing.Size(111, 62);
            this.m_btSuaDiem.TabIndex = 4;
            this.m_btSuaDiem.TextAlignment = QuanLyHocSinh.ButtonFlat.BTTextAlignment.Bot;
            this.m_btSuaDiem.TextColor = System.Drawing.Color.White;
            this.m_btSuaDiem.TextOrigin = new System.Drawing.Point(0, 0);
            this.m_btSuaDiem.Click += new System.EventHandler(this.button_Click);
            // 
            // m_tbBaoCao
            // 
            this.m_tbBaoCao.Controls.Add(this.label11);
            this.m_tbBaoCao.Controls.Add(this.label9);
            this.m_tbBaoCao.Controls.Add(this.m_cbbBaoCaonamhoc);
            this.m_tbBaoCao.Controls.Add(this.label10);
            this.m_tbBaoCao.Controls.Add(this.m_cbbBaoCaoLoai);
            this.m_tbBaoCao.Controls.Add(this.m_cbbBaoCaohocky);
            this.m_tbBaoCao.Controls.Add(this.label8);
            this.m_tbBaoCao.Controls.Add(this.m_cbbBaoCaomonhoc);
            this.m_tbBaoCao.Controls.Add(this.m_btBaoCao);
            this.m_tbBaoCao.Location = new System.Drawing.Point(1, 20);
            this.m_tbBaoCao.Name = "m_tbBaoCao";
            this.m_tbBaoCao.Size = new System.Drawing.Size(873, 79);
            this.m_tbBaoCao.TabIndex = 2;
            this.m_tbBaoCao.Text = "Báo Cáo";
            this.m_tbBaoCao.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(380, 14);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Năm học:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(142, 14);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Loại báo cáo:";
            // 
            // m_cbbBaoCaonamhoc
            // 
            this.m_cbbBaoCaonamhoc.FormattingEnabled = true;
            this.m_cbbBaoCaonamhoc.Location = new System.Drawing.Point(441, 11);
            this.m_cbbBaoCaonamhoc.Margin = new System.Windows.Forms.Padding(2);
            this.m_cbbBaoCaonamhoc.Name = "m_cbbBaoCaonamhoc";
            this.m_cbbBaoCaonamhoc.Size = new System.Drawing.Size(144, 21);
            this.m_cbbBaoCaonamhoc.TabIndex = 9;
            this.m_cbbBaoCaonamhoc.SelectedIndexChanged += new System.EventHandler(this.m_cbbBaoCaonamhoc_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(391, 50);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Học kỳ:";
            // 
            // m_cbbBaoCaoLoai
            // 
            this.m_cbbBaoCaoLoai.FormattingEnabled = true;
            this.m_cbbBaoCaoLoai.Location = new System.Drawing.Point(217, 11);
            this.m_cbbBaoCaoLoai.Margin = new System.Windows.Forms.Padding(2);
            this.m_cbbBaoCaoLoai.Name = "m_cbbBaoCaoLoai";
            this.m_cbbBaoCaoLoai.Size = new System.Drawing.Size(144, 21);
            this.m_cbbBaoCaoLoai.TabIndex = 9;
            this.m_cbbBaoCaoLoai.SelectedIndexChanged += new System.EventHandler(this.m_cbbBaoCaoLoai_SelectedIndexChanged);
            // 
            // m_cbbBaoCaohocky
            // 
            this.m_cbbBaoCaohocky.FormattingEnabled = true;
            this.m_cbbBaoCaohocky.Location = new System.Drawing.Point(441, 48);
            this.m_cbbBaoCaohocky.Margin = new System.Windows.Forms.Padding(2);
            this.m_cbbBaoCaohocky.Name = "m_cbbBaoCaohocky";
            this.m_cbbBaoCaohocky.Size = new System.Drawing.Size(144, 21);
            this.m_cbbBaoCaohocky.TabIndex = 9;
            this.m_cbbBaoCaohocky.SelectedIndexChanged += new System.EventHandler(this.m_cbbBaoCaohocky_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(162, 50);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Môn học:";
            // 
            // m_cbbBaoCaomonhoc
            // 
            this.m_cbbBaoCaomonhoc.FormattingEnabled = true;
            this.m_cbbBaoCaomonhoc.Location = new System.Drawing.Point(217, 48);
            this.m_cbbBaoCaomonhoc.Margin = new System.Windows.Forms.Padding(2);
            this.m_cbbBaoCaomonhoc.Name = "m_cbbBaoCaomonhoc";
            this.m_cbbBaoCaomonhoc.Size = new System.Drawing.Size(144, 21);
            this.m_cbbBaoCaomonhoc.TabIndex = 9;
            this.m_cbbBaoCaomonhoc.SelectedIndexChanged += new System.EventHandler(this.m_cbbBaoCaomonhoc_SelectedIndexChanged);
            // 
            // m_btBaoCao
            // 
            this.m_btBaoCao.AlphaGlow = 40F;
            this.m_btBaoCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(208)))), ((int)(((byte)(136)))));
            this.m_btBaoCao.ButtonImage = global::QuanLyHocSinh.Properties.Resources.iconreport;
            this.m_btBaoCao.ButtonText = "Báo cáo";
            this.m_btBaoCao.DeltaAlphaGlow = 8F;
            this.m_btBaoCao.DeltaDistance = 2F;
            this.m_btBaoCao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_btBaoCao.HaveEffects = true;
            this.m_btBaoCao.ImageOrigin = new System.Drawing.Point(0, -8);
            this.m_btBaoCao.ImageSize = new System.Drawing.Size(40, 40);
            this.m_btBaoCao.Location = new System.Drawing.Point(9, 6);
            this.m_btBaoCao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_btBaoCao.MouseState = QuanLyHocSinh.ButtonFlat.MouseStates.Leave;
            this.m_btBaoCao.Name = "m_btBaoCao";
            this.m_btBaoCao.SaveChanged = false;
            this.m_btBaoCao.ShadownDistance = 6;
            this.m_btBaoCao.Size = new System.Drawing.Size(127, 62);
            this.m_btBaoCao.TabIndex = 8;
            this.m_btBaoCao.TextAlignment = QuanLyHocSinh.ButtonFlat.BTTextAlignment.Bot;
            this.m_btBaoCao.TextColor = System.Drawing.Color.White;
            this.m_btBaoCao.TextOrigin = new System.Drawing.Point(0, 0);
            this.m_btBaoCao.Click += new System.EventHandler(this.m_btBaoCao_Click);
            // 
            // m_btCaiDat
            // 
            this.m_btCaiDat.AlphaGlow = 40F;
            this.m_btCaiDat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btCaiDat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(99)))));
            this.m_btCaiDat.ButtonImage = global::QuanLyHocSinh.Properties.Resources.iconsetting;
            this.m_btCaiDat.ButtonText = "Cài đặt";
            this.m_btCaiDat.DeltaAlphaGlow = 8F;
            this.m_btCaiDat.DeltaDistance = 2F;
            this.m_btCaiDat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_btCaiDat.HaveEffects = false;
            this.m_btCaiDat.ImageOrigin = new System.Drawing.Point(35, 0);
            this.m_btCaiDat.ImageSize = new System.Drawing.Size(20, 20);
            this.m_btCaiDat.Location = new System.Drawing.Point(542, 2);
            this.m_btCaiDat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_btCaiDat.MouseState = QuanLyHocSinh.ButtonFlat.MouseStates.Leave;
            this.m_btCaiDat.Name = "m_btCaiDat";
            this.m_btCaiDat.SaveChanged = false;
            this.m_btCaiDat.ShadownDistance = 6;
            this.m_btCaiDat.Size = new System.Drawing.Size(101, 28);
            this.m_btCaiDat.TabIndex = 13;
            this.m_btCaiDat.TextAlignment = QuanLyHocSinh.ButtonFlat.BTTextAlignment.Center;
            this.m_btCaiDat.TextColor = System.Drawing.Color.White;
            this.m_btCaiDat.TextOrigin = new System.Drawing.Point(-8, 0);
            this.m_btCaiDat.Click += new System.EventHandler(this.button_Click);
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
            this.m_btHide.Location = new System.Drawing.Point(763, 2);
            this.m_btHide.Margin = new System.Windows.Forms.Padding(2);
            this.m_btHide.MouseState = QuanLyHocSinh.ButtonFlat.MouseStates.Leave;
            this.m_btHide.Name = "m_btHide";
            this.m_btHide.SaveChanged = false;
            this.m_btHide.ShadownDistance = 6;
            this.m_btHide.Size = new System.Drawing.Size(46, 28);
            this.m_btHide.TabIndex = 12;
            this.m_btHide.TextAlignment = QuanLyHocSinh.ButtonFlat.BTTextAlignment.Bot;
            this.m_btHide.TextColor = System.Drawing.Color.White;
            this.m_btHide.TextOrigin = new System.Drawing.Point(0, 0);
            this.m_btHide.Click += new System.EventHandler(this.button_Click);
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
            this.m_btmaxSize.Location = new System.Drawing.Point(813, 2);
            this.m_btmaxSize.Margin = new System.Windows.Forms.Padding(2);
            this.m_btmaxSize.MouseState = QuanLyHocSinh.ButtonFlat.MouseStates.Leave;
            this.m_btmaxSize.Name = "m_btmaxSize";
            this.m_btmaxSize.SaveChanged = false;
            this.m_btmaxSize.ShadownDistance = 6;
            this.m_btmaxSize.Size = new System.Drawing.Size(46, 28);
            this.m_btmaxSize.TabIndex = 11;
            this.m_btmaxSize.TextAlignment = QuanLyHocSinh.ButtonFlat.BTTextAlignment.Bot;
            this.m_btmaxSize.TextColor = System.Drawing.Color.White;
            this.m_btmaxSize.TextOrigin = new System.Drawing.Point(0, 0);
            this.m_btmaxSize.Click += new System.EventHandler(this.button_Click);
            // 
            // m_btdangXuat
            // 
            this.m_btdangXuat.AlphaGlow = 40F;
            this.m_btdangXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btdangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(99)))));
            this.m_btdangXuat.ButtonImage = global::QuanLyHocSinh.Properties.Resources.iconLogout;
            this.m_btdangXuat.ButtonText = "đăng xuất";
            this.m_btdangXuat.DeltaAlphaGlow = 8F;
            this.m_btdangXuat.DeltaDistance = 2F;
            this.m_btdangXuat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_btdangXuat.HaveEffects = false;
            this.m_btdangXuat.ImageOrigin = new System.Drawing.Point(35, 0);
            this.m_btdangXuat.ImageSize = new System.Drawing.Size(20, 20);
            this.m_btdangXuat.Location = new System.Drawing.Point(651, 2);
            this.m_btdangXuat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_btdangXuat.MouseState = QuanLyHocSinh.ButtonFlat.MouseStates.Leave;
            this.m_btdangXuat.Name = "m_btdangXuat";
            this.m_btdangXuat.SaveChanged = false;
            this.m_btdangXuat.ShadownDistance = 6;
            this.m_btdangXuat.Size = new System.Drawing.Size(102, 28);
            this.m_btdangXuat.TabIndex = 10;
            this.m_btdangXuat.TextAlignment = QuanLyHocSinh.ButtonFlat.BTTextAlignment.Center;
            this.m_btdangXuat.TextColor = System.Drawing.Color.White;
            this.m_btdangXuat.TextOrigin = new System.Drawing.Point(-8, 0);
            this.m_btdangXuat.Click += new System.EventHandler(this.m_dangXuatbtn_Click);
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
            this.m_btclose.Location = new System.Drawing.Point(862, 2);
            this.m_btclose.MouseState = QuanLyHocSinh.ButtonFlat.MouseStates.Leave;
            this.m_btclose.Name = "m_btclose";
            this.m_btclose.SaveChanged = false;
            this.m_btclose.ShadownDistance = 6;
            this.m_btclose.Size = new System.Drawing.Size(46, 28);
            this.m_btclose.TabIndex = 9;
            this.m_btclose.TextAlignment = QuanLyHocSinh.ButtonFlat.BTTextAlignment.Bot;
            this.m_btclose.TextColor = System.Drawing.Color.White;
            this.m_btclose.TextOrigin = new System.Drawing.Point(0, 0);
            this.m_btclose.Click += new System.EventHandler(this.button_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(910, 524);
            this.Controls.Add(this.m_btCaiDat);
            this.Controls.Add(this.m_btHide);
            this.Controls.Add(this.m_btmaxSize);
            this.Controls.Add(this.m_btdangXuat);
            this.Controls.Add(this.m_btclose);
            this.Controls.Add(this.m_lblName);
            this.Controls.Add(this.m_lblLopBoMon);
            this.Controls.Add(this.m_lblLopCN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.m_lblID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_scMain);
            this.Controls.Add(this.m_dgvMain);
            this.Controls.Add(this.m_tcMain);
            this.Controls.Add(this.m_treeViewKhoi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.m_dgwMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dgvMain)).EndInit();
            this.m_tcMain.ResumeLayout(false);
            this.m_tbHoSo.ResumeLayout(false);
            this.m_tbHocTap.ResumeLayout(false);
            this.m_tbHocTap.PerformLayout();
            this.m_tbBaoCao.ResumeLayout(false);
            this.m_tbBaoCao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView m_treeViewKhoi;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridView m_dgwMain;
        private System.Windows.Forms.DataGridView m_dgvMain;
        private SearchControl m_scMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label m_lblID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label m_lblName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label m_lblLopCN;
        private System.Windows.Forms.Label m_lblLopBoMon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage m_tbBaoCao;
        //private System.Windows.Forms.Button m_btBaoCao;
        private System.Windows.Forms.ComboBox m_ccbPhanQuyen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox m_cbbBoMon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox m_cbbNamHoc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage m_tbHocTap;
        private System.Windows.Forms.TabPage m_tbHoSo;
        private CustomTabControl m_tcMain;
        private ButtonFlat m_btXemThongTin;
        private ButtonFlat m_btSuaHS;
        private ButtonFlat m_btXoaHS;
        private ButtonFlat m_btThemHS;
        private ButtonFlat m_btXemDiem;
        private ButtonFlat m_btSuaDiem;
        private ButtonFlat m_btBaoCao;
        private ButtonFlat m_btclose;
        private ButtonFlat m_btdangXuat;
        private ButtonFlat m_btmaxSize;
        private ButtonFlat m_btHide;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox m_cbbBaoCaomonhoc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox m_cbbBaoCaonamhoc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox m_cbbBaoCaoLoai;
        private System.Windows.Forms.ComboBox m_cbbBaoCaohocky;
        private ButtonFlat m_btCaiDat;
    }
}

