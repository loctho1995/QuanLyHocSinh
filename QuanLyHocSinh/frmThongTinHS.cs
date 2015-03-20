using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh
{
    public partial class frmThongTinHS : Form
    {
        public static DataGridViewRow m_Row;
        public frmThongTinHS()
        {
            InitializeComponent();
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

        
        private void frmThongTinHS_Load(object sender, EventArgs e)
        {
            m_lblName.Text = m_Row.Cells["HOTEN"].Value.ToString();
            m_lblNgaysinh.Text = m_Row.Cells["NGAYSINH"].Value.ToString();
            m_lblGioitinh.Text = m_Row.Cells["GIOITINH"].Value.ToString();
            m_lblDiachi.Text = m_Row.Cells["DIACHI"].Value.ToString();
            m_lblEmail.Text = m_Row.Cells["EMAIL"].Value.ToString();
            m_lblLop.Text = m_Row.Cells["MALOP"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
