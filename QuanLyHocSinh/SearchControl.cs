using System.Drawing;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh
{
    public partial class SearchControl : UserControl
    {
        //size khi hien len
        Size m_hideSize;
        /// <summary>
        /// Size của Control khi bị ẩn đi (chỉ con mình button)
        /// </summary>
        public Size HideSize
        {
            get { return m_hideSize; }
            set { m_hideSize = value; }
        }

        Size m_showSize;
        /// <summary>
        /// Size của Control khi được hiện lên
        /// </summary>
        public Size ShowSize
        {
            get { return m_showSize; }
            set { m_showSize = value; }
        }

        TextBox m_tb;
        public TextBox TextBoxSearch
        { 
            get { return m_tb; }
            set { m_tb = value; }
        }

        Button m_bt;
        public Button ButtonSearch
        {
            get { return m_bt; }
            set { m_bt = value; }
        }

        Label m_lb;
        public Label LabelSearch
        {
            get { return m_lb; }
            set { m_lb = value; }
        }

        public enum States
        {
            Show, Hide
        }
        States m_state;
        public States State
        {
            get { return m_state; }
            set { m_state = value; }
        }

        public enum MouseStates
        {
            Leave, Hover
        }
        MouseStates m_mouseState;
        
        int m_speed;
        /// <summary>
        /// Tốc độ di chuyển của Control khi hiện / ẩn
        /// </summary>
        public int Speed
        {
            get { return m_speed; }
            set { m_speed = value; }
        }

        int m_deltaSpeed;
        /// <summary>
        /// Tốc độ biến thiên (nhanh dần đều / chậm dần đều)
        /// </summary>
        public int DeltaSpeed
        {
            get { return m_deltaSpeed; }
            set { m_deltaSpeed = value; }
        }

        Timer m_timer, m_timerImageGlow; //timer hide/ show form và timer làm ảnh mập mờ
        Point m_oldLocation;
        bool m_firstTimeChange; //lần đầu thay đổi postion để set old position
        float m_controlAlpha; // tốc đọ tăng, giảm độ trong suốt cua control

        private enum AlphaStates
        {
            GlowUp, GlowDown
        }
        AlphaStates m_controlGlowState;

        public SearchControl()
        {
            InitializeComponent();

            m_controlGlowState = AlphaStates.GlowDown;
            m_controlAlpha = 1.5f;
            m_speed = 1; //tốc độ di chuyển hiện tại
            m_deltaSpeed = 2; //tốc độ biến thiên

            m_firstTimeChange = true;

            m_hideSize = new System.Drawing.Size(30, this.Height);
            m_showSize = new System.Drawing.Size(250, this.Height);

            m_bt = new Button();
            m_bt.Size = new System.Drawing.Size(30, m_showSize.Height);
            m_bt.Location = this.Location;// new Point(0, 0);
            m_bt.Image = new Bitmap(QuanLyHocSinh.Properties.Resources.showButton, new Size((int)(m_bt.Width * 0.8), m_bt.Height));
            m_bt.Anchor = AnchorStyles.Left;
            m_bt.FlatStyle = FlatStyle.Flat;
            m_bt.FlatAppearance.BorderSize = 0;
            m_bt.MouseHover += m_MouseHover;
            m_bt.Click += (o, e) =>
                {
                    //MessageBox.Show("BT Size:" + m_bt.Height + "\nForm: " + this.Height);
                    //MessageBox.Show(this.Location.ToString());
                };

            m_tb = new TextBox();
            m_tb.Size = new System.Drawing.Size(this.Width - m_bt.Width - 10, this.Height * 2 / 3);
            m_tb.Location = new Point(m_bt.Location.X + m_bt.Width + 5, this.Height / 2 - m_tb.Height / 2);
            m_tb.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Italic);
            m_tb.Text = "Nhập tên học sinh";
            m_tb.Anchor = AnchorStyles.Left;
            m_tb.MouseHover += m_MouseHover;         
            m_tb.GotFocus += (o, e) =>
                {
                    m_tb.Text = "";
                };

            m_lb = new Label();
            m_lb.AutoSize = true;
            m_lb.Font = new System.Drawing.Font("Tahoma", 12, FontStyle.Bold);
            m_lb.Text = "Tìm kiếm học sinh";
            m_lb.Location = new Point(m_tb.Location.X + (m_showSize.Width / 2 - m_lb.Width), this.Location.Y + 5);//this.Location;
            m_lb.ForeColor = Color.Red;
            m_lb.MouseHover += m_MouseHover;

            this.Controls.Add(m_bt);
            this.Controls.Add(m_tb);
            this.Controls.Add(m_lb);

            m_timer = new Timer();
            m_timer.Interval = 100;
            m_timer.Tick += m_timer_Tick;
            m_timer.Enabled = true;
            m_timer.Stop();

            m_timerImageGlow = new Timer();
            m_timerImageGlow.Interval = 100;
            m_timerImageGlow.Tick += m_timerImageGlow_Tick;
            m_timer.Enabled = true;
            m_timer.Start();

            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.ContainerControl | ControlStyles.AllPaintingInWmPaint, true);
        }

        void m_timerImageGlow_Tick(object sender, EventArgs e)
        {
            switch (m_controlGlowState)
            {
                case AlphaStates.GlowUp:
                    break;

                case AlphaStates.GlowDown:
                    break;
            }
        }

        void m_MouseHover(object sender, EventArgs e)
        {
            m_mouseState = MouseStates.Hover;
            m_timer.Start();
        }

        void m_timer_Tick(object sender, EventArgs e)
        {
            switch (m_mouseState)
            {
                case MouseStates.Leave:
                    if (this.Width - m_speed <= m_hideSize.Width)
                    {
                        this.Width = m_hideSize.Width;
                        this.Location = m_oldLocation;
                        this.Invalidate();

                        m_speed = 1;
                        m_timer.Stop();
                        break;
                    }

                    this.Width -= m_speed;//new Size(this.Width - 5, this.Height);
                    this.Location = new Point(this.Location.X + m_speed, this.Location.Y);
                    m_speed += m_deltaSpeed;
                    this.Invalidate();
                    break;

                case MouseStates.Hover:                    
                    if (this.Width + m_speed >= m_showSize.Width)
                    {
                        this.Width = m_showSize.Width;
                        this.Location = new Point(m_oldLocation.X - m_showSize.Width + m_hideSize.Width, m_oldLocation.Y);
                        this.Invalidate();

                        m_speed = 1;
                        m_timer.Stop();
                        break;
                    }  

                    this.Width += m_speed;// new Size(this.Width + 5, this.Height);
                    this.Location = new Point(this.Location.X - m_speed, this.Location.Y);
                    m_speed += m_deltaSpeed;
                    this.Invalidate();
                    break;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            m_bt.Location = new Point(0, 0);
            m_bt.Height = this.Height;

            if (m_firstTimeChange)
            {
                m_firstTimeChange = false;
                m_oldLocation = this.Location;
            }

            switch (State)
            {
                case States.Show:
                    break;

                case States.Hide:
                    break;
            }

            base.OnPaint(e);
        }

        protected override void OnMouseHover(EventArgs e)
        {            
            m_mouseState = MouseStates.Hover;
            m_timer.Start();
            //MessageBox.Show(m_bt.Location.ToString());
            base.OnMouseHover(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            //MessageBox.Show("BT Size:" + m_bt.Height + "\nForm: " + this.Height);
            m_mouseState = MouseStates.Leave;
            m_timer.Start();
            base.OnMouseLeave(e);
        }
    }
}
