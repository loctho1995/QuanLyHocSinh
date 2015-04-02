
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace QuanLyHocSinh
{
    public partial class FrmMain : Form
    {
        HocSinh_BUS hs = new HocSinh_BUS();
        public static PhanQuyenDangNhap m_phanquyen = new PhanQuyenDangNhap();
        bool m_checkseach = false;
        int tabpage = 0; //them 1 bien de xac dinh dang o tab nao, su dung cho treeview ( 0 = Ho So, 1 = Hoc Tap, 2 = Bao Cao, 3 = Tra Cuu)

        //cho phép resize góc dưới bên phải
        private const int cGrip = 5;      // Grip size, khoảng range để xác định cho việc resize form xem thêm ở WndPrc

        public FrmMain()
        {            
            //this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.CacheText, true);
            this.DoubleBuffered = true;

            InitializeComponent();
            this.BackColor = Color.FromArgb(62, 70, 73);
            m_tbHoSo.BackColor = Color.FromArgb(35, 168, 111);
            m_scMain.BackColor = Color.FromArgb(44, 208, 136);
            m_scMain.ShadowColor = m_tbHoSo.BackColor;
            //m_btflat.BackColor = Color.FromArgb(54, 190, 130);
            m_scMain.LabelSearch.ForeColor = Color.FromArgb(49, 52, 55);
            //m_btflat.ButtonText = "button flat";

            /* Mau xanh la
            this.BackColor = Color.FromArgb(63, 159, 63);
            m_tbHoSo.BackColor = Color.FromArgb(105, 213, 105);
            m_tbHocTap.UseVisualStyleBackColor = true;
            m_tbBaoCao.BackColor = Color.FromArgb(123, 241, 123);
            m_tbHocTap.BackColor = Color.FromArgb(123, 241, 123);
            m_scMain.BackColor = Color.FromArgb(142, 252, 142);
            m_scMain.ShadowColor = m_tbHoSo.BackColor;
            m_scMain.LabelSearch.ForeColor = Color.FromArgb(92, 92, 92);
            m_btflat.BackColor = Color.FromArgb(232, 76, 61);
            */

            m_treeViewKhoi.ExpandAll(); 

            m_scMain.TextBoxSearch.TextChanged += TextBoxSearch_TextChanged;
            m_treeViewKhoi.ExpandAll();
            m_dgvMain.BorderStyle = BorderStyle.None;
            m_lblID.Text = m_phanquyen.ID;
            m_lblName.Text = m_phanquyen.Username;
            m_lblLopCN.Text = m_phanquyen.LopCN;
            for (int i = 0; i < m_phanquyen.LopBM.Count(); i++)
                m_lblLopBoMon.Text += m_phanquyen.LopBM[i];
            //m_btBaoCao.Enabled = false;

            m_tcMain.SelectedIndexChanged += m_tcMain_SelectedIndexChanged;//them su kien chuyen tabpage trong tabcontrol
        }

        //ham bat su kien chuyen tabpage
        void m_tcMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cac cau lenh dung de xac dinh tabpage nao dang duoc chon de gan cho bien static tab gia tri tuong ung
            if (m_tcMain.TabPages[0].Focus() == true)
                tabpage = 0;

            if (m_tcMain.TabPages[1].Focus() == true)
                tabpage = 1;

            if (m_tcMain.TabPages[2].Focus() == true)
                tabpage = 2;

            if (m_tcMain.TabPages[3].Focus() == true)
                tabpage = 3;

            //cau lenh lam mat datagridview khi chuyen tab
            m_dgvMain.DataSource = null;

            
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            m_checkseach = true;
            if (m_scMain.TextBoxSearch.Text == "")
            {
                m_dgvMain.DataSource = null;
                m_checkseach = false;
            }
            else
                DesignDataGridView(m_dgvMain, m_scMain.TextBoxSearch.Text);
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);

                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;

                    Point pos = new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16);
                    pos = this.PointToClient(pos);

                    /*
                    const int htLeft = 10;
                    const int htRight = 11;
                    const int htTop = 12;
                    const int htTopLeft = 13;
                    const int htTopRight = 14;
                    const int htBottom = 15;            
                    const int htBottomLeft = 16;
                    const int htBottomRight = 17;  
                     */

                    //if (pos.Y < cCaption)
                    //{
                    //    m.Result = (IntPtr)2;  // HTCAPTION
                    //    return;
                    //}

                    //rê chuột vào phía cạnh bên trái
                    if (pos.X <= cGrip && pos.Y < this.ClientSize.Height - cGrip && pos.Y > cGrip)
                    {
                        m.Result = (IntPtr)10;  // HTCAPTION
                        return;
                    }

                    //rê chuột vào phía cạnh bên phải
                    if (pos.X >= this.ClientSize.Width - cGrip && pos.Y < this.ClientSize.Height - cGrip && pos.Y > cGrip)
                    {
                        m.Result = (IntPtr)11;
                        return;
                    }

                    //rê chuột vào góc dưới bên phải
                    if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                    {
                        m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                        return;
                    }

                    //rê chuột vào góc dưới bên trái
                    if (pos.X <= cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                    {
                        m.Result = (IntPtr)16;
                        return;
                    }

                    //rê chuột bên phía trên top
                    if (pos.Y < cGrip)
                    {
                        m.Result = (IntPtr)12;
                        return;
                    }


                    //rê chuột xuông dưới bottom
                    if (pos.Y > this.ClientSize.Height - cGrip)
                    {
                        m.Result = (IntPtr)15;
                        return;
                    }

                    this.Invalidate();
                    return;
            }

            base.WndProc(ref m);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        private void button_Click(object sender, EventArgs e)
        {
            switch ((sender as Button).Name)
            {
                case "m_btclose":
                  //  if (MessageBox.Show("Sure Mother fucker?", "Quit", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                        this.Close();
                    break;

                case "m_btXoaHS":
                    XoaHocSinh();
                    break;

                case "m_btXemThongTin":
                    XemThongTin();
                    break;

                case "m_btThemHS":
                    ThemHocSinh();
                    break;

                case "m_btSuaHS":
                    SuaHocSinh();
                    break;
                    
                case "m_btSuaDiem":
                    break;

                case "m_btXemDiem":
                    XemDiem();
                    break;

                default:
                    break;
            }
        }       
        private void m_treeViewKhoi_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //Viet ham check cho button baocao
            //m_btBaoCao.Enabled = false;
            //for (int i = 0; i < m_phanquyen.LopBM.Count(); i++)
            //{
            //    if (e.Node.Text == m_phanquyen.LopBM[i])
            //    {
            //        m_btBaoCao.Enabled = true;
            //        break;
            //    }
            //}
            switch (e.Node.Name)
            {
                //Click vào node khối
                case "m_nodeKhoi":
                    break;

                //Click vào Node Khối 10
                case "m_nodeKhoi10":
                    DesignDataGridView(m_dgvMain, "10");
                    break;

                //Click vào Node khối 11
                case "m_nodeKhoi11":
                    DesignDataGridView(m_dgvMain, "11");
                    break;

                //Click vào Node khối 11
                case "m_nodeKhoi12":
                    DesignDataGridView(m_dgvMain, "12");
                    break;

                case "m_node10A1":
                    DesignDataGridView(m_dgvMain, "10a1");
                    break;

                case "m_node10A2":
                    DesignDataGridView(m_dgvMain, "10a2");
                    break;

                case "m_node10A3":
                    DesignDataGridView(m_dgvMain, "10a3");
                    break;

                case "m_node10A4":
                    DesignDataGridView(m_dgvMain, "10a4");
                    break;

                case "m_node11A1":
                    DesignDataGridView(m_dgvMain, "11a1");
                    break;

                case "m_node11A2":
                    DesignDataGridView(m_dgvMain, "11a2");
                    break;

                case "m_node11A3":
                    DesignDataGridView(m_dgvMain, "11a3");
                    break;

                case "m_node12A1":
                    DesignDataGridView(m_dgvMain, "12a1");
                    break;

                case "m_node12A2":
                    DesignDataGridView(m_dgvMain, "12a2");
                    break;
                default:
                    break;

            }

           // MessageBox.Show((e.Node.Name));
        }

        //private void DesignDataGridView(DataGridView dgv, string ma)
        //{
        //    if (m_checkseach)
        //        dgv.DataSource = hs.TimKiemThongTinHocSinh(ma);//hs.TimKiemThongTinHocSinh(ma);
        //    else if (ma.Length == 2)
        //        dgv.DataSource = hs.LayHocSinh_Khoi(ma, m_phanquyen.ID, m_phanquyen.PhanQuyen);
        //    else dgv.DataSource = hs.LayHocSinh_Lop(ma, m_phanquyen.ID, m_phanquyen.PhanQuyen);
        //    if (dgv.DataSource == null) return;
        //    dgv.Columns["STT"].Width = 40;
        //    dgv.Columns["MAHS"].Width = 50;
        //    dgv.Columns["HOTEN"].Width = 120;
        //    dgv.Columns["GIOITINH"].Width = 50;
        //    dgv.Columns["EMAIL"].Width = 120;
        //    dgv.Columns["MALOP"].Width = 50;
        //    dgv.Columns["MAKHOILOP"].Width = 40;

        //    dgv.Columns["MAHS"].HeaderText = "Mã học sinh";
        //    dgv.Columns["HOTEN"].HeaderText = "Họ và tện";
        //    dgv.Columns["GIOITINH"].HeaderText = "Giới tính";
        //    dgv.Columns["EMAIL"].HeaderText = "Email";
        //    dgv.Columns["DIACHI"].HeaderText = "Địa chỉ";
        //    dgv.Columns["MALOP"].HeaderText = "Mã lớp";
        //    dgv.Columns["MAKHOILOP"].HeaderText = "Mã khối";
        //    dgv.Columns["HOTENCHA"].HeaderText = "Họ tên cha";
        //    dgv.Columns["HOTENME"].HeaderText = "Họ tên mẹ";
        //    dgv.Columns["NGHENGHIEPCHA"].HeaderText = "Nghề nghiệp cha";
        //    dgv.Columns["NGHENGHIEPME"].HeaderText = "Nghề nghiệp mẹ";
        //    m_checkseach = false;
        //}
        //them vao ham DesignDataGridView switch de xu ly tab
        private void DesignDataGridView(DataGridView dgv, string ma)
        {
            if (m_checkseach)//m_checkseach = true -> dang tim kiem hoc sinh
            {
                dgv.DataSource = hs.TimKiemThongTinHocSinh(ma);//hs.TimKiemThongTinHocSinh(ma);
                m_checkseach = false;
            }

            else//m_checkseach = false -> dang su dung tree view
            {
                switch (tabpage)//tabpage se cho biet tabpage nao dang duoc chon
                {
                    case 0://tabpage Ho So

                        if (ma.Length == 2)
                            dgv.DataSource = hs.LayHocSinh_Khoi(ma, m_phanquyen.ID, m_phanquyen.PhanQuyen);
                        else dgv.DataSource = hs.LayHocSinh_Lop(ma, m_phanquyen.ID, m_phanquyen.PhanQuyen);
                        if (dgv.DataSource == null) return;
                        dgv.Columns["STT"].Width = 40;
                        dgv.Columns["MAHS"].Width = 50;
                        dgv.Columns["HOTEN"].Width = 120;
                        dgv.Columns["GIOITINH"].Width = 50;
                        dgv.Columns["EMAIL"].Width = 120;
                        dgv.Columns["MALOP"].Width = 50;
                        dgv.Columns["MAKHOILOP"].Width = 40;

                        dgv.Columns["MAHS"].HeaderText = "Mã học sinh";
                        dgv.Columns["HOTEN"].HeaderText = "Họ và tên";
                        dgv.Columns["GIOITINH"].HeaderText = "Giới tính";
                        dgv.Columns["EMAIL"].HeaderText = "Email";
                        dgv.Columns["DIACHI"].HeaderText = "Địa chỉ";
                        dgv.Columns["MALOP"].HeaderText = "Mã lớp";
                        dgv.Columns["MAKHOILOP"].HeaderText = "Mã khối";
                        dgv.Columns["HOTENCHA"].HeaderText = "Họ tên cha";
                        dgv.Columns["HOTENME"].HeaderText = "Họ tên mẹ";
                        dgv.Columns["NGHENGHIEPCHA"].HeaderText = "Nghề nghiệp cha";
                        dgv.Columns["NGHENGHIEPME"].HeaderText = "Nghề nghiệp mẹ";

                        break;

                    case 1://tabpage Hoc tap
                        dgv.DataSource = hs.LayDiemHocSinh_LopChuNhiem(ma, m_phanquyen.ID, m_phanquyen.PhanQuyen);
                        if (dgv.DataSource == null) return;
                        dgv.Columns["STT"].Width = 40;
                        dgv.Columns["MAHS"].Width = 50;
                        dgv.Columns["HOTEN"].Width = 120;
                        dgv.Columns["DIEMTBHKI"].Width = 120;
                        dgv.Columns["DIEMTBHKII"].Width = 120;
                        dgv.Columns["DIEMTBCANAM"].Width = 120;
                        dgv.Columns["MANAMHOC"].Width = 40;

                        dgv.Columns["MAHS"].HeaderText = "Mã học sinh";
                        dgv.Columns["HOTEN"].HeaderText = "Họ và tên";
                        dgv.Columns["DIEMTBHKI"].HeaderText = "Điểm TB HKI";
                        dgv.Columns["DIEMTBHKII"].HeaderText = "Điểm TB HKII";
                        dgv.Columns["DIEMTBCANAM"].HeaderText = "Điểm TB Cả năm";
                        dgv.Columns["MANAMHOC"].HeaderText = "Năm học";

                        break;

                    case 2://tabpage Bao Cao
                        break;

                    case 3://tabpage Tra Cuu
                        break;
                }
            }
        }

        private void ShowHocSinh_Khoi()
        {
            //
            m_dgvMain.DataSource = hs.LayTatCa();
        }

        //Resize control khi form Resize
        private void FrmMain_Resize(object sender, EventArgs e)
        {
            //m_treeViewKhoi.Size = new Size(m_treeViewKhoi.Width, this.Height - m_treeViewKhoi.Location.Y);
            //m_dgwMain.Size = new Size(this.Width - m_dgwMain.Location.X, this.Height - m_dgwMain.Location.Y);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //
        }
        private void ThemHocSinh()
        {
            frmSuaNhapHS frmNhap = new frmSuaNhapHS();
            frmNhap.Show();
        }

        private void SuaHocSinh()
        {
            if (m_dgvMain.DataSource == null)
                MessageBox.Show("Chọn học sinh cần sửa");
            else
            {
                frmSuaNhapHS frmSua = new frmSuaNhapHS(m_dgvMain.SelectedRows[0]);
                frmSua.Show();
            }
        }

        private void XoaHocSinh()
        {
            if (m_dgvMain.DataSource == null)
                MessageBox.Show("chọn học sinh cần xóa");
            else
            {
                int key = 0;
                if(m_dgvMain.SelectedRows[0].Cells["MAHS"] != null)
                  key = int.Parse(m_dgvMain.SelectedRows[0].Cells["MAHS"].Value.ToString());
                if (hs.DeleteHocSinh(key)&&key!=0)
                    MessageBox.Show("Xoá thành công");
                else MessageBox.Show("Thất bại");
            }
        }

        private void XemThongTin()
        {
            if (m_dgvMain.DataSource == null)
                MessageBox.Show("Chọn học sinh cần xem thông tin");
            else
            {
                frmThongTinHS frmTT = new frmThongTinHS(m_dgvMain.SelectedRows[0]);
                frmTT.Show();
            }
        }

        private void XemDiem()
        {
            if (m_dgvMain.DataSource == null)
                MessageBox.Show("Chọn học sinh cần xem thông tin");
            else
            {
                frmXemDiem frmXD = new frmXemDiem(m_dgvMain.SelectedRows[0]);
                frmXD.Show();
            }
            
        }

        private void XuatBaoCao()
        {
            frmBaoCao frmBC = new frmBaoCao(m_treeViewKhoi.SelectedNode.Text);
            frmBC.ShowDialog();
        }

        private void searchControl1_Load(object sender, EventArgs e)
        {
            
        }

        private void m_tbHoSo_Click(object sender, EventArgs e)
        {

        }

        private void searchControl1_Load_1(object sender, EventArgs e)
        {

        }

        private void searchControl2_Load(object sender, EventArgs e)
        {

        }

        private void searchControl1_Load_2(object sender, EventArgs e)
        {

        }

        private void m_dgvMain_DoubleClick(object sender, EventArgs e)
        {
            this.XemThongTin();
        }

        private void m_dangXuatbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Dang Xuat?", "Thong Bao", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
                m_lblID.Text = null;
                m_lblName.Text = null;
                frmDangNhap frmdangNhap = new frmDangNhap();
                frmdangNhap.ShowDialog();
            }
                
            
        }

        private void m_btBaoCao_Click(object sender, EventArgs e)
        {
            XuatBaoCao();
        }
    }
}
