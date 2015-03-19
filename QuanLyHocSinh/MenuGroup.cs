using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace QuanLyHocSinh
{
    public partial class MenuGroup : UserControl
    {        
        private List<MenuGroupItem> m_listItems;

        private Font m_textFont;
        [Category("Text Font"), Description("chọn font cho Text hiện lên ở Tab")]
        public Font TextFont
        {
            get { return m_textFont; }
            set { m_textFont = value; this.Invalidate(); }
        }

        [Category("Item Border Size"), Description("")]
        public int ItemBorderSize
        { get; set;}

        public MenuGroup()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw, true);
            m_listItems = new List<MenuGroupItem>();

            var item = new MenuGroupItem();
            item.Text = "Demo";
            item.Location = this.Location;

            InitializeComponent();
        }

        public void AddItem(MenuGroupItem item)
        {
            m_listItems.Add(item);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            DrawBorder(e.Graphics);
            foreach (var item in m_listItems)
            {
                var size = e.Graphics.MeasureString(item.Text, this.TextFont);
                item.Width = (int)size.Width;
                item.Height = (int)size.Height;

                DrawItem(e.Graphics, item);        
            }


            base.OnPaint(e);
        }

        void DrawBorder(Graphics graphics)
        {
            Pen pen = new Pen(Brushes.Black, ItemBorderSize);
            graphics.DrawLine(pen, this.Location, new Point(this.Location.X, this.Location.Y + this.Height));
            graphics.DrawLine(pen, new Point(this.Location.X, this.Location.Y + this.Height),
                                new Point(this.Location.X + this.Width, this.Location.Y + this.Height));
            graphics.DrawLine(pen, new Point(this.Location.X + this.Width, this.Location.Y + this.Height),
                                new Point(this.Location.X + this.Width, this.Location.Y + this.Height));
        }

        void DrawItem(Graphics graphics, MenuGroupItem item)
        {
            Pen pen = new Pen(Brushes.Black, ItemBorderSize);
            graphics.DrawLine(pen, item.Location, new Point(item.Location.X, item.Location.Y + item.Height));

            graphics.DrawLine(pen, new Point(item.Location.X, item.Location.Y + item.Height), 
                                    new Point(item.Location.X + item.Width, item.Location.Y + item.Height));

            graphics.DrawLine(pen, new Point(item.Location.X + item.Width, item.Location.Y + item.Height),
                                     new Point(item.Location.X + item.Width, item.Location.Y));

            graphics.DrawLine(pen, new Point(item.Location.X + item.Width, item.Location.Y),
                                    this.Location);
        }
    }

    public class MenuGroupItem
    {
        public MenuGroupItem()
        {
            
        }

        public string Text
        { get; set; }

        public int Width
        { get; set; }

        public int Height
        { get; set; }

        public Size Bound
        { get; set; }

        public Point Location
        { get; set; }
    }
}
