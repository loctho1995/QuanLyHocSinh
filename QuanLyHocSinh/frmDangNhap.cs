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
        string[] malopbomon = null;
        int phanquyen = 0;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void m_dangNhapBtn_Click(object sender, EventArgs e)
        {
            if (Check() == true)
            {
                hs.LayGVBoMon(ref malopbomon, m_tbID.Text.ToUpper());
                this.Hide();
                FrmMain.m_phanquyen.ID = m_tbID.Text.ToUpper();
                FrmMain.m_phanquyen.Username = name;
                FrmMain.m_phanquyen.LopCN = malop.Trim();
                FrmMain.m_phanquyen.PhanQuyen = phanquyen;
                FrmMain.m_phanquyen.LopBM = malopbomon;
                FrmMain frmMain = new FrmMain();
                frmMain.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong hole Mother Fucker!!!");
            }
        }
        //
        private bool Check()
        {
            int x = hs.DangNhap(m_tbID.Text, m_tbPass.Text, ref name, ref malop, ref phanquyen);
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
            this.Hide();
            FrmMain frmMain = new FrmMain();
            frmMain.ShowDialog();
            this.Close();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keydata)
        {
            if (keydata == Keys.Enter)
            {
                if (Check() == true)
                {
                    hs.LayGVBoMon(ref malopbomon, m_tbID.Text.ToUpper());
                    this.Hide();
                    FrmMain.m_phanquyen.ID = m_tbID.Text.ToUpper();
                    FrmMain.m_phanquyen.Username = name;
                    FrmMain.m_phanquyen.LopCN = malop.ToUpper();
                    FrmMain.m_phanquyen.PhanQuyen = phanquyen;
                    FrmMain.m_phanquyen.LopBM = malopbomon;
                    FrmMain frmMain = new FrmMain();
                    frmMain.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Wrong hole Mother Fucker!!!");
                }
                return true;
            }
            else
            {
                return false;
            }

        }

        private void buttonFlat1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
