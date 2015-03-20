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
        public DataTable LayHocSinh_Khoi(string makhoilop)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("MAHS", typeof(int));
            dt.Columns.Add("HOTEN", typeof(string));
            dt.Columns.Add("GIOITINH", typeof(string));
            dt.Columns.Add("NGAYSINH", typeof(string));
            dt.Columns.Add("DIACHI", typeof(string));
            dt.Columns.Add("EMAIL", typeof(string));
            dt.Columns.Add("MALOP", typeof(string));
            dt.Columns.Add("MAKHOILOP", typeof(int));
            var hocsinh = (from hs in DB.HOCSINHs
                            join pl in DB.PHANLOPs.Where(p => p.MAKHOILOP == makhoilop)
                            on hs.MAHS equals pl.MAHS
                            select new
                            {
                                hs.MAHS,
                                hs.HOTEN,
                                hs.GIOITINH,
                                hs.NGAYSINH,
                                hs.DIACHI,
                                hs.EMAIL,
                                pl.MALOP,
                                pl.MAKHOILOP
                            }).ToList();
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
                r["MALOP"] = i.MALOP;
                r["MAKHOILOP"] = i.MAKHOILOP;
                dt.Rows.Add(r);
            }
            return dt;
        }
        public DataTable LayHocSinh_Lop(string malop)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("MAHS", typeof(int));
            dt.Columns.Add("HOTEN", typeof(string));
            dt.Columns.Add("GIOITINH", typeof(string));
            dt.Columns.Add("NGAYSINH", typeof(string));
            dt.Columns.Add("DIACHI", typeof(string));
            dt.Columns.Add("EMAIL", typeof(string));
            dt.Columns.Add("MALOP", typeof(string));
            dt.Columns.Add("MAKHOILOP", typeof(int));
            var hocsinh = (from hs in DB.HOCSINHs
                           join pl in DB.PHANLOPs.Where( p => p.MALOP == malop)
                           on hs.MAHS equals pl.MAHS
                           select new
                           {
                               hs.MAHS,
                               hs.HOTEN,
                               hs.GIOITINH,
                               hs.NGAYSINH,
                               hs.DIACHI,
                               hs.EMAIL,
                               pl.MALOP,
                               pl.MAKHOILOP
                           }).ToList();
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
                r["MALOP"] = i.MALOP;
                r["MAKHOILOP"] = i.MAKHOILOP;
                dt.Rows.Add(r);
            }
            return dt;
        }
    }
}
