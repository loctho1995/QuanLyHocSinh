using QuanLyHocSinh.Classes;
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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            m_treeViewKhoi.ExpandAll();
            
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

        private void button_Click(object sender, EventArgs e)
        {
            switch ((sender as Button).Name)
            {
                case "m_btclose":
                   this.Close();
                    break;

                case "m_btSuaDiem":
                    break;

                case "m_btXemThongTin":
                    frmThongTinHS frmTT = new frmThongTinHS();
                    frmTT.Show();
                    break;

                default:
                    break;
            }
        }

        private void m_treeViewKhoi_AfterSelect(object sender, TreeViewEventArgs e)
        {
            MessageBox.Show((e.Node.Name));
        } 
    }
}
