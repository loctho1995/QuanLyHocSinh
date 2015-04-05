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
    public partial class frmBaoCao : Form
    {
        HocSinh_BUS hs = new HocSinh_BUS();

        public frmBaoCao(String lop)
        {
            InitializeComponent();
            LoadDataCombobox();
            m_lableLop.Text = lop;
            if (lop != FrmMain.m_phanquyen.LopCN) // Chua co csdl
            {
                m_cbbType.Items.Add("Báo cáo tổng kết học kì");
                m_cbbType.Items.Add("Báo cáo tổng kết môn");
                m_cbbMonHoc.Visible = false;
                m_labelMonHoc.Visible = false;
            }
            else
            {
                m_cbbType.Items.Add("Báo cáo tổng kết môn");
            }


            // Chua co mon hoc

            //for (int i = 0; i < FrmMain.m_phanquyen.MonHoc.Count; i++)
            //{
            //    m_cbbMonHoc.Items.Add(FrmMain.m_phanquyen.MonHoc[i]);
            //}
            //m_cbbMonHoc.SelectedIndex = 0;
           
            WriteData();
        }

        private void m_btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void WriteData()
        {

           //m_data.DataSource = // Dua vao index cua 4 combobox
            
        }

        private void m_cbbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_cbbType.SelectedIndex == 0)
            {
                m_cbbMonHoc.Visible = false;
                m_labelMonHoc.Visible = false;
            }
            else
            {
                m_cbbMonHoc.Visible = true;
                m_labelMonHoc.Visible = true;
            }
            WriteData();
        }

        private void m_cbbHocKi_SelectedIndexChanged(object sender, EventArgs e)
        {
            WriteData();
        }

        private void m_cbbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            WriteData();
        }

        private void m_cbbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            WriteData();
        }

        private void LoadDataCombobox()
        {
            m_cbbNamHoc.DataSource = hs.LayNamHoc();
            m_cbbNamHoc.DisplayMember = "TENNAMHOC";
            m_cbbNamHoc.ValueMember = "TENNAMHOC";

            //insert data for combobox hoc ky
            m_cbbHocKi.DataSource = hs.LayDuLieuHocKy();
            m_cbbHocKi.DisplayMember = "TENHOCKY";
            m_cbbHocKi.ValueMember = "MAHOCKY";

            //insert data for combobox mon hoc
            m_cbbMonHoc.DataSource = hs.LayDuLieuMonHoc();
            m_cbbMonHoc.DisplayMember = "TENMONHOC";
            m_cbbMonHoc.ValueMember = "MAMONHOC";
        }
    }
}
