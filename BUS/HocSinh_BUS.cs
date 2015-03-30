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

        public DataTable TimKiemThongTinHocSinh(string hoten)
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

            var hocsinh = DB.sp_TiemKiemHocSinh(hoten);
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
                r["MAKHOILOP"] = i.MAKHOILOP;

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
                r["MAKHOILOP"] = i.MAKHOILOP;

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
                r["MAKHOILOP"] = i.MAKHOILOP;

                dt.Rows.Add(r);
            }
            if (dt.Rows.Count == 0)
                return null;
            return dt;
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
                
                var a = DB.sp_ThemHocSinh(hs.MAHS, hs.HOTEN, hs.GIOITINH, hs.NGAYSINH, hs.DIACHI, hs.EMAIL, hs.TONGIAO, hs.HOTENCHAC, hs.NGHENGHIEPCHA, hs.HOTENME, hs.NGHENGHIEPME, pl.MALOP, pl.MANAMHOC, pl.MAKHOILOP);
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
            int? m_check = 2, m_temp = 0;
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

    }
}
