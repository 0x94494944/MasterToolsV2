using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace MasterTools
{
    public partial class PasswordGenerator : Form
    {
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;
        private bool m_aeroEnabled;
        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;

        [DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);
        [DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
        [DllImport("dwmapi.dll")]

        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        public struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();
                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW; return cp;
            }
        }
        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0; DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCPAINT:
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 0,
                            rightWidth = 0,
                            topHeight = 0
                        }; DwmExtendFrameIntoClientArea(this.Handle, ref margins);
                    }
                    break;
                default: break;
            }
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT) m.Result = (IntPtr)HTCAPTION;
        }

        public PasswordGenerator()
        {
            InitializeComponent();
            m_aeroEnabled = false;
        }
        int mouseX, mouseY;
        bool mouseDown;
        int mouseinX, mouseinY;
        System.Windows.Forms.Timer t3 = new System.Windows.Forms.Timer();
        private void PassGen_Load(object sender, EventArgs e)
        {

            Opacity = 0;
            t3.Interval = 30;
            t3.Tick += new EventHandler(fadeIn);
            t3.Start();
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }
        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                t3.Stop();
            else
                Opacity += 0.025;
        }
        public string GenerateRandomCode(int length)
        {
            string text = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890-_';:|?/>!@#$%^&*()";
            StringBuilder stringBuilder = new StringBuilder();
            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                stringBuilder.Append(text[(int)(random.NextDouble() * (double)text.Length)]);
                
            }
            return stringBuilder.ToString();
        }
        private void siticoneRoundedButton10_Click(object sender, EventArgs e)
        {
            int value = trackBar1.Value;
            string gencode = GenerateRandomCode(value);
            flatTextBox1.Text = gencode;
        }

        private void siticoneRoundedButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(flatTextBox1.Text);
            }
            catch
            {
            }
        }

        private void siticoneControlBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            return;
        }

        private void label7_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseinX = MousePosition.X - Bounds.X;
            mouseinY = MousePosition.Y - Bounds.Y;
        }

        private void PassGen_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseinX = MousePosition.X - Bounds.X;
            mouseinY = MousePosition.Y - Bounds.Y;
        }

        private void PassGen_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - mouseinX;
                mouseY = MousePosition.Y - mouseinY;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void PassGen_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - mouseinX;
                mouseY = MousePosition.Y - mouseinY;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void label7_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
