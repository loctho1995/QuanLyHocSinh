using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh
{
    public partial class frmSuaNhapHS : Form
    {
        public frmSuaNhapHS()
        {
            InitializeComponent();
        }

        public frmSuaNhapHS(DataGridViewRow row)
        {
            InitializeComponent();
            m_tbDiaChi.Text = row.Cells["DIACHI"].Value.ToString();
            m_tbEmail.Text = row.Cells["EMAIL"].Value.ToString();
            m_tbGioiTinh.Text = row.Cells["GIOITINH"].Value.ToString();
            m_tbHoVaTen.Text = row.Cells["HOTEN"].Value.ToString();
            m_tbLop.Text = row.Cells["MALOP"].Value.ToString();
            m_tbNgaySinh.Text = row.Cells["NGAYSINH"].Value.ToString();
        }

        private void frmSuaNhapHS_Load(object sender, EventArgs e)
        {

        }

        private void m_btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_btHoanTat_Click(object sender, EventArgs e)
        {

        }

        private bool CheckEmail(string input)
        {
            string strRegex = @"\w*@";//@"\w+([.]\w+)*@\w+([_.]\w+)*\.\w+([_.]\w+)*"; 

            Regex rg = new Regex(strRegex);

            if (rg.IsMatch(input))
                return true;

            return false;
        }

        private void m_tbEmail_TextChanged(object sender, EventArgs e)
        {
            if (!CheckEmail(m_tbEmail.Text))
            {
                m_tbEmail.ForeColor = Color.Red;
            }
            else
            {
                m_tbEmail.ForeColor = Color.Black;
            }
        }
    }
}
