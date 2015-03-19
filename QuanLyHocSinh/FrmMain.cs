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
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
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
                    if (MessageBox.Show("Sure Mother fucker?", "Quit", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
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
            switch (e.Node.Name)
            {
                //Click vào node khối
                case "m_nodeKhoi":
                    break;

                //Click vào Node Khối 10
                case "m_nodeKhoi10":

                    break;

                //Click vào Node khối 11
                case "m_nodeKhoi11":

                    break;

                //Click vào Node khối 11
                case "m_nodeKhoi12":

                    break;

                case "m_node10A1":
                    break;

                case "m_node10A2":
                    break;

                case "m_node10A3":
                    break;

                case "m_node10A4":
                    break;

                case "m_node11A1":
                    break;

                case "m_node11A2":
                    break;

                case "m_node11A3":
                    break;

                case "m_node12A1":
                    break;

                case "m_node12A2":
                    break;

                default:
                    break;
            }

            //MessageBox.Show((e.Node.Name));
        }

        //Resize control khi form Resize
        private void FrmMain_Resize(object sender, EventArgs e)
        {
            //m_treeViewKhoi.Size = new Size(m_treeViewKhoi.Width, this.Height - m_treeViewKhoi.Location.Y);
            //m_dgwMain.Size = new Size(this.Width - m_dgwMain.Location.X, this.Height - m_dgwMain.Location.Y);
        } 
    }
}
