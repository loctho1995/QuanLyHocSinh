using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;


namespace BUS
{
    public class HocSinh_BUS
    {
        SQL_QUANLYHOCSINHDataContext DB = new SQL_QUANLYHOCSINHDataContext();
        

        public List<HOCSINH> LayTatCa()
        {
            return DB.HOCSINHs.ToList();
        }

        public List<NAMHOC> LayNamHoc()
        {
            return DB.NAMHOCs.ToList();
        }

        public List<MONHOC> LayMonHoc()
        {
            return DB.MONHOCs.ToList();
        }
        public List<HOCKY> LayHocky()
        {
            return DB.HOCKies.ToList();
        }

        public DataTable TimKiemThongTinHocSinh(string malop, int phanquyen, string hoten)
        {
            DataTable dt = new DataTable();
            //dt.Clear();

            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("MAHS", typeof(int));
            dt.Columns.Add("HOTEN", typeof(string));
            dt.Columns.Add("GIOITINH", typeof(string));
            dt.Columns.Add("NGAYSINH", typeof(string));
            dt.Columns.Add("DIACHI", typeof(string));
            dt.Columns.Add("TONGIAO", typeof(string));
            dt.Columns.Add("EMAIL", typeof(string));
            dt.Columns.Add("HOTENCHA", typeof(string));
            dt.Columns.Add("NGHENGHIEPCHA", typeof(string));
            dt.Columns.Add("HOTENME", typeof(string));
            dt.Columns.Add("NGHENGHIEPME", typeof(string));
            dt.Columns.Add("MALOP", typeof(string));
            dt.Columns.Add("MAKHOILOP", typeof(int));

            var hocsinh = DB.sp_TiemKiemHocSinh(malop,phanquyen, hoten);
            int c = 1;

            foreach (var i in hocsinh)
            {
                DataRow r = dt.NewRow();

                r["STT"] = c++;
                r["MAHS"] = i.MAHS;
                r["HOTEN"] = i.HOTEN;
                r["GIOITINH"] = i.GIOITINH;
                r["NGAYSINH"] = i.NGAYSINH;
                r["DIACHI"] = i.DIACHI;
                r["TONGIAO"] = i.TONGIAO;
                r["EMAIL"] = i.EMAIL;
                r["HOTENCHA"] = i.HOTENCHAC;
                r["NGHENGHIEPCHA"] = i.NGHENGHIEPCHA;
                r["HOTENME"] = i.HOTENME;
                r["NGHENGHIEPME"] = i.NGHENGHIEPME;
                r["MALOP"] = i.MALOP;
                r["MAKHOILOP"] = i.MAKHOI;
                dt.Rows.Add(r);
            }

            return dt;
        }

        public DataTable LayHocSinh_Khoi(string makhoilop, string magvcn, int phanquyen)
        {            
            DataTable dt = new DataTable();
            //dt.Clear();

            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("MAHS", typeof(int));
            dt.Columns.Add("HOTEN", typeof(string));
            dt.Columns.Add("GIOITINH", typeof(string));
            dt.Columns.Add("NGAYSINH", typeof(string));
            dt.Columns.Add("DIACHI", typeof(string));
            dt.Columns.Add("TONGIAO", typeof(string));
            dt.Columns.Add("EMAIL", typeof(string));
            dt.Columns.Add("HOTENCHA", typeof(string));
            dt.Columns.Add("NGHENGHIEPCHA", typeof(string));
            dt.Columns.Add("HOTENME", typeof(string));
            dt.Columns.Add("NGHENGHIEPME", typeof(string));
            dt.Columns.Add("MALOP", typeof(string));
            dt.Columns.Add("MAKHOILOP", typeof(int));

            var hocsinh = DB.sp_ThongtinHocSinhtheoKhoi(makhoilop, magvcn, phanquyen);
            int c = 1;

            foreach (var i in hocsinh)
            {
                DataRow r = dt.NewRow();

                r["STT"] = c++;
                r["MAHS"] = i.MAHS;
                r["HOTEN"] = i.HOTEN;
                r["GIOITINH"] = i.GIOITINH;
                r["NGAYSINH"] = i.NGAYSINH;
                r["DIACHI"] = i.DIACHI;
                r["TONGIAO"] = i.TONGIAO;
                r["EMAIL"] = i.EMAIL;
                r["HOTENCHA"] = i.HOTENCHAC;
                r["NGHENGHIEPCHA"] = i.NGHENGHIEPCHA;
                r["HOTENME"] = i.HOTENME;
                r["NGHENGHIEPME"] = i.NGHENGHIEPME;
                r["MALOP"] = i.MALOP;
                r["MAKHOILOP"] = i.MAKHOI;

                dt.Rows.Add(r);
            }
            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }

        public DataTable LayHocSinh_Lop(string malop, string magvcn, int phanquyen)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("MAHS", typeof(int));
            dt.Columns.Add("HOTEN", typeof(string));
            dt.Columns.Add("GIOITINH", typeof(string));
            dt.Columns.Add("NGAYSINH", typeof(string));
            dt.Columns.Add("DIACHI", typeof(string));
            dt.Columns.Add("TONGIAO", typeof(string));
            dt.Columns.Add("EMAIL", typeof(string));
            dt.Columns.Add("HOTENCHA", typeof(string));
            dt.Columns.Add("NGHENGHIEPCHA", typeof(string));
            dt.Columns.Add("HOTENME", typeof(string));
            dt.Columns.Add("NGHENGHIEPME", typeof(string));
            dt.Columns.Add("MALOP", typeof(string));
            dt.Columns.Add("MAKHOILOP", typeof(int));

            var hocsinh = DB.sp_ThongtinHocSinhtheoLop(malop,magvcn,phanquyen);
            int c = 1;

            foreach (var i in hocsinh)
            {
                DataRow r = dt.NewRow();

                r["STT"] = c++;
                r["MAHS"] = i.MAHS;
                r["HOTEN"] = i.HOTEN;
                r["GIOITINH"] = i.GIOITINH;
                r["NGAYSINH"] = i.NGAYSINH;
                r["DIACHI"] = i.DIACHI;
                r["TONGIAO"] = i.TONGIAO;
                r["EMAIL"] = i.EMAIL;
                r["HOTENCHA"] = i.HOTENCHAC;
                r["NGHENGHIEPCHA"] = i.NGHENGHIEPCHA;
                r["HOTENME"] = i.HOTENME;
                r["NGHENGHIEPME"] = i.NGHENGHIEPME;
                r["MALOP"] = i.MALOP;
                r["MAKHOILOP"] = i.MAKHOI;

                dt.Rows.Add(r);
            }
            if (dt.Rows.Count == 0)
                return null;
            return dt;
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

            var hocsinh = DB.sp_DiemHocSinhTheoLopChuNhiem(malop, namhoc, magvcn, phanquyen);
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

            var diem = DB.sp_DiemHocSinh(mahs, namhoc, hocky);

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

            var diem = DB.sp_DiemHocSinhTheoLopBoMon(malop, mamon, namhoc, magv, phanquyen);
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

            var diem = DB.sp_Diem1HocSinhTheoBoMon(mahs, mamon, namhoc, magv, phanquyen);
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

        public List<HOCKY> LayDuLieuHocKy()
        {
            return DB.HOCKies.ToList();
        }
        public List<MONHOC> LayDuLieuMonHoc()
        {
            return DB.MONHOCs.ToList();
        }
        //SUA DIEM
        public bool SuaDiem(int mahs, string malop, string mamon, int namhoc, float d_mieng_hkI, float d_15p_hkI, float d_1tiet_hkI, float d_thi_hkI, float d_mieng_hkII, float d_15p_hkII, float d_1tiet_hkII, float d_thi_hkII)
        {
            try
            {
                DB.sp_SuaDiem(mahs, malop, mamon, namhoc, d_mieng_hkI, d_15p_hkI, d_1tiet_hkI, d_thi_hkI, d_mieng_hkII, d_15p_hkII, d_1tiet_hkII, d_thi_hkII);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteHocSinh(int mahs)
        {
            try
            {
                DB.sp_XoathongtinHocSinh(mahs);
                return true;
            }
            catch
            {
                return false;
            }

        }
        public bool UpdateHocSinh(HOCSINH hs, PHANLOP pl)
        {
            try
            {
                DB.sp_SuaThongtinHocSinh(hs.MAHS, hs.HOTEN, hs.GIOITINH, hs.NGAYSINH, hs.DIACHI, hs.EMAIL, hs.TONGIAO, hs.HOTENCHAC, hs.NGHENGHIEPCHA, hs.HOTENME, hs.NGHENGHIEPME, pl.MALOP);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<LOP> LayDuLieuLop(string magvcn)
        {
            List<LOP> l = new List<LOP>();
            return DB.LOPs.Where(a => a.MAGVCN == magvcn).ToList();
        }

        public int ThemHocSinh(HOCSINH hs, PHANLOP pl)
        {
            try
            {
                
                var a = DB.sp_ThemHocSinh(hs.MAHS, hs.HOTEN, hs.GIOITINH, hs.NGAYSINH, hs.DIACHI, hs.EMAIL, hs.TONGIAO, hs.HOTENCHAC, hs.NGHENGHIEPCHA, hs.HOTENME, hs.NGHENGHIEPME, pl.MALOP, pl.MANAMHOC, pl.MAKHOI);
                return int.Parse(a.ToString()) ;
            }
            catch
            {
                return 1;
            }
        }        
        //phân quyền đăng nhập
        public int DangNhap(string user, string pass,ref string name, ref string malop,ref int phanquyen)
        {
            int? m_check = 0, m_temp = 0;
            try
            {
                DB.sp_DangNhap(user, pass, ref m_check, ref name, ref malop, ref m_temp);
                phanquyen = int.Parse(m_temp.ToString());
                return int.Parse(m_check.ToString());
            }
            catch
            {
                return int.Parse(m_check.ToString());
            }
        }
        public void LayGVBoMon(ref string[] malop, string id)
        {
            int m_count = 0;
            string[] malopbomon = new string[10];
            try
            {
                var malopgvbomon = DB.sp_LayGVBoMon(id);
                foreach (var i in malopgvbomon)
                    malopbomon[m_count++] = i.MALOP;
                malop = new string[m_count];
                for (int i = 0; i <= m_count; i++)
                    malop[i] = malopbomon[i];
                    if (m_count == 0)
                        malopbomon = null;
            }
            catch
            {
                return;
            }
        }
        public DataTable InDanhSachlop(string magv, string malop, int phanquyen)
        {
            DataTable dt = new DataTable();
            //dt.Clear();

            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("MAHS", typeof(int));
            dt.Columns.Add("HOTEN", typeof(string));
            dt.Columns.Add("GIOITINH", typeof(string));
            dt.Columns.Add("NGAYSINH", typeof(string));
            dt.Columns.Add("DIACHI", typeof(string));
            dt.Columns.Add("EMAIL", typeof(string));

            var hocsinh = DB.sp_BaoCaoLayDanhSachLop(magv, malop, phanquyen);
            int c = 1;

            foreach (var i in hocsinh)
            {
                DataRow r = dt.NewRow();

                r["STT"] = c++;
                r["MAHS"] = i.MAHS;
                r["HOTEN"] = i.HOTEN;
                r["GIOITINH"] = i.GIOITINH;
                r["NGAYSINH"] = i.NGAYSINH;
                r["DIACHI"] = i.DIACHI;
                r["EMAIL"] = i.EMAIL;
                dt.Rows.Add(r);
            }
            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }
        public DataTable InBangDiemCuaLop(string magv, string malop, int phanquyen, int namhoc)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("MAHS", typeof(int));
            dt.Columns.Add("HOTEN", typeof(string));
            dt.Columns.Add("DIEMTBMONHKI");
            dt.Columns.Add("DIEMTBMONHKII");
            dt.Columns.Add("DIEMTBCANAM");

            var diem = DB.sp_BaoCaoLayBangDiemCuaLop(magv, malop, phanquyen, namhoc);
            int c = 1;

            foreach (var i in diem)
            {
                DataRow r = dt.NewRow();

                r["STT"] = c++;
                r["MAHS"] = i.MAHS;
                r["HOTEN"] = i.HOTEN;
                r["DIEMTBMONHKI"] = i.DIEMTBHKI;
                r["DIEMTBMONHKII"] = i.DIEMTBHKII;
                r["DIEMTBCANAM"] = i.DIEMTBCANAM;

                dt.Rows.Add(r);
            }

            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }
        public DataTable InBangDiemChiTietTunghocKy(string magv, string malop, string mamon, int phanquyen, int namhoc, string hocky)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("MAHS", typeof(int));
            dt.Columns.Add("HOTEN", typeof(string));
            dt.Columns.Add("D_MIENG_HKI", typeof(float));
            dt.Columns.Add("D_15P_HKI", typeof(float));
            dt.Columns.Add("D_1TIET_HKI", typeof(float));
            dt.Columns.Add("D_THI_HKI", typeof(float));
            dt.Columns.Add("D_TBMON_HKI", typeof(float));

            try
            {
                var diem = DB.sp_BaoCaoBangDiemChiTietTungHocKy(magv, malop, mamon, phanquyen, namhoc, hocky);
                int c = 1;
                foreach (var i in diem)
                {
                    DataRow r = dt.NewRow();

                    r["STT"] = c++;
                    r["MAHS"] = i.MAHS;
                    r["HOTEN"] = i.HOTEN;
                    r["D_MIENG_HKI"] = i.DIEMMIENG;
                    r["D_15P_HKI"] = i.DIEM15PHUT;
                    r["D_1TIET_HKI"] = i.DIEM1TIET;
                    r["D_THI_HKI"] = i.DIEMTHI;
                    r["D_TBMON_HKI"] = i.DIEMTBHOCKY;
                    dt.Rows.Add(r);
                }
                if (dt.Rows.Count == 0)
                    return null;
                return dt;
            }
            catch
            {
                return null;
            }
        }
        public DataTable BaoCaoTongKetMon(string mamon, int phanquyen, string mahocki, int manamhoc)
        {
            int siso = 1, soluongdat = 0;
            DataTable dt = new DataTable();
            dt.Columns.Add("STT",typeof(int));
            dt.Columns.Add("LOP", typeof(string));
            dt.Columns.Add("SISO", typeof(int));
            dt.Columns.Add("SOLUONGDAT", typeof(int));
            dt.Columns.Add("TILE");

            var diem = DB.sp_BaoCaoTongKetMon(mamon, phanquyen, mahocki, manamhoc);
            int c = 1;
            foreach (var i in diem)
            {
                DataRow r = dt.NewRow();

                r["STT"] = c++;
                r["LOP"] = i.MALOP;
                r["SISO"] = i.SISO;
                r["SOLUONGDAT"] = i.SOLUONGDAT;
                siso = int.Parse(i.SISO.ToString());
                soluongdat = int.Parse(i.SOLUONGDAT.ToString());
                r["TILE"] = ((float)soluongdat/siso*100).ToString()+" %";
                dt.Rows.Add(r);
            }

            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }
        public DataTable BaoCaoTongKetHocKy(int phanquyen, string mahocki, int manamhoc)
        {
            int siso = 1, soluongdat = 0;
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("LOP", typeof(string));
            dt.Columns.Add("SISO", typeof(int));
            dt.Columns.Add("SOLUONGDAT", typeof(int));
            dt.Columns.Add("TILE");

            var diem = DB.sp_BaoCaoTongKetHocKy(phanquyen, mahocki, manamhoc);
            int c = 1;
            foreach (var i in diem)
            {
                DataRow r = dt.NewRow();

                r["STT"] = c++;
                r["LOP"] = i.MALOP;
                r["SISO"] = i.SISO;
                r["SOLUONGDAT"] = i.SOLUONGDAT;
                siso = int.Parse(i.SISO.ToString());
                soluongdat = int.Parse(i.SOLUONGDAT.ToString());
                r["TILE"] = ((float)soluongdat / siso * 100).ToString() + " %";
                dt.Rows.Add(r);
            }

            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }
    }
}
