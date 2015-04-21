﻿using System;
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

        public HocSinh_BUS()
        {
            if (!SQLDataContext.IsLoaded)
                SQLDataContext.CreateDataContext();
        }

        public List<HOCSINH> LayTatCa()
        {
            return DB.HOCSINHs.ToList();
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

        public int ThemHocSinh(HOCSINH hs, PHANLOP pl)
        {
            try
            {
                
                //var a = DB.sp_ThemHocSinh(hs.MAHS, hs.HOTEN, hs.GIOITINH, hs.NGAYSINH, hs.DIACHI, hs.EMAIL, hs.TONGIAO, hs.HOTENCHAC, hs.NGHENGHIEPCHA, hs.HOTENME, hs.NGHENGHIEPME, pl.MALOP, pl.MANAMHOC, pl.MAKHOI);
                //return int.Parse(a.ToString()) ;
                return 0;
            }
            catch
            {
                return 1;
            }
        }        
    }
}
