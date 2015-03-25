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
    public partial class frmDangNhap : Form
    {
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
                FrmMain frmMain = new FrmMain();
                frmMain.ShowDialog();
                //this.Close();
            }
            else 
            {
                MessageBox.Show("Wrong hole Mother Fucker!!!");
            }
        }
        private bool Check()
        {
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
