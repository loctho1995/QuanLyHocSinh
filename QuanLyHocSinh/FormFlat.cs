using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh
{
    public class FormFlat : Form
    {
        #region -PROPERTIES, ATTREIBUTES-
        /// <summary>
        /// độ dài nếp gấp ở trên
        /// </summary>
        int m_creaseAboveHeight;
        public int CreaseAboveHeight
        {
            get { return m_creaseAboveHeight; }
            set { m_creaseAboveHeight = value; }
        }

        /// <summary>
        /// độ dài nếp gấp ở dưới
        /// </summary>
        int m_creaseUnderHeight;
        public int CreaseUnderHeight
        {
            get { return m_creaseUnderHeight; }
            set { m_creaseUnderHeight = value; }
        }

        /// <summary>
        /// độ sâu thụt vào của nếp gấp (chiều rộng)
        /// </summary>
        int m_creaseDepth;
        public int CreaseDepth
        {
            get { return m_creaseDepth; }
            set { m_creaseDepth = value; }
        }

        /// <summary>
        /// độ dài của thanh dưới (gọi là thanh statusbar) (theo chieu cao)
        /// </summary>
        int m_statusbarHeight;
        public int StatusbarHeight
        {
            get { return m_statusbarHeight; }
            set { m_statusbarHeight = value; }
        }

        /// <summary>
        /// màu của paper
        /// </summary>
        Color m_paperColor;
        public Color PaperColor
        {
            get { return m_paperColor; }
            set { m_paperColor = value; }
        }
        #endregion

        public FormFlat()
        {
            InitGraphics();
            this.Invalidate();
        }

        protected void InitGraphics()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw, true);
            m_paperColor = Color.FromArgb(47, 204, 113);
            m_creaseAboveHeight = m_creaseUnderHeight = 15;
            m_statusbarHeight = 30;
            m_creaseDepth = 10;

            this.BackColor = Color.FromArgb(102, 101, 101);
            //this.MaximumSize = this.Size;
            //this.MinimumSize = this.Size;
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);

                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;

            }

            base.WndProc(ref m);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            e.Graphics.FillRectangle(new SolidBrush(m_paperColor), new Rectangle(0, 30, this.Width,
                                                                        this.Height - m_statusbarHeight - 30));

            Point[] polygonAbove = new Point[] {new Point(0, this.Height - m_statusbarHeight), 
                                            new Point(m_creaseDepth, this.Height - m_statusbarHeight + m_creaseAboveHeight),
                                            new Point(this.Width - m_creaseDepth, this.Height - m_statusbarHeight + m_creaseAboveHeight),
                                            new Point(this.Width, this.Height - m_statusbarHeight)};

            Point[] polygonUnder = new Point[] {new Point(m_creaseDepth, this.Height - m_statusbarHeight + m_creaseAboveHeight), 
                                            new Point(0, this.Height - m_statusbarHeight + m_creaseAboveHeight + m_creaseUnderHeight),
                                            new Point(this.Width, this.Height - m_statusbarHeight + m_creaseAboveHeight + m_creaseUnderHeight),
                                            new Point(this.Width - m_creaseDepth, this.Height - m_statusbarHeight + m_creaseUnderHeight)};

            e.Graphics.FillPolygon(new SolidBrush(m_paperColor), polygonAbove);
            e.Graphics.FillPolygon(new SolidBrush(Color.FromArgb(50, Color.Black)), polygonAbove);

            e.Graphics.FillPolygon(new SolidBrush(m_paperColor), polygonUnder);
            e.Graphics.FillPolygon(new SolidBrush(Color.FromArgb(30, Color.Black)), polygonUnder);
            base.OnPaint(e);
        }
    }
}
