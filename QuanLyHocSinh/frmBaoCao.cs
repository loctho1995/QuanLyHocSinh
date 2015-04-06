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

        public frmBaoCao(String lop, int phanquyen)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    
      
        /*
        private void LoadDataCombobox()
        {
            m_cbbNamHoc.DataSource = hs.LayNamHoc();
            m_cbbNamHoc.DisplayMember = "TENNAMHOC";
            m_cbbNamHoc.ValueMember = "TENNAMHOC";

            //insert data for combobox hoc ky
            m_cbbHocKi.DataSource = hs.LayDuLieuHocKy();
            m_cbbHocKi.DisplayMember = "TENHOCKY";
            m_cbbHocKi.ValueMember = "MAHOCKY";

            //insert data for combobox mon hoc
            m_cbbMonHoc.DataSource = hs.LayDuLieuMonHoc();
            m_cbbMonHoc.DisplayMember = "TENMONHOC";
            m_cbbMonHoc.ValueMember = "MAMONHOC";
        }*/
    }
}
