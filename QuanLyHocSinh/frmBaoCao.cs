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
            m_cbbNamHoc.SelectedIndex = 0;
            m_cbbHocKi.SelectedIndex = 0;

            m_cbbType.SelectedIndex = 0;
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


    }
}
