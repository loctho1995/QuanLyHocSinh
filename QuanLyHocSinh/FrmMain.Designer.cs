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
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Lớp 10A1");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Lớp 10A2");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Lớp10A3");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Lớp10A4");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Khối 10", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Lớp 11A1");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Lớp 11A2");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Lớp 11A3");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Khối 11", new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode20,
            treeNode21});
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Lớp 12A1");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Lớp 12A2");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Khối 12", new System.Windows.Forms.TreeNode[] {
            treeNode23,
            treeNode24});
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Khối", new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode22,
            treeNode25});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.m_treeViewKhoi = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.m_dgwMain = new System.Windows.Forms.DataGridView();
            this.m_btclose = new System.Windows.Forms.Button();
            this.m_tcMain = new System.Windows.Forms.TabControl();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.m_dgwMain)).BeginInit();
            this.m_tcMain.SuspendLayout();
            this.m_tbHoSo.SuspendLayout();
            this.m_tbHocTap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // m_treeViewKhoi
            // 
            this.m_treeViewKhoi.ImageIndex = 0;
            this.m_treeViewKhoi.ImageList = this.imageList1;
            this.m_treeViewKhoi.Location = new System.Drawing.Point(2, 129);
            this.m_treeViewKhoi.Name = "m_treeViewKhoi";
            treeNode14.Name = "m_node10A1";
            treeNode14.Text = "Lớp 10A1";
            treeNode15.Name = "m_node10A2";
            treeNode15.Text = "Lớp 10A2";
            treeNode16.Name = "m_node10A3";
            treeNode16.Text = "Lớp10A3";
            treeNode17.Name = "m_node10A4";
            treeNode17.Text = "Lớp10A4";
            treeNode18.ImageIndex = 2;
            treeNode18.Name = "m_nodeKhoi10";
            treeNode18.Text = "Khối 10";
            treeNode19.Name = "m_node11A1";
            treeNode19.Text = "Lớp 11A1";
            treeNode20.Name = "m_node11A2";
            treeNode20.Text = "Lớp 11A2";
            treeNode21.Name = "m_node11A3";
            treeNode21.Text = "Lớp 11A3";
            treeNode22.ImageIndex = 2;
            treeNode22.Name = "m_nodeKhoi11";
            treeNode22.Text = "Khối 11";
            treeNode23.Name = "m_node12A1";
            treeNode23.Text = "Lớp 12A1";
            treeNode24.Name = "m_node12A2";
            treeNode24.Text = "Lớp 12A2";
            treeNode25.ImageIndex = 2;
            treeNode25.Name = "m_nodeKhoi12";
            treeNode25.Text = "Khối 12";
            treeNode26.Checked = true;
            treeNode26.ImageIndex = 1;
            treeNode26.Name = "m_nodeKhoi";
            treeNode26.Text = "Khối";
            this.m_treeViewKhoi.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode26});
            this.m_treeViewKhoi.SelectedImageIndex = 0;
            this.m_treeViewKhoi.Size = new System.Drawing.Size(186, 346);
            this.m_treeViewKhoi.TabIndex = 0;
            this.m_treeViewKhoi.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.m_treeViewKhoi_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Icon.png");
            this.imageList1.Images.SetKeyName(1, "ca5a7a83-ec54-45a1-a672-ea165d7fbe1f.png");
            this.imageList1.Images.SetKeyName(2, "a5f99b25-f0c5-4c17-8561-8dc5614ba143.png");
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
            this.m_btclose.Location = new System.Drawing.Point(824, 3);
            this.m_btclose.Name = "m_btclose";
            this.m_btclose.Size = new System.Drawing.Size(84, 21);
            this.m_btclose.TabIndex = 3;
            this.m_btclose.Text = "Close";
            this.m_btclose.UseVisualStyleBackColor = true;
            this.m_btclose.Click += new System.EventHandler(this.button_Click);
            // 
            // m_tcMain
            // 
            this.m_tcMain.Controls.Add(this.m_tbHoSo);
            this.m_tcMain.Controls.Add(this.m_tbHocTap);
            this.m_tcMain.Controls.Add(this.m_tbBaoCao);
            this.m_tcMain.Controls.Add(this.m_tbTraCuu);
            this.m_tcMain.Location = new System.Drawing.Point(1, 23);
            this.m_tcMain.Name = "m_tcMain";
            this.m_tcMain.SelectedIndex = 0;
            this.m_tcMain.Size = new System.Drawing.Size(908, 100);
            this.m_tcMain.TabIndex = 4;
            // 
            // m_tbHoSo
            // 
            this.m_tbHoSo.Controls.Add(this.m_btXemThongTin);
            this.m_tbHoSo.Controls.Add(this.m_btThemHS);
            this.m_tbHoSo.Controls.Add(this.m_btSuaHS);
            this.m_tbHoSo.Controls.Add(this.m_btXoaHS);
            this.m_tbHoSo.Location = new System.Drawing.Point(4, 22);
            this.m_tbHoSo.Name = "m_tbHoSo";
            this.m_tbHoSo.Padding = new System.Windows.Forms.Padding(3);
            this.m_tbHoSo.Size = new System.Drawing.Size(900, 74);
            this.m_tbHoSo.TabIndex = 0;
            this.m_tbHoSo.Text = "Hồ Sơ";
            this.m_tbHoSo.UseVisualStyleBackColor = true;            
            // 
            // m_btXemThongTin
            // 
            this.m_btXemThongTin.Location = new System.Drawing.Point(6, 6);
            this.m_btXemThongTin.Name = "m_btXemThongTin";
            this.m_btXemThongTin.Size = new System.Drawing.Size(111, 62);
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
            this.m_tbHocTap.Location = new System.Drawing.Point(4, 22);
            this.m_tbHocTap.Name = "m_tbHocTap";
            this.m_tbHocTap.Padding = new System.Windows.Forms.Padding(3);
            this.m_tbHocTap.Size = new System.Drawing.Size(900, 74);
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
            this.m_tbBaoCao.Location = new System.Drawing.Point(4, 22);
            this.m_tbBaoCao.Name = "m_tbBaoCao";
            this.m_tbBaoCao.Size = new System.Drawing.Size(900, 74);
            this.m_tbBaoCao.TabIndex = 2;
            this.m_tbBaoCao.Text = "Báo Cáo";
            this.m_tbBaoCao.UseVisualStyleBackColor = true;
            this.m_tbBaoCao.Click += new System.EventHandler(this.button_Click);
            // 
            // m_tbTraCuu
            // 
            this.m_tbTraCuu.Location = new System.Drawing.Point(4, 22);
            this.m_tbTraCuu.Name = "m_tbTraCuu";
            this.m_tbTraCuu.Size = new System.Drawing.Size(900, 74);
            this.m_tbTraCuu.TabIndex = 3;
            this.m_tbTraCuu.Text = "Tra Cứu";
            this.m_tbTraCuu.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(194, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(716, 348);
            this.dataGridView1.TabIndex = 5;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(910, 479);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.m_tcMain);
            this.Controls.Add(this.m_btclose);
            this.Controls.Add(this.m_treeViewKhoi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.m_dgwMain)).EndInit();
            this.m_tcMain.ResumeLayout(false);
            this.m_tbHoSo.ResumeLayout(false);
            this.m_tbHocTap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView m_treeViewKhoi;
        private System.Windows.Forms.Button m_btclose;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabControl m_tcMain;
        private System.Windows.Forms.TabPage m_tbHoSo;
        private System.Windows.Forms.TabPage m_tbHocTap;
        private System.Windows.Forms.Button m_btXemThongTin;
        private System.Windows.Forms.Button m_btThemHS;
        private System.Windows.Forms.Button m_btXoaHS;
        private System.Windows.Forms.Button m_btXemDiem;
        private System.Windows.Forms.Button m_btSuaDiem;
        private System.Windows.Forms.TabPage m_tbBaoCao;
        private System.Windows.Forms.TabPage m_tbTraCuu;
        private System.Windows.Forms.DataGridView m_dgwMain;
        private System.Windows.Forms.Button m_btSuaHS;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

