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
        bool firstload = true;
        


        public frmXemDiem(DataGridViewRow row)
        {
            InitializeComponent();
            //m_maHS = maHS;
            //m_maGV = maGV;
            m_row = row;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmXemDiem_Load(object sender, EventArgs e)
        {
            m_cbbHocKi.Items.Add(1);
            m_cbbHocKi.Items.Add(2);

            m_lbMaHS.Text = m_row.Cells["MAHS"].Value.ToString();
            m_lbTenHS.Text = m_row.Cells["HOTEN"].Value.ToString();
            //foreach (var i in hs.LayNamHoc())
            //{
            //    m_cbbNamHoc.Items.Add(i.MANAMHOC);
            //}
            //m_cbbNamHoc.SelectedIndex = 0;

            m_lbLop.Text = FrmMain.getnode();

            m_cbbNamHoc.DataSource = hs.LayNamHoc();
            m_cbbNamHoc.DisplayMember = "TENNAMHOC";
            m_cbbNamHoc.ValueMember = "MANAMHOC";

            m_cbbHocKi.SelectedIndex = 0;

            m_dgvMain.DataSource = hs.LayDiemHocSinh_AllMon(int.Parse(m_lbMaHS.Text.ToString()), int.Parse(m_cbbNamHoc.SelectedValue.ToString()), m_cbbHocKi.Text.ToString());
            firstload = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_cbbHocKi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!firstload)
            m_dgvMain.DataSource = hs.LayDiemHocSinh_AllMon(int.Parse(m_lbMaHS.Text.ToString()), int.Parse(m_cbbNamHoc.SelectedValue.ToString()), m_cbbHocKi.Text.ToString());
        }

        private void m_cbbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!firstload)
                m_dgvMain.DataSource = hs.LayDiemHocSinh_AllMon(int.Parse(m_lbMaHS.Text.ToString()), int.Parse(m_cbbNamHoc.SelectedValue.ToString()), m_cbbHocKi.Text.ToString());
        }
    }
}
