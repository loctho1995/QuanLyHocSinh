using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh
{
    [Serializable]
    public class FlatTabPage
    {
        public FlatTabPage()
        {
            BackColor = Color.Aqua;
            Text = "flatTabPage";
            FontText = new Font("Tahoma", 12);
            TextColor = Color.Black;
        }

        public int Width
        { get; set; }

        public Color BackColor
        { get; set; }

        public String Text
        { get; set; }

        public Font FontText
        { get; set; }

        public Color TextColor
        { get; set; }
    }
}
