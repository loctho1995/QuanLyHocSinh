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
    public partial class frmXemDiem : Form
    {
        //int m_maHS;
        //string m_maGV;
        DataGridViewRow m_row;
        HocSinh_BUS hs = new HocSinh_BUS();
        


        public frmXemDiem(DataGridViewRow row)
        {
            InitializeComponent();
            //m_maHS = maHS;
            //m_maGV = maGV;
            m_row = row;
            m_cbbHocKi.Items.Add(1);
            m_cbbHocKi.Items.Add(2);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmXemDiem_Load(object sender, EventArgs e)
        {
            m_lbMaHS.Text = m_row.Cells["MAHS"].Value.ToString();
            m_lbTenHS.Text = m_row.Cells["HOTEN"].Value.ToString();
            foreach (var i in hs.LayNamHoc())
            {
                m_cbbNamHoc.Items.Add(i.MANAMHOC.ToString());
            }
            m_cbbNamHoc.Text = m_row.Cells["MANAMHOC"].Value.ToString();
            m_cbbHocKi.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_cbbHocKi_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_dgvMain.DataSource = hs.LayDiemHocSinh_Mon(m_lbMaHS.Text.ToString(), m_cbbNamHoc.Text.ToString(), m_cbbHocKi.Text.ToString());
        }

        private void m_cbbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_dgvMain.DataSource = hs.LayDiemHocSinh_Mon(m_lbMaHS.Text.ToString(), m_cbbNamHoc.Text.ToString(), m_cbbHocKi.Text.ToString());
        }
    }
}
