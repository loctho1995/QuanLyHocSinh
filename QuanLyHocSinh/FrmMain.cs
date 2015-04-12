
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
        public static List<frmThongTinHS> ListThongTinHS
        { get; set; }

        public static bool IsSuaNhapOpen
        { get; set; }

        HocSinh_BUS hs = new HocSinh_BUS();
        public static PhanQuyenDangNhap m_phanquyen = new PhanQuyenDangNhap();
        bool m_checkseach = false, bol = true;
        int tabpage = 0; //them 1 bien de xac dinh dang o tab nao, su dung cho treeview ( 0 = Ho So, 1 = Hoc Tap, 2 = Bao Cao, 3 = Tra Cuu)
        static string node = ""; //dung de xac dinh dang chon node nao trong treeview
        static int typebaocao = 10;

        public FrmMain()
        {            
            //this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.CacheText, true);
            this.DoubleBuffered = true;
            InitializeComponent();
            ListThongTinHS = new List<frmThongTinHS>();
            FrmMain.m_phanquyen.LopCN = FrmMain.m_phanquyen.LopCN.Trim();
            LoadDataBaoCao();

            this.BackColor = Color.FromArgb(62, 70, 73);
            m_tbHoSo.BackColor = Color.FromArgb(35, 168, 111);
            m_tbBaoCao.BackColor = Color.FromArgb(35, 168, 111);
            m_tbHocTap.BackColor = Color.FromArgb(35, 168, 111);
            m_tbTraCuu.BackColor = Color.FromArgb(35, 168, 111);

            m_btclose.BackColor = Color.FromArgb(255, 101, 99);
            m_btHide.BackColor = m_btclose.BackColor;
            m_btmaxSize.BackColor = m_btclose.BackColor;

            m_scMain.BackColor = Color.FromArgb(44, 208, 136);
            m_scMain.ShadowColor = m_tbHoSo.BackColor;
            m_scMain.LabelSearch.ForeColor = Color.White;

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

            m_ccbPhanQuyen.Items.Add("GVCN");
            m_ccbPhanQuyen.Items.Add("GVBM");
            m_ccbPhanQuyen.SelectedIndex = 0;

            m_cbbBoMon.DataSource = hs.LayMonHoc();
            m_cbbBoMon.DisplayMember = "TENMONHOC";
            m_cbbBoMon.ValueMember = "MAMONHOC";

            m_cbbNamHoc.DataSource = hs.LayNamHoc();
            m_cbbNamHoc.DisplayMember = "TENNAMHOC";
            m_cbbNamHoc.ValueMember = "MANAMHOC";
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
            {
                
                tabpage = 2;
                bol = false;
            }

            if (m_tcMain.TabPages[3].Focus() == true)
                tabpage = 3;

            //cau lenh lam mat datagridview khi chuyen tab
            m_dgvMain.DataSource = null;

        }

        private void LoadDataBaoCao()
        {
            //if (!bol) return;
            m_cbbBaoCaonamhoc.DataSource = hs.LayNamHoc();
            m_cbbBaoCaonamhoc.DisplayMember = "TENNAMHOC";
            m_cbbBaoCaonamhoc.ValueMember = "MANAMHOC";

            m_cbbBaoCaomonhoc.DataSource = hs.LayMonHoc();
            m_cbbBaoCaomonhoc.DisplayMember = "TENMONHOC";
            m_cbbBaoCaomonhoc.ValueMember = "MAMONHOC";

            m_cbbBaoCaohocky.DataSource = hs.LayHocky();
            m_cbbBaoCaohocky.DisplayMember = "TENHOCKY";
            m_cbbBaoCaohocky.ValueMember = "MAHOCKY";

            if (FrmMain.m_phanquyen.PhanQuyen == 1)
            {
                m_cbbBaoCaoLoai.Items.Add("In danh sách lớp");
                m_cbbBaoCaoLoai.Items.Add("In bảng điểm môn");
                m_cbbBaoCaoLoai.Items.Add("In bảng điểm lớp");
                m_cbbBaoCaoLoai.Items.Add("In báo cáo tổng kết học kì");
                m_cbbBaoCaoLoai.Items.Add("In báo cáo tổng kêt môn");
            }
            else
            {
                m_cbbBaoCaoLoai.Items.Add("In danh sách lớp");
                m_cbbBaoCaoLoai.Items.Add("In bảng điểm môn");
                m_cbbBaoCaoLoai.Items.Add("In bảng điểm lớp");
            }


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

        //cho phép resize góc dưới bên phải
        private const int cGrip = 5;      // Grip size, khoảng range để xác định cho việc resize form xem thêm ở WndPrc
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

        private void button_Click(object sender, EventArgs e)
        {
            switch ((sender as Control).Name)
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
                    SuaDiem();
                    break;

                case "m_btXemDiem":
                    XemDiem();
                    break;

                case "m_btHide":
                    (sender as ButtonFlat).SaveChanged = true;
                    this.WindowState = FormWindowState.Minimized;

                    break;

                case "m_btmaxSize":
                    (sender as ButtonFlat).SaveChanged = true;

                    if (this.WindowState != FormWindowState.Maximized)
                    {
                        this.WindowState = FormWindowState.Maximized;
                        m_btmaxSize.ButtonImage = QuanLyHocSinh.Properties.Resources.iconminsize;
                    }
                    else
                    {
                        this.WindowState = FormWindowState.Normal;
                        m_btmaxSize.ButtonImage = QuanLyHocSinh.Properties.Resources.iconmaxsize;
                    }

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
                case "m_nodeKhoi":
                    break;

                //Click vào Node Khối 10
                case "m_nodeKhoi10":
                    node = "10";
                    break;

                //Click vào Node khối 11
                case "m_nodeKhoi11":
                    node = "11";
                    break;

                //Click vào Node khối 11
                case "m_nodeKhoi12":
                    node = "12";
                    break;

                case "m_node10A1":
                    node = "10a1";
                    break;

                case "m_node10A2":
                    node = "10a2";
                    break;

                case "m_node10A3":
                    node = "10a3";
                    break;

                case "m_node10A4":
                    node = "10a4";
                    break;

                case "m_node11A1":
                    node = "11a1";
                    break;

                case "m_node11A2":
                    node = "11a2";
                    break;

                case "m_node11A3":
                    node = "11a3";
                    break;

                case "m_node12A1":
                    node = "12a1";
                    break;

                case "m_node12A2":
                    node = "12a2";
                    break;
                default:
                    break;

            }
            DesignDataGridView(m_dgvMain, node);
        }
      
        //private void DesignDataGridView(DataGridView dgv, string ma)

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

        private bool CheckGVInLopBM(string lop)
        {
            if (FrmMain.m_phanquyen.PhanQuyen == 1)
                return true;
            foreach (string malop in FrmMain.m_phanquyen.LopBM)
            {
                if (node.ToUpper() == malop.ToUpper().Trim())
                    return true;
            }

            return false;
        }

        //private void DesignDataGridView(DataGridView dgv, string ma)
        //    {
        //    else//m_checkseach = false -> dang su dung tree view
        //    {
        //        switch (tabpage)//tabpage se cho biet tabpage nao dang duoc chon
        //        {
        //            case 0://tabpage Ho So

        //                if (ma.Length == 2)
        //                    dgv.DataSource = hs.LayHocSinh_Khoi(ma, m_phanquyen.ID, m_phanquyen.PhanQuyen);
        //                else dgv.DataSource = hs.LayHocSinh_Lop(ma, m_phanquyen.ID, m_phanquyen.PhanQuyen);
        //                if (dgv.DataSource == null) return;
        //                dgv.Columns["STT"].Width = 40;
        //                dgv.Columns["MAHS"].Width = 50;
        //                dgv.Columns["HOTEN"].Width = 120;
        //                dgv.Columns["GIOITINH"].Width = 50;
        //                dgv.Columns["EMAIL"].Width = 120;
        //                dgv.Columns["MALOP"].Width = 50;
        //                dgv.Columns["MAKHOILOP"].Width = 40;

        //                dgv.Columns["MAHS"].HeaderText = "Mã học sinh";
        //                dgv.Columns["HOTEN"].HeaderText = "Họ và tên";
        //                dgv.Columns["GIOITINH"].HeaderText = "Giới tính";
        //                dgv.Columns["EMAIL"].HeaderText = "Email";
        //                dgv.Columns["DIACHI"].HeaderText = "Địa chỉ";
        //                dgv.Columns["MALOP"].HeaderText = "Mã lớp";
        //                dgv.Columns["MAKHOILOP"].HeaderText = "Mã khối";
        //                dgv.Columns["HOTENCHA"].HeaderText = "Họ tên cha";
        //                dgv.Columns["HOTENME"].HeaderText = "Họ tên mẹ";
        //                dgv.Columns["NGHENGHIEPCHA"].HeaderText = "Nghề nghiệp cha";
        //                dgv.Columns["NGHENGHIEPME"].HeaderText = "Nghề nghiệp mẹ";

        //                break;

        //            case 1://tabpage Hoc tap
        //                if (m_ccbPhanQuyen.Text.ToString() == "GVCN")
        //                {
        //                    dgv.DataSource = hs.LayDiemHocSinh_LopChuNhiem(ma, int.Parse(m_cbbNamHoc.SelectedValue.ToString()), 
        //                                                                        m_phanquyen.ID, m_phanquyen.PhanQuyen);
        //                    if (dgv.DataSource == null) return;
        //                    dgv.Columns["STT"].Width = 40;
        //                    dgv.Columns["MAHS"].Width = 50;
        //                    dgv.Columns["HOTEN"].Width = 120;
        //                    dgv.Columns["DIEMTBHKI"].Width = 120;
        //                    dgv.Columns["DIEMTBHKII"].Width = 120;
        //                    dgv.Columns["DIEMTBCANAM"].Width = 120;
        //                    dgv.Columns["MANAMHOC"].Width = 40;

        //                    dgv.Columns["MAHS"].HeaderText = "Mã học sinh";
        //                    dgv.Columns["HOTEN"].HeaderText = "Họ và tên";
        //                    dgv.Columns["DIEMTBHKI"].HeaderText = "Điểm TB HKI";
        //                    dgv.Columns["DIEMTBHKII"].HeaderText = "Điểm TB HKII";
        //                    dgv.Columns["DIEMTBCANAM"].HeaderText = "Điểm TB Cả năm";
        //                    dgv.Columns["MANAMHOC"].HeaderText = "Năm học";
        //                }
        //                else
        //                {
        //                    dgv.DataSource = hs.LayDiemHocSinh_Mon(ma, m_cbbBoMon.SelectedValue.ToString(), 
        //                                                            int.Parse(m_cbbNamHoc.SelectedValue.ToString()), 
        //                                                            m_phanquyen.ID, m_phanquyen.PhanQuyen);
        //                    if(dgv.DataSource == null) return;

        //                    dgv.Columns["STT"].Width = 40;
        //                    dgv.Columns["MAHS"].Width = 50;
        //                    dgv.Columns["HOTEN"].Width = 120;
        //                    dgv.Columns["DIEMTBMONHKI"].Width = 120;
        //                    dgv.Columns["DIEMTBMONHKII"].Width = 120;

        //                    dgv.Columns["MAHS"].HeaderText = "Mã học sinh";
        //                    dgv.Columns["HOTEN"].HeaderText = "Họ và tên";
        //                    dgv.Columns["DIEMTBMONHKI"].HeaderText = "Điểm TB Môn HKI";
        //                    dgv.Columns["DIEMTBMONHKII"].HeaderText = "Điểm TB Môn HKII";

        //                }
        //                break;

        //            case 2://tabpage Bao Cao
        //                break;

        //            case 3://tabpage Tra Cuu
        //                break;
        //        }

        //        if (node.ToUpper() == malop.ToUpper().Trim())
        //            return true;
        //    }
        //    return false;
        //}

        private bool CheckGVCN(string lop)
        {
            if (FrmMain.m_phanquyen.PhanQuyen == 1)
                return true;
            string malop = m_dgvMain.SelectedRows[0].Cells["MALOP"].Value.ToString().ToUpper().Trim();
            if (lop.ToUpper() == FrmMain.m_phanquyen.LopCN.ToUpper().Trim() || malop == FrmMain.m_phanquyen.LopCN.ToUpper().Trim())
                return true;
            return false;
        }
      
        private void ShowHocSinh_Khoi()
        {
            m_dgvMain.DataSource = hs.LayTatCa();
        }

        private void ThemHocSinh()
        {
            if (!IsSuaNhapOpen)
            {
                frmSuaNhapHS frmNhap = new frmSuaNhapHS();
                frmNhap.Show();
                IsSuaNhapOpen = true;
            }
            else
            {
                MessageBox.Show("hoàn thành chỉnh sửa / nhập học sinh trước khi mở form mới! ");
            }
        }

        private void SuaHocSinh()
        {
            if (m_dgvMain.DataSource == null)
                MessageBox.Show("Chọn học sinh cần sửa");
            else if (!CheckGVCN(node)) MessageBox.Show("Bạn không có quyền sữa hồ sơ học sinh ở lớp này!");
            else
            {
                if (!IsSuaNhapOpen)
                {
                    frmSuaNhapHS frmSua = new frmSuaNhapHS(m_dgvMain.SelectedRows[0]);
                    frmSua.Show();
                    IsSuaNhapOpen = true;
                }
                else
                {
                    MessageBox.Show("hoàn thành chỉnh sửa / nhập học sinh trước khi mở form mới! ");
                }
            }
        }

        private void XoaHocSinh()
        {
            if (m_dgvMain.DataSource == null)
                MessageBox.Show("chọn học sinh cần xóa");
            else if (!CheckGVCN(node)) MessageBox.Show("Bạn không có quyền xóa hồ sơ học sinh ở lớp này!");
            else
            {
                if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                    return;
                int key = 0;
                if(m_dgvMain.SelectedRows[0].Cells["MAHS"] != null)
                  key = int.Parse(m_dgvMain.SelectedRows[0].Cells["MAHS"].Value.ToString());
                if (hs.DeleteHocSinh(key) && key != 0)
                {
                    DesignDataGridView(m_dgvMain, node);
                    MessageBox.Show("Xoá thành công");
                }

                else MessageBox.Show("Thất bại");
            }
        }

        private void XemThongTin()
        {
            if (m_dgvMain.DataSource == null)
                MessageBox.Show("Chọn học sinh cần xem thông tin");
            else
            {
                foreach (var item in ListThongTinHS)
                {
                    if (item.FormID.ToString() == m_dgvMain.SelectedRows[0].Cells["MAHS"].Value.ToString())
                    {
                        item.Hide();
                        item.Show();
                        return;
                    }                        
                }

                frmThongTinHS frmTT = new frmThongTinHS(m_dgvMain.SelectedRows[0]);
                frmTT.FormID = int.Parse(m_dgvMain.SelectedRows[0].Cells["MAHS"].Value.ToString());
                ListThongTinHS.Add(frmTT);
                frmTT.ShowDialog();
            }
        }

        private void XemDiem()
        {
            if (m_dgvMain.DataSource == null)
                MessageBox.Show("Chọn học sinh cần xem thông tin");
            else
            {
                if (m_ccbPhanQuyen.Text.ToString() == "GVCN")
                {
                    frmXemDiem frmXD = new frmXemDiem(m_dgvMain.SelectedRows[0]);
                    frmXD.Show();
                }
                else
                {
                    frmXemSuaDiem_Mon frmXDM = new frmXemSuaDiem_Mon(m_dgvMain.SelectedRows[0], false);
                    frmXDM.Show();
                }
            }
            
        }

        private void SuaDiem()
        {
            if (m_dgvMain.DataSource == null)
                MessageBox.Show("Chọn học sinh cần xem thông tin");
            else
            {
                if (m_ccbPhanQuyen.Text.ToString() == "GVCN")
                {
                    MessageBox.Show("Bạn không có quyền sửa điểm của học sinh!");
                }
                else
                {
                    frmXemSuaDiem_Mon frmXDM = new frmXemSuaDiem_Mon(m_dgvMain.SelectedRows[0], true);
                    frmXDM.Show();
                }
            }
        }

        private void XuatBaoCao()
        {
            try
            {
                frmBaoCao frmBC = new frmBaoCao(m_dgvMain, m_treeViewKhoi.SelectedNode.Text, m_cbbBaoCaoLoai.SelectedItem.ToString());
                frmBC.ShowDialog();
            }
            catch
            {
 
            }
            
        }

        private void m_dgvMain_DoubleClick(object sender, EventArgs e)
        {
            this.XemThongTin();
        }

        private void m_dangXuatbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Dang Xuat?", "Thong Bao", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                this.Hide();
                m_lblID.Text = null;
                m_lblName.Text = null;
                frmDangNhap frmdangNhap = new frmDangNhap();
                frmdangNhap.ShowDialog();
                this.Close();

            }
        }

        private void m_btBaoCao_Click(object sender, EventArgs e)
        {
            XuatBaoCao();
        }

        private void m_ccbPhanQuyen_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (m_ccbPhanQuyen.Text.ToString() == "GVCN")
                m_cbbBoMon.Enabled = false;
            else
                m_cbbBoMon.Enabled = true;

            DesignDataGridView(m_dgvMain, node);
        }

        private void m_cbbBoMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            DesignDataGridView(m_dgvMain, node);
        }

        private void m_cbbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            DesignDataGridView(m_dgvMain, node);
        }

        public static string getnode()
        {
            return node;
        }

        public static string getmagv()
        {
            return m_phanquyen.ID;
        }

        public static int getphanquyen()
        {
            return m_phanquyen.PhanQuyen;
        }

        private void m_cbbBaoCaoLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_dgvMain.DataSource = null;
            switch (m_cbbBaoCaoLoai.SelectedItem.ToString())
            {
                case "In danh sách lớp":
                    m_cbbBaoCaomonhoc.Enabled = false;
                    m_cbbBaoCaohocky.Enabled = false;
                    typebaocao = 0;
                break;

                case "In bảng điểm môn":
                    m_cbbBaoCaomonhoc.Enabled = true;
                    m_cbbBaoCaohocky.Enabled = true;
                    typebaocao = 1;
                break;

                case "In bảng điểm lớp":
                    m_cbbBaoCaomonhoc.Enabled = false;
                    m_cbbBaoCaohocky.Enabled = false;
                    typebaocao = 2;
                break;

                case "In báo cáo tổng kết học kì":
                    m_cbbBaoCaomonhoc.Enabled = false;
                    m_cbbBaoCaohocky.Enabled = true;
                    InBaoCaoTongKetHocKy();
                    typebaocao = 3;
                break;

                case "In báo cáo tổng kêt môn":
                    m_cbbBaoCaomonhoc.Enabled = true;
                    m_cbbBaoCaohocky.Enabled = true;
                    InBaoCaoTongKetMon();
                    typebaocao = 4;
                break;
            }

        }

        private void DesignDataGridView(DataGridView dgv, string node)
        {
            if (m_checkseach)//m_checkseach = true -> dang tim kiem hoc sinh
            {
                dgv.DataSource = hs.TimKiemThongTinHocSinh(FrmMain.m_phanquyen.LopCN, FrmMain.m_phanquyen.PhanQuyen, node);//hs.TimKiemThongTinHocSinh(ma);
                m_checkseach = false;
            }
            else//m_checkseach = false -> dang su dung tree view
            {  
                switch (tabpage)//tabpage se cho biet tabpage nao dang duoc chon
                {
                    case 0://tabpage Ho So

                        if (node.Length == 2)
                            dgv.DataSource = hs.LayHocSinh_Khoi(node, m_phanquyen.ID, m_phanquyen.PhanQuyen);
                        else if (CheckGVInLopBM(node))
                            dgv.DataSource = hs.LayHocSinh_Lop(node, m_phanquyen.ID, m_phanquyen.PhanQuyen);
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
                        if (m_ccbPhanQuyen.Text.ToString() == "GVCN")
                        {
                            dgv.DataSource = hs.LayDiemHocSinh_LopChuNhiem(node, int.Parse(m_cbbNamHoc.SelectedValue.ToString()), m_phanquyen.ID, m_phanquyen.PhanQuyen);
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
                        }
                        else
                        {
                            dgv.DataSource = hs.LayDiemHocSinh_Mon(node, m_cbbBoMon.SelectedValue.ToString(), int.Parse(m_cbbNamHoc.SelectedValue.ToString()), m_phanquyen.ID, m_phanquyen.PhanQuyen);
                            if(dgv.DataSource == null) return;

                            dgv.Columns["STT"].Width = 40;
                            dgv.Columns["MAHS"].Width = 50;
                            dgv.Columns["HOTEN"].Width = 120;
                            dgv.Columns["DIEMTBMONHKI"].Width = 120;
                            dgv.Columns["DIEMTBMONHKII"].Width = 120;

                            dgv.Columns["MAHS"].HeaderText = "Mã học sinh";
                            dgv.Columns["HOTEN"].HeaderText = "Họ và tên";
                            dgv.Columns["DIEMTBMONHKI"].HeaderText = "Điểm TB Môn HKI";
                            dgv.Columns["DIEMTBMONHKII"].HeaderText = "Điểm TB Môn HKII";

                        }
                        break;

                    case 2://tabpage Bao Cao
                        {
                            switch (typebaocao)
                            {
                                case 0:
                                    InDanhSachLop();
                                break;

                                case 1:
                                    InBangDiemChiTietTungHocky();
                                break;

                                case 2:
                                   InBangDiemCuaLop();
                                break;

                                case 3:
                                   
                                break;
                                case 4:
                                   
                                break;

                                default:
                                break;
                            }
                        }
                        break;

                    case 3://tabpage Tra Cuu
                        break;
                }
            }
        }

        private void InDanhSachLop()
        {
            m_dgvMain.DataSource = hs.InDanhSachlop(FrmMain.m_phanquyen.ID, node, FrmMain.m_phanquyen.PhanQuyen);
        }

        private void InBangDiemCuaLop()
        {
            m_dgvMain.DataSource = hs.InBangDiemCuaLop(FrmMain.m_phanquyen.ID, node, FrmMain.m_phanquyen.PhanQuyen, int.Parse(m_cbbBaoCaonamhoc.SelectedValue.ToString()));
        }

        private void InBangDiemChiTietTungHocky()
        {
            int namhoc = int.Parse(m_cbbBaoCaonamhoc.SelectedValue.ToString());
            m_dgvMain.DataSource = hs.InBangDiemChiTietTunghocKy(FrmMain.m_phanquyen.ID, node, m_cbbBaoCaomonhoc.SelectedValue.ToString(), FrmMain.m_phanquyen.PhanQuyen, namhoc, m_cbbBaoCaohocky.SelectedValue.ToString());
        }

        private void InBaoCaoTongKetMon()
        {
            int namhoc = int.Parse(m_cbbBaoCaonamhoc.SelectedValue.ToString());
            m_dgvMain.DataSource = hs.BaoCaoTongKetMon(m_cbbBaoCaomonhoc.SelectedValue.ToString(), FrmMain.m_phanquyen.PhanQuyen, m_cbbBaoCaohocky.SelectedValue.ToString(), namhoc);
        }

        private void InBaoCaoTongKetHocKy()
        {
            int namhoc = int.Parse(m_cbbBaoCaonamhoc.SelectedValue.ToString());
            m_dgvMain.DataSource = hs.BaoCaoTongKetHocKy(FrmMain.m_phanquyen.PhanQuyen, m_cbbBaoCaohocky.SelectedValue.ToString(), namhoc);
        }

        private void m_cbbBaoCaonamhoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void m_cbbBaoCaomonhoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typebaocao == 1)
            {
                int namhoc = int.Parse(m_cbbBaoCaonamhoc.SelectedValue.ToString());
                m_dgvMain.DataSource = hs.InBangDiemChiTietTunghocKy(FrmMain.m_phanquyen.ID, node, m_cbbBaoCaomonhoc.SelectedValue.ToString(), FrmMain.m_phanquyen.PhanQuyen, namhoc, m_cbbBaoCaohocky.SelectedValue.ToString());
            }
            else if (typebaocao == 4)
            {
                int namhoc = int.Parse(m_cbbBaoCaonamhoc.SelectedValue.ToString());
                m_dgvMain.DataSource = hs.BaoCaoTongKetMon(m_cbbBaoCaomonhoc.SelectedValue.ToString(), FrmMain.m_phanquyen.PhanQuyen, m_cbbBaoCaohocky.SelectedValue.ToString(), namhoc);
            }
        }

        private void m_cbbBaoCaohocky_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typebaocao == 1)
            {
                int namhoc = int.Parse(m_cbbBaoCaonamhoc.SelectedValue.ToString());
                m_dgvMain.DataSource = hs.InBangDiemChiTietTunghocKy(FrmMain.m_phanquyen.ID, node, m_cbbBaoCaomonhoc.SelectedValue.ToString(), FrmMain.m_phanquyen.PhanQuyen, namhoc, m_cbbBaoCaohocky.SelectedValue.ToString());
            }
            else if (typebaocao == 4)
            {
                int namhoc = int.Parse(m_cbbBaoCaonamhoc.SelectedValue.ToString());
                m_dgvMain.DataSource = hs.BaoCaoTongKetMon(m_cbbBaoCaomonhoc.SelectedValue.ToString(), FrmMain.m_phanquyen.PhanQuyen, m_cbbBaoCaohocky.SelectedValue.ToString(), namhoc);
            }
            else if (typebaocao == 3)
            {
                int namhoc = int.Parse(m_cbbBaoCaonamhoc.SelectedValue.ToString());
                m_dgvMain.DataSource = hs.BaoCaoTongKetHocKy(FrmMain.m_phanquyen.PhanQuyen, m_cbbBaoCaohocky.SelectedValue.ToString(), namhoc);
            }
        }

        private void m_tcMain_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            m_treeViewKhoi.SelectedNode = null;
        }   

    }
}
