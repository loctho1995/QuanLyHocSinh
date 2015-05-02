using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;

namespace QuanLyHocSinh
{
    public partial class frmGiaoVien : Form
    {
        private GIAOVIEN giaovien;
        private USER user;
        private int type = 0;
        public frmGiaoVien()
        {
            InitializeComponent();
        }

        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            m_dgvGV.DataSource = DataBase.GiaoVien.LoadDuLieuGiaoVien();
        }

        private void m_dgvGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (m_dgvGV.SelectedRows[0] != null)
            {
                DeleteTextBox();
                DataGridViewRow row = m_dgvGV.SelectedRows[0];
                m_txtMaGV.Text = row.Cells["MAGV"].Value.ToString();
                if (row.Cells["HOTEN"].Value!=null)
                    m_txtHoten.Text = row.Cells["HOTEN"].Value.ToString();
                if (row.Cells["GIOITINH"].Value != null)
                {
                    if (row.Cells["GIOITINH"].Value.ToString()=="Nam")
                        m_cbbGioitinh.SelectedIndex = 0;
                    else
                        m_cbbGioitinh.SelectedIndex = 1;
                }
                if (row.Cells["SODT"].Value!=null)
                    m_txtSoDT.Text = row.Cells["SODT"].Value.ToString();
                if (row.Cells["NGAYSINH"].Value!=null)
                    m_dtpNgaysinh.Text = row.Cells["NGAYSINH"].Value.ToString();
            }
        }

        private void DeleteTextBox()
        {
            m_txtMaGV.Text = "";
            m_txtHoten.Text = "";
            m_txtPass.Text = "";
            m_txtSoDT.Text = "";
            m_dtpNgaysinh.Text = "";
        }

        private void m_btnThem_Click(object sender, EventArgs e)
        {
            m_btnLuu.Enabled = true;
            DeleteTextBox();
        }

        private void m_txtMaGV_TextChanged(object sender, EventArgs e)
        {
            m_txtDangnhap.Text = m_txtMaGV.Text;
        }

        private void m_btnTaoTK_Click(object sender, EventArgs e)
        {
            type = 1;
            InsertDuLieu();
            type = 0;
        }

        private void m_btnLuu_Click(object sender, EventArgs e)
        {
            InsertDuLieu();
        }
        private void InsertDuLieu()
        {
            if (m_txtMaGV.Text == "")
            {
                MessageBox.Show("Thông tin trống", "Thông báo!");
                return;
            }
            giaovien = new GIAOVIEN();
            giaovien.MAGV = m_txtMaGV.Text;
            giaovien.HOTEN = m_txtHoten.Text;
            giaovien.GIOITINH = m_cbbGioitinh.SelectedItem.ToString();
            giaovien.SODT = m_txtSoDT.Text;
            giaovien.NGAYSINH = DateTime.Parse(m_dtpNgaysinh.Text);
            user = new USER();
            user.PASSWORD = m_txtPass.Text;
            user.EMAIL = m_txtEmail.Text;
            if (m_cbbPhanquyen.SelectedItem.ToString() != "")
                user.PHANQUYEN = int.Parse(m_cbbPhanquyen.SelectedItem.ToString());
            if (DataBase.GiaoVien.InsertDuLieuGV(giaovien, user, type))
            {
                MessageBox.Show("Thành công", "Thông báo");
                LoadData();
                return;
            }
            MessageBox.Show("Thất bại", "Thông báo");
        }
        private void m_btnXoa_Click(object sender, EventArgs e)
        {
            if (m_txtMaGV.Text == "")
            {
                MessageBox.Show("Thông tin trống", "Thông báo!");
                return;
            }
            giaovien = new GIAOVIEN();
            giaovien.MAGV = m_txtMaGV.Text;
            if (DataBase.GiaoVien.DeleteDuLieuGV(giaovien.MAGV))
            {
                MessageBox.Show("Thành công", "Thông báo");
                LoadData();
                return;
            }
            MessageBox.Show("Thất bại", "Thông báo");
        }

        private void m_btnSua_Click(object sender, EventArgs e)
        {
            if (m_txtMaGV.Text == "")
            {
                MessageBox.Show("Thông tin trống", "Thông báo!");
                return;
            }
            giaovien = new GIAOVIEN();
            giaovien.MAGV = m_txtMaGV.Text;
            giaovien.HOTEN = m_txtHoten.Text;
            giaovien.GIOITINH = m_cbbGioitinh.SelectedItem.ToString();
            giaovien.SODT = m_txtSoDT.Text;
            giaovien.NGAYSINH = DateTime.Parse(m_dtpNgaysinh.Text);
            user = new USER();
            user.PASSWORD = m_txtPass.Text;
            user.EMAIL = m_txtEmail.Text;
            if (m_cbbPhanquyen.SelectedItem.ToString() != "")
                user.PHANQUYEN = int.Parse(m_cbbPhanquyen.SelectedItem.ToString());
            if (DataBase.GiaoVien.UpdateDuLieuGV(giaovien, user))
            {
                MessageBox.Show("Thành công", "Thông báo");
                LoadData();
                return;
            }
            MessageBox.Show("Thất bại", "Thông báo");
        }


    }
}
