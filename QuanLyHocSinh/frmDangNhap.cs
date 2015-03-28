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
    public partial class frmDangNhap : Form
    {
        HocSinh_BUS hs = new HocSinh_BUS();
        string name = null, malop = null;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void m_dangNhapBtn_Click(object sender, EventArgs e)
        {
            if (Check() == true)
            {
                FrmMain.m_phanquyen.ID = m_tbID.Text.ToUpper();
                FrmMain.m_phanquyen.Username = name;
                FrmMain.m_phanquyen.LopCN = malop.ToUpper();
                FrmMain frmMain = new FrmMain();
                frmMain.ShowDialog();
                this.Close();
            }
            else 
            {
                MessageBox.Show("Wrong hole Mother Fucker!!!");
               
            }
        }
        private bool Check()
        {
            int x = hs.DangNhap(m_tbID.Text, m_tbPass.Text,ref name, ref malop);
            if (x == 1)
                return true;
            else if (x == 2)
            {
                malop = "Trống";
                return true;
            }
            return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmMain frmMain = new FrmMain();
            frmMain.ShowDialog();
            this.Close();
        }
    }
}
