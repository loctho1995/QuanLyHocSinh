
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
        int m_count = 0;
        bool m_checkseach = false;

        public FrmMain()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.CacheText, true);

            InitializeComponent();
            m_treeViewKhoi.ExpandAll(); 

            m_scMain.TextBoxSearch.TextChanged += TextBoxSearch_TextChanged;
            m_dgvMain.BorderStyle = BorderStyle.None;
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
                    return;
            }

            base.WndProc(ref m);
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
                    break;

                default:
                    break;
            }
        }       
        private void m_treeViewKhoi_AfterSelect(object sender, TreeViewEventArgs e)
        {
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

            //MessageBox.Show((e.Node.Name));
        }

        private void DesignDataGridView(DataGridView dgv, string ma)
        {
            if (m_checkseach)
                dgv.DataSource = hs.TimKiemThongTinHocSinh(ma);
            else if (ma.Length == 2)
                dgv.DataSource = hs.LayHocSinh_Khoi(ma);
            else dgv.DataSource = hs.LayHocSinh_Lop(ma);
            dgv.Columns["STT"].Width = 40;
            dgv.Columns["MAHS"].Width = 50;
            dgv.Columns["HOTEN"].Width = 120;
            dgv.Columns["GIOITINH"].Width = 50;
            dgv.Columns["EMAIL"].Width = 120;
            dgv.Columns["MALOP"].Width = 50;
            dgv.Columns["MAKHOILOP"].Width = 40;

            dgv.Columns["MAHS"].HeaderText = "Mã học sinh";
            dgv.Columns["HOTEN"].HeaderText = "Họ và tện";
            dgv.Columns["GIOITINH"].HeaderText = "Giới tính";
            dgv.Columns["EMAIL"].HeaderText = "Email";
            dgv.Columns["DIACHI"].HeaderText = "Địa chỉ";
            dgv.Columns["MALOP"].HeaderText = "Mã lớp";
            dgv.Columns["MAKHOILOP"].HeaderText = "Mã khối";
            dgv.Columns["HOTENCHA"].HeaderText = "Họ tên cha";
            dgv.Columns["HOTENME"].HeaderText = "Họ tên mẹ";
            dgv.Columns["NGHENGHIEPCHA"].HeaderText = "Nghề nghiệp cha";
            dgv.Columns["NGHENGHIEPME"].HeaderText = "Nghề nghiệp mẹ";
            m_checkseach = false;
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

        private void m_dgvMain_Click(object sender, EventArgs e)
        {
            m_count++;

            if(m_count==2)
             this.XemThongTin();
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
                int key = int.Parse(m_dgvMain.SelectedRows[0].Cells["MAHS"].Value.ToString());
                m_dgvMain.Rows.RemoveAt(m_dgvMain.SelectedRows[0].Index);
                if (hs.DeleteHocSinh(key))
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

            m_count = 0;
        }

        private void XemDiem()
        {
            
        }

        private void searchControl1_Load(object sender, EventArgs e)
        {
            
        }

        private void m_dgvMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
    }
}
