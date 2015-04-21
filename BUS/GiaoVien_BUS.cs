using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class GiaoVien_BUS
    {
        public GiaoVien_BUS()
        {
            if (!SQLDataContext.IsLoaded)
                SQLDataContext.CreateDataContext();
        }

        public void LayGVBoMon(ref string[] malop, string id)
        {
            int m_count = 0;
            string[] malopbomon = new string[10];
            try
            {
                var malopgvbomon = SQLDataContext.SQLData.sp_LayGVBoMon(id);
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
