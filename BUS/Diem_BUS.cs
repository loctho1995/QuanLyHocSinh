using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Diem_BUS
    {
        public Diem_BUS()
        {
            if (!SQLDataContext.IsLoaded)
                SQLDataContext.CreateDataContext();
        }

        //Lay diem hoc sinh theo lop chu nhiem
        public DataTable LayDiemHocSinh_LopChuNhiem(string malop, int namhoc, string magvcn, int phanquyen)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("MAHS", typeof(int));
            dt.Columns.Add("HOTEN", typeof(string));
            dt.Columns.Add("DIEMTBHKI", typeof(float));
            dt.Columns.Add("DIEMTBHKII", typeof(float));
            dt.Columns.Add("DIEMTBCANAM", typeof(float));
            dt.Columns.Add("MANAMHOC", typeof(int));

            var hocsinh = SQLDataContext.SQLData.sp_DiemHocSinhTheoLopChuNhiem(malop, namhoc, magvcn, phanquyen);
            int c = 1;

            foreach (var i in hocsinh)
            {
                DataRow r = dt.NewRow();
                r["STT"] = c++;
                r["MAHS"] = i.MAHS;
                r["HOTEN"] = i.HOTEN;
                r["DIEMTBHKI"] = i.DIEMTBHKI;
                r["DIEMTBHKII"] = i.DIEMTBHKII;
                r["DIEMTBCANAM"] = i.DIEMTBCANAM;

                dt.Rows.Add(r);
            }

            if (dt.Rows.Count == 0)
                return null;
            return dt;

        }

        //lay diem 1 hoc sinh tren tat ca cac mon
        public DataTable LayDiemHocSinh_AllMon(int mahs, int namhoc, string hocky)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MON", typeof(string));
            dt.Columns.Add("DIEMMIENG", typeof(float));
            dt.Columns.Add("DIEM15P", typeof(float));
            dt.Columns.Add("DIEM1TIET", typeof(float));
            dt.Columns.Add("DIEMTHI", typeof(float));
            dt.Columns.Add("DIEMTBMON", typeof(float));

            var diem = SQLDataContext.SQLData.sp_DiemHocSinh(mahs, namhoc, hocky);

            foreach (var i in diem)
            {
                DataRow r = dt.NewRow();
                r["MON"] = i.TENMONHOC;
                r["DIEMMIENG"] = i.DIEMMIENG;
                r["DIEM15P"] = i.DIEM15P;
                r["DIEM1TIET"] = i.DIEM1TIET;
                r["DIEMTHI"] = i.DIEMTHI;
                r["DIEMTBMON"] = i.DIEMTBMON;

                dt.Rows.Add(r);
            }

            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }

        //lay diem theo tung mon
        public DataTable LayDiemHocSinh_Mon(string malop, string mamon, int namhoc, string magv, int phanquyen)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT");
            dt.Columns.Add("MAHS");
            dt.Columns.Add("HOTEN");
            dt.Columns.Add("DIEMTBMONHKI");
            dt.Columns.Add("DIEMTBMONHKII");

            var diem = SQLDataContext.SQLData.sp_DiemHocSinhTheoLopBoMon(malop, mamon, namhoc, magv, phanquyen);
            int c = 1;

            foreach (var i in diem)
            {
                DataRow r = dt.NewRow();

                r["STT"] = c++;
                r["MAHS"] = i.MAHS;
                r["HOTEN"] = i.HOTEN;
                r["DIEMTBMONHKI"] = i.DIEMTBMONHKI;
                r["DIEMTBMONHKII"] = i.DIEMTBMONHKII;

                dt.Rows.Add(r);
            }

            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }

        public DataTable LayDiem1HocSinh_Mon(int mahs, string mamon, int namhoc, string magv, int phanquyen)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("D_MIENG_HKI", typeof(float));
            dt.Columns.Add("D_15P_HKI", typeof(float));
            dt.Columns.Add("D_1TIET_HKI", typeof(float));
            dt.Columns.Add("D_THI_HKI", typeof(float));
            dt.Columns.Add("D_TBMON_HKI", typeof(float));
            dt.Columns.Add("D_MIENG_HKII", typeof(float));
            dt.Columns.Add("D_15P_HKII", typeof(float));
            dt.Columns.Add("D_1TIET_HKII", typeof(float));
            dt.Columns.Add("D_THI_HKII", typeof(float));
            dt.Columns.Add("D_TBMON_HKII", typeof(float));

            var diem = SQLDataContext.SQLData.sp_Diem1HocSinhTheoBoMon(mahs, mamon, namhoc, magv, phanquyen);
            //var diem = DB.sp_Diem1HocSinhTheoBoMon("1", "MH0001", "2014", "gv001", 0);
            foreach (var i in diem)
            {
                DataRow r = dt.NewRow();

                r["D_MIENG_HKI"] = i.D_MIENGHKI;
                r["D_15P_HKI"] = i.D_15PHKI;
                r["D_1TIET_HKI"] = i.D_1TIETHKI;
                r["D_THI_HKI"] = i.D_THIHKI;
                r["D_TBMON_HKI"] = i.D_TBMONHKI;

                r["D_MIENG_HKII"] = i.D_MIENGHKII;
                r["D_15P_HKII"] = i.D_15PHKII;
                r["D_1TIET_HKII"] = i.D_1TIETHKII;
                r["D_THI_HKII"] = i.D_THIHKII;
                r["D_TBMON_HKII"] = i.D_TBMONHKII;

                dt.Rows.Add(r);
            }

            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }

        public bool SuaDiem(int mahs, string malop, string mamon, int namhoc, float d_mieng_hkI, float d_15p_hkI, float d_1tiet_hkI, float d_thi_hkI, float d_mieng_hkII, float d_15p_hkII, float d_1tiet_hkII, float d_thi_hkII)
        {
            try
            {
                SQLDataContext.SQLData.sp_SuaDiem(mahs, malop, mamon, namhoc, d_mieng_hkI, d_15p_hkI, d_1tiet_hkI, d_thi_hkI, d_mieng_hkII, d_15p_hkII, d_1tiet_hkII, d_thi_hkII);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
