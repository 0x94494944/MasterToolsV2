using System;
using System.Collections.Specialized;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Diagnostics;
using System.Reflection;
using System.Timers;
using System.Text;
using System.Text.RegularExpressions;
using System.Net;

namespace MasterTools
{
    public partial class Login : Form
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

        public Login()
        {
            InitializeComponent();
            m_aeroEnabled = false;
            System.Timers.Timer timer = new System.Timers.Timer(TimeSpan.FromMinutes(10).TotalMilliseconds);
            timer.AutoReset = true;
            timer.Elapsed += new ElapsedEventHandler(MyMethod);
            timer.Start();
        }
        public static void MyMethod(object sender, ElapsedEventArgs e)
        {
            Application.Restart();
        }
        private const bool V = true;
        int mouseX, mouseY;
        bool mouseDown;
        int mouseinX, mouseinY;
        System.Windows.Forms.Timer t1 = new System.Windows.Forms.Timer();
        private void Login_Load(object sender, EventArgs e)
        {

            if (IsApplicationAlreadyRunning())
            {
                MessageBox.Show("Master Tools Application Is Already Running", "Master Tools", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            DiscordRpc.LoginWait();

            Opacity = 0;      
            t1.Interval = 30; 
            t1.Tick += new EventHandler(fadeIn);  
            t1.Start();
            
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var dirName = $@"{path}\MasterTools\";
            var dirname2 = dirName + "database.txt";
            var dirname3 = dirName + "attacklog.txt";
            var dirname5 = dirName + "datasaver.txt";
            var frere = AppDomain.CurrentDomain.BaseDirectory + "pinger.bat";
            var frere2 = dirName + "pinger.bat";
            var frere3 = AppDomain.CurrentDomain.BaseDirectory + "paping.exe";
            var frere4 = dirName + "paping.exe";
            if (!Directory.Exists(dirName))
            {
                Directory.CreateDirectory(dirName);
            }
            if (!File.Exists(dirname3) || !File.Exists(dirname2))
            {
                try
                {
                    File.Create(dirname3);
                    File.Create(dirname2);
                    MessageBox.Show("The application will close, adding files for the MasterTools", "Master Tools", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Environment.Exit(0);
                }
                catch
                {

                }
            }
            
            if (!File.Exists(dirname5))
            {
                File.Create(dirname5);
                MessageBox.Show("The application will close, adding the database saver for MasterTools, you need to relaunch the applicaion", "Master Tools", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Environment.Exit(0);
            }
            if (!File.Exists(frere) && !File.Exists(frere2))
            {
                MessageBox.Show("The file pinger.bat is missing", "Master Tools", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Environment.Exit(0);
            }
            if (!File.Exists(frere3) && !File.Exists(frere4))
            {
                MessageBox.Show("The file paping.exe is missing", "Master Tools", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Environment.Exit(0);
            }
            if (File.Exists(frere3))
            {
                if (!File.Exists(frere4))
                {
                    File.Copy(frere3, frere4);
                    File.Delete(frere3);
                }
                if (File.Exists(frere4) && File.Exists(frere3))
                {
                    File.Delete(frere3);
                }
            }
            if (File.Exists(frere))
            {
                if (!File.Exists(frere2))
                {
                    File.Copy(frere, frere2);
                    File.Delete(frere);
                }
                if (File.Exists(frere2) && File.Exists(frere))
                {
                    File.Delete(frere);
                }
            }
            if (MasterTools.Properties.Settings.Default.rememberme)
            {
                username.Text = MasterTools.Properties.Settings.Default.username;
                password.Text = MasterTools.Properties.Settings.Default.password;
                checkBox1.Checked = true;
                checkBox1.CheckState = CheckState.Checked;
            }
            try
            {
                File.WriteAllText(dirname3, string.Empty);
            }
            catch
            { }
        }
        static bool IsApplicationAlreadyRunning()
        {
            return Process.GetProcesses().Count(p => p.ProcessName.Contains(Assembly.GetExecutingAssembly().FullName.Split(',')[0]) && !p.Modules[0].FileName.Contains("vshost")) > 1;
        }
        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                t1.Stop();  
            else
                Opacity += 0.05;
        }
        private void siticoneRoundedButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register f2 = new Register();
            f2.Show();
        }
        public static void sendWebHook(string URL, string msg, string username)
        {
            Http.Post(URL, new NameValueCollection()
            {
                { "username", username },
                { "content", msg }
            });
        }

        private void label5_MouseDown_1(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseinX = MousePosition.X - Bounds.X;
            mouseinY = MousePosition.Y - Bounds.Y;
        }

        private void label5_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - mouseinX;
                mouseY = MousePosition.Y - mouseinY;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        void label5_MouseUp_1(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void password_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                siticoneRoundedButton1.PerformClick();
            }
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                siticoneRoundedButton1.PerformClick();
            }
        }

        private void username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                siticoneRoundedButton1.PerformClick();
            }
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        public static void wait(int milliseconds)
        {
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();
            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
            };
            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        public string Milkisgood(string input)
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
        
        private void SiticoneRoundedButton1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true && API.Login(username.Text, password.Text))
            {
                Properties.Settings.Default.username = username.Text;
                Properties.Settings.Default.password = password.Text;
            }
            else
            {
                Properties.Settings.Default.username = null;
                Properties.Settings.Default.password = null;
            }
            Properties.Settings.Default.rememberme = checkBox1.Checked;
            Properties.Settings.Default.Save();

            if (API.Login(username.Text,password.Text))
            {
                Checking test3 = new Checking();
                test3.Show();
                this.Hide();
                wait(5550);
                Main main3 = new Main();
                main3.Show();
                test3.Hide();
                
            }
            else
            {
                Checking test3 = new Checking();
                Error test2 = new Error();
                test3.Show();
                Hide();
                wait(4660);
                test2.Show();
                test3.Hide();
                wait(2800);
                Show();
                test2.Hide();
            }
        }
    }
}