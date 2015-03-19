using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh.Classes
{
    public class HocSinh
    {
        #region - Attributes -
        string hoten;
        #endregion
        public HocSinh()
        {
            
        }

        /// <summary>
        /// Họ và tên của học sinh
        /// </summary>
        public string HoTen
        { get; set; }

        /// <summary>
        /// Địa chỉ của học sinh
        /// </summary>
        public string DiaChi
        { get; set; }

        public string HoTenMe
        { get; set; }

        public string NgheNghiepMe
        { get; set; }

        public string HoTenCha
        { get; set; }

        public string NgheNghiepCha
        { get; set; }

        public string Email
        { get; set; }

        public string DanToc
        { get; set; }

        public string TonGiao
        { get; set; }


    }
}
