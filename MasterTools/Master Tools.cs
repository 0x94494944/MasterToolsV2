using System;
using System.Net;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;
using System.IO;
using System.Collections.Specialized;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;

namespace MasterTools
{
    public partial class Main : Form
    {
        private bool m_aeroEnabled;
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;
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

        public Main()
        {
            InitializeComponent();
            m_aeroEnabled = false;
        }
        System.Windows.Forms.Timer t3 = new System.Windows.Forms.Timer();
        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                t3.Stop();
            else
                Opacity += 0.025;
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Array.ForEach(Process.GetProcessesByName("cmd"), x => x.Kill());
            Array.ForEach(Process.GetProcessesByName("ping"), x => x.Kill());
            Process[] proc = Process.GetProcessesByName("paping");
            if (proc.Length == 1)
            {
                proc[0].Kill();
            }

            Environment.Exit(0);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            DiscordRpc.client.Dispose();
            DiscordRpc.LoginDiscordRPC();
            Opacity = 0;
            t3.Interval = 30;
            t3.Tick += new EventHandler(fadeIn);
            t3.Start();
            updatebox.Text = "Loading News / Updates... ";
            siticoneLabel2.Text = "Welcome Back: " + User.Username + " | Account Expiry: " + User.Expiry;
            label19.Text = "ID: " + User.ID;
            label20.Text = "Username: " + User.Username;
            //email.Text = "Email: " + User.Email;
            //hwid.Text = "HWID: " + User.HWID;
            label5.Text = "Rank: " + User.Rank;
            //ip.Text = "IP: " + User.IP;
            expiry.Text = "Expiry: " + User.Expiry;
            label15.Text = "Last Login: " + User.LastLogin;
            label14.Text = "Register Date: " + User.RegisterDate;
            string news = new WebClient().DownloadString("");
            updatebox.Text = news;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var dirName = $@"{path}\MasterTools\";
            var dirname5 = dirName + "datasaver.txt";
            var content = File.ReadAllText(dirname5);
            richTextBox5.Text = content;
            wait2.Start();
        }
        string yourmomgay = "ht" + "tps:" + "/" + "/w" + "ebr" + "es" + "olv" + "er." + "nl/";
        int mouseX, mouseY;
        bool mouseDown;
        int mouseinX, mouseinY;

        private void siticoneRoundedButton1_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }
        private void siticoneRoundedButton10_Click(object sender, EventArgs e)
        {
            var passopen = new PasswordGenerator();

            if (Application.OpenForms["PassGen"] == null)
            {
                passopen.Show();
            }
            else
            {
                MessageBox.Show("Password Generator is already open!", "Master Tools", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                WebClient wc = new WebClient { };
                string myip = wc.DownloadString($"https://api.ipify.org/");
                string myfinaalip = wc.DownloadString($"https://api.hackertarget.com/geoip/?q=" + myip);
                richTextBox1.Text = myfinaalip;
                return;
            }
            else
            {
                richTextBox1.Text = "IP Address: Hidden" + Environment.NewLine + "Country: Hidden" + Environment.NewLine + "State: Hidden" + Environment.NewLine + "City: Hidden" + Environment.NewLine + "Latitude: Hidden" + Environment.NewLine + "Longitude: Hidden";
                return;
            }
        }

        private void label7_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - mouseinX;
                mouseY = MousePosition.Y - mouseinY;

                SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void label7_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void label17_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseinX = MousePosition.X - Bounds.X;
            mouseinY = MousePosition.Y - Bounds.Y;
        }

        private void label17_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void label17_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - mouseinX;
                mouseY = MousePosition.Y - mouseinY;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void label18_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseinX = MousePosition.X - Bounds.X;
            mouseinY = MousePosition.Y - Bounds.Y;
        }

        private void label18_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void label18_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - mouseinX;
                mouseY = MousePosition.Y - mouseinY;

                SetDesktopLocation(mouseX, mouseY);
            }
        }
        private void siticoneRoundedButton3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }
        private void siticoneRoundedButton13_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var dirName22 = $@"{path}\MasterTools\";
            var dirname7 = dirName22 + "paping.exe";
            Process[] proc = Process.GetProcessesByName("paping");
            if (string.IsNullOrWhiteSpace(iptext.Text) || string.IsNullOrWhiteSpace(porttext.Text))
            {
                MessageBox.Show("Host And Username Fields Cannot Be Empty", "Master Tools", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (proc.Length == 0)
            {
                new Process
                {
                    StartInfo =
                {
                    UseShellExecute = false,
                    FileName = dirname7,
                    Arguments = iptext.Text + " -p " + porttext.Text
                }
                }.Start();
            }
            else
            {
                MessageBox.Show("Master Tools Application Is Already Running", "Master Tools", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public string Ecrypt23(string input)
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

        private void siticoneRoundedButton14_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(iptext.Text) || string.IsNullOrWhiteSpace(action.Text))
            {
                MessageBox.Show("Host And Action Fields Cannot Be Empty", "Master Tools", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (action.Text == "Geo IP")
            {
                WebClient wc = new WebClient { };
                richTextBox2.Text = "Waiting For API Response...";
                return;
            }
            if (action.Text == "Nmap Port Scan")
            {
                WebClient wc = new WebClient { };
                richTextBox2.Text = "Waiting For API Response...";
                string geo = wc.DownloadString("https://api.hackertarget.com/nmap/?q=" + iptext.Text);

                richTextBox2.Text = geo;
                return;
            }
            if (action.Text == "Custom Port Scan")
            {
                if (string.IsNullOrWhiteSpace(iptext.Text) || string.IsNullOrWhiteSpace(porttext.Text))
                {
                    MessageBox.Show("Host And Username Fields Cannot Be Empty", "Master Tools", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    string Custom = iptext.Text;
                    WebClient wc = new WebClient { };
                    richTextBox2.Text = "Waiting For API Response...";
                    return;
                }
            }
            if (action.Text == "Who Is")
            {
                WebClient wc = new WebClient { };
                richTextBox2.Text = "Waiting For API Response...";
                string who = wc.DownloadString(yourmomgay + "api.php?key=" + "PNJ6E-66ML3-WKXRU-2IAM7" + $"&html=0&action=whois&string=" + iptext.Text);

                richTextBox2.Text = who;
                return;
            }
            if (action.Text == "Subnet Lookup")
            {
                WebClient wc = new WebClient { };
                richTextBox2.Text = "Waiting For API Response...";
                string sub = wc.DownloadString("https://api.hackertarget.com/subnetcalc/?q=" + iptext.Text);

                richTextBox2.Text = sub;
                return;
            }
            if (action.Text == "Traceroute")
            {
                WebClient wc = new WebClient { };
                richTextBox2.Text = "Waiting For API Response...";
                string trace = wc.DownloadString("https://api.hackertarget.com/mtr/?q=" + iptext.Text);

                richTextBox2.Text = trace;
                return;
            }
        }

        private void siticoneRoundedButton16_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(iptext.Text))
            {
                MessageBox.Show("Please Enter IP To Ping", "Master Tools", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string strCmdText;
                strCmdText = $"/K color 7 & mode con lines=20 cols=60 & ping {iptext.Text} -t";
                System.Diagnostics.Process.Start("CMD.exe", strCmdText);
                return;
            }
        }
        private void siticoneRoundedButton15_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(richTextBox2.Text);
            }
            catch
            {
            }
        }
        public void Log(string line)
        {
            richTextBox2.Text += line + System.Environment.NewLine;
        }

        private void startNewThread()
        {
            Thread x = new Thread(new ThreadStart(Ping));
            x.IsBackground = true;
            x.Start();
        }
        private Process p;
        private void Ping()
        {
            p.StartInfo.FileName = "ping.exe";
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.Arguments = iptext.Text + " -t";
            p.Start();

            while (p.StandardOutput.Peek() > -1)
            {
                this.Invoke((MethodInvoker)delegate () { Log(p.StandardOutput.ReadLine()); });
                p.StandardOutput.DiscardBufferedData();
            }
        }

        private void siticoneRoundedButton17_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(iptext.Text))
            {
                MessageBox.Show("Please Enter Host/IP", "Master Tools", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (siticoneRoundedButton17.Text == "Ping in Output Box")
            {
                p = new Process();
                startNewThread();
                siticoneRoundedButton17.Text = "Stop Ping";
                return;
            }
            else
            {
                p.Kill();
                siticoneRoundedButton17.Text = "Ping in Output Box";
                return;
            }
        }

        private void siticoneRoundedButton9_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            richTextBox2.SelectionStart = richTextBox2.Text.Length;
            richTextBox2.ScrollToCaret();
        }

        private void siticoneRoundedButton18_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = "";
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
        private void siticoneRoundedButton20_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(host.Text) || string.IsNullOrWhiteSpace(act.Text))
            {
                MessageBox.Show("Host And Action Fields Cannot Be Empty", "Master Tools", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (act.Text == "DNS Lookup")
            {
                WebClient wc = new WebClient { };
                richTextBox3.Text = "Waiting For API Response...";
                return;
            }
            if (act.Text == "Whois Lookup")
            {
                WebClient wc = new WebClient { };
                richTextBox3.Text = "Waiting For API Response...";
                string Whois = wc.DownloadString("https://api.hackertarget.com/whois/?q=" + host.Text);

                richTextBox3.Text = Whois;
                return;
            }
            if (act.Text == "Reverse IP Lookup")
            {
                WebClient wc = new WebClient { };
                richTextBox3.Text = "Waiting For API Response...";
                return;
            }
            if (act.Text == "Website Whois")
            {
                WebClient wc = new WebClient { };
                richTextBox3.Text = "Waiting For API Response...";
                return;
               
            }
            if (act.Text == "Website Headers")
            {
                WebClient wc = new WebClient { };
                richTextBox3.Text = "Waiting For API Response...";
                return;
            }
            if (act.Text == "Domain information")
            {
                WebClient wc = new WebClient { };
                richTextBox3.Text = "Waiting For API Response...";
                return;
            }
            if (act.Text == "IP to Websites")
            {
                WebClient wc = new WebClient { };
                richTextBox3.Text = "Waiting For API Response...";
                return;
            }
            if (act.Text == "Disposable email checker")
            {
                WebClient wc = new WebClient { };
                richTextBox3.Text = "Waiting For API Response...";
                return;
            }
            if (act.Text == "CloudFlare Resolver")
            {
                WebClient wc = new WebClient { };
                richTextBox3.Text = "Waiting For API Response...";
                return;
            }
            if (act.Text == "Page Links")
            {
                WebClient wc = new WebClient { };
                richTextBox3.Text = "Waiting For API Response...";
                string Page = wc.DownloadString("https://api.hackertarget.com/pagelinks/?q=" + host.Text);
                richTextBox3.Text = Page;
                return;
            }
        }

        private void siticoneRoundedButton4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void siticoneRoundedButton21_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(richTextBox3.Text);
            }
            catch
            {
            }
        }

        private void siticoneRoundedButton19_Click(object sender, EventArgs e)
        {
            richTextBox3.Text = "";
            return;
        }

        public static void sendWebHook(string URL, string msg, string username)
        {
            Http.Post(URL, new NameValueCollection()
            {
                { "username", username },
                { "content", msg }
            });
        }
        private void startattack_Click(object sender, EventArgs e)
            {
            string IP = stresshost.Text;
            string PORT = siticoneMaterialTextBox1.Text;
            string TIME = timeattack.Text;
            string METHOD = siticoneComboBox1.Text;
            WebClient wc332 = new WebClient { };
            string REG3rfeer = wc332.DownloadString("");
            string ravelnotapi = REG3rfeer + $"&host={IP}&port={PORT}&time={TIME}&type={METHOD}";
            int xyzz = int.Parse(timeattack.Text);
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var dirName = $@"{path}\MasterTools\";
            var dirname2 = dirName + "database.txt";
            var dirname3 = dirName + "attacklog.txt";
            WebClient wc2 = new WebClient { };
            string Page = wc2.DownloadString("https://ipwhois.app/json/" + stresshost.Text);
            using (StreamWriter sw = new StreamWriter(dirname2))
            {
                sw.WriteLine(Page);
            }
            if (File.ReadAllText(dirname2).Contains("false") || File.ReadAllText(dirname2).Contains("CloudFlare") || File.ReadAllText(dirname2).Contains("Cloudflare") || File.ReadAllText(dirname2).Contains("DDoS-Guard") || File.ReadAllText(dirname2).Contains("Google") || File.ReadAllText(dirname2).Contains("Akamai") || File.ReadAllText(dirname2).Contains("Reflected") || File.ReadAllText(dirname2).Contains("Segment") || File.ReadAllText(dirname2).Contains("ServerStack") || File.ReadAllText(dirname2).Contains("Facebook") || File.ReadAllText(dirname2).Contains("Digital") || File.ReadAllText(dirname2).Contains("127.0.0.1"))
            { 
                MessageBox.Show("Blacklisted ISP Detected Or IP Dose Not Exist, Attack Will Not Start", "Master Tools", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                File.AppendAllText(dirname3, "IP: " + stresshost.Text + " - Attack Failed" + Environment.NewLine);
                var content = File.ReadAllText(dirname3);
                attacklog.Text = content;
                return;
            }
            else
            {
                if (string.IsNullOrWhiteSpace(stresshost.Text) || string.IsNullOrWhiteSpace(siticoneMaterialTextBox1.Text) || string.IsNullOrWhiteSpace(timeattack.Text))
                {
                    MessageBox.Show("IP, Port, Time, Methods Fields Cannot Be Empty", "Master Tools", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (User.Rank == "1" && xyzz > 120 || User.Rank == "2" && xyzz > 300 || User.Rank == "3" && xyzz > 600 || User.Rank == "4" && xyzz > 3200 || User.Rank == "5" && xyzz > 10000)
                {
                    MessageBox.Show("Your Rank Does Not Meet Requirements, Try To Change Your Input", "Master Tools", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    File.AppendAllText(dirname3, "IP: " + stresshost.Text + " - Attack Failed" + Environment.NewLine);
                    var content = File.ReadAllText(dirname3);
                    attacklog.Text = content;
                }
                if (User.Rank == "0")
                {
                    MessageBox.Show("Please contact an admin!");
                    File.AppendAllText(dirname3, "IP: " + stresshost.Text + " - Attack Failed" + Environment.NewLine);
                    var content = File.ReadAllText(dirname3);
                    attacklog.Text = content;
                }
                else
                {
                    if (User.Rank == "1")
                    {
                        try
                        { 
                        cooldown.Start();
                        startattack.Enabled = false;
                        WebClient wc235 = new WebClient { };
                        wc235.DownloadString(ravelnotapi);
                        File.AppendAllText(dirname3, "IP: " + stresshost.Text + " | Port: " + siticoneMaterialTextBox1.Text + " | Time: " + timeattack.Text + " | Method: " + siticoneComboBox1.Text + Environment.NewLine);
                        var content = File.ReadAllText(dirname3);
                        attacklog.Text = content;
                        int x = 120;
                        while (x > 0)
                        {
                            x = x - 1;
                            nigger.Text = "Cooldown: " + x + " Seconds Left";
                            wait(1000);
                        }
                        nigger.Text = "Cooldown Status: Off";
                        return;
                        }
                        catch
                        {
                            MessageBox.Show("error 0x26583");
                        }
                    }

                    if (User.Rank == "2")
                    {
                        try
                        { 
                        rank1.Start();
                        startattack.Enabled = false;
                        WebClient wc343 = new WebClient { };
                        wc343.DownloadString(ravelnotapi);
                        File.AppendAllText(dirname3, "IP: " + stresshost.Text + " | Port: " + siticoneMaterialTextBox1.Text + " | Time: " + timeattack.Text + " | Method: " + siticoneComboBox1.Text + Environment.NewLine);
                        var content = File.ReadAllText(dirname3);
                        attacklog.Text = content;
                        int x = 100;
                        while (x > 0)
                        {
                            x = x - 1;
                            nigger.Text = "Cooldown: " + x + " Seconds Left";
                            wait(1000);
                        }
                        nigger.Text = "Cooldown Status: Off";
                        return;
                        }
                        catch
                        {
                            MessageBox.Show("error 0x26583");
                        }
                    }
                    if (User.Rank == "3")
                    {
                        try
                        {
                            rank2.Start();
                            startattack.Enabled = false;
                            WebClient wc443 = new WebClient { };
                            wc443.DownloadString(ravelnotapi);
                            File.AppendAllText(dirname3, "IP: " + stresshost.Text + " | Port: " + siticoneMaterialTextBox1.Text + " | Time: " + timeattack.Text + " | Method: " + siticoneComboBox1.Text + Environment.NewLine);
                            var content = File.ReadAllText(dirname3);
                            attacklog.Text = content;
                            int x = 60;
                            while (x > 0)
                            {
                                x = x - 1;
                                nigger.Text = "Cooldown: " + x + " Seconds Left";
                                wait(1000);
                            }
                            nigger.Text = "Cooldown Status: Off";
                            return;
                        }
                        catch
                        {
                            MessageBox.Show("error 0x26583");
                        }
                    }

                    if (User.Rank == "4")
                    {
                        try
                        {


                            rank3.Start();
                            startattack.Enabled = false;
                            WebClient wc32 = new WebClient { };
                            wc32.DownloadString(ravelnotapi);
                            File.AppendAllText(dirname3, "IP: " + stresshost.Text + " | Port: " + siticoneMaterialTextBox1.Text + " | Time: " + timeattack.Text + " | Method: " + siticoneComboBox1.Text + Environment.NewLine);
                            var content = File.ReadAllText(dirname3);
                            attacklog.Text = content;
                            int x = 15;
                            while (x > 0)
                            {
                                x = x - 1;
                                nigger.Text = "Cooldown: " + x + " Seconds Left";
                                wait(1000);
                            }
                            nigger.Text = "Cooldown Status: Off";
                            return;
                        }
                        catch
                        {
                            MessageBox.Show("error 0x26583");
                        }
                    }

                    if (User.Rank == "5")
                    {
                        try
                        {
                            WebClient wc32 = new WebClient { };
                            wc32.DownloadString(ravelnotapi);
                            File.AppendAllText(dirname3, "IP: " + stresshost.Text + " | Port: " + siticoneMaterialTextBox1.Text + " | Time: " + timeattack.Text + " | Method: " + siticoneComboBox1.Text + Environment.NewLine);
                            var content = File.ReadAllText(dirname3);
                            attacklog.Text = content;
                            return;
                        }
                        catch
                        {
                            MessageBox.Show("error 0x26583");
                        }
                    }
                    else
                    { 
                    startattack.Enabled = true;
                    WebClient wc43 = new WebClient { };
                    wc43.DownloadString(ravelnotapi);
                    File.AppendAllText(dirname3, "IP: " + stresshost.Text + " | Port: " + siticoneMaterialTextBox1.Text + " | Time: " + timeattack.Text + " | Method: " + siticoneComboBox1.Text + Environment.NewLine);
                    var content = File.ReadAllText(dirname3);
                    attacklog.Text = content;
                    nigger.Text = "Cooldown Status: Off";
                    return;
                }
                }
            }
        }

        private void siticoneRoundedButton22_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(stresshost.Text))
            {
                MessageBox.Show("Please Enter IP To Ping", "Master Tools", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string strCmdText;
                strCmdText = $"/K color 7 & mode con lines=20 cols=60 & ping {stresshost.Text} -t";
                Process.Start("CMD.exe", strCmdText);
                return;
            }
        }

        private void siticoneRoundedButton23_Click(object sender, EventArgs e)
        {
            return;
        }

        private void siticoneRoundedButton24_Click(object sender, EventArgs e)
        {
            return;
        }

        private void cooldown_Tick(object sender, EventArgs e)
        {
                cooldown.Stop();
                startattack.Enabled = true;
        }

        private void label7_MouseDown_1(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseinX = MousePosition.X - Bounds.X;
            mouseinY = MousePosition.Y - Bounds.Y;
        }

        private void rank3_Tick(object sender, EventArgs e)
        {
            rank3.Stop();
            startattack.Enabled = true;
        }

        private void rank2_Tick(object sender, EventArgs e)
        {
            rank2.Stop();
            startattack.Enabled = true;
        }

        private void rank1_Tick(object sender, EventArgs e)
        {
            rank1.Stop();
            startattack.Enabled = true;
        }

        private void siticoneRoundedButton2_Click_1(object sender, EventArgs e)
        {
            if (pagecolor.ShowDialog() == DialogResult.OK)
            {
                tabPage1.BackColor = pagecolor.Color;
                tabPage2.BackColor = pagecolor.Color;
                tabPage3.BackColor = pagecolor.Color;
                tabPage4.BackColor = pagecolor.Color;
                tabPage5.BackColor = pagecolor.Color;
                tabPage6.BackColor = pagecolor.Color;
                tabPage7.BackColor = pagecolor.Color;
                tabPage8.BackColor = pagecolor.Color;
                Properties.Settings.Default.backcolorpage = pagecolor.Color;
                Properties.Settings.Default.Save();
            }
        }

        private void siticoneRoundedButton6_Click(object sender, EventArgs e)
        {
            Process.Start("https://google.com");
        }

        private void siticoneRoundedButton27_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var dirName22 = $@"{path}\MasterTools\";
            var dirname6 = dirName22 + "pinger.bat";
            Process[] proc = Process.GetProcessesByName("cmd");
            if (proc.Length == 0)
            {
                new Process
                {
                    StartInfo =
                {
                    UseShellExecute = false,
                    FileName = dirname6,
                }
                }.Start();
            }
            else
            {
                MessageBox.Show("Master Tools Application Is Already Running", "Master Tools", MessageBoxButtons.OK, MessageBoxIcon.Error);
                proc[0].Kill();
            }
        }

        private void siticoneRoundedButton12_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
        }

        private void siticoneRoundedButton11_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void status_Tick(object sender, EventArgs e)
        {
            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("https://webresolver.nl/"))
                {
                    label10.ForeColor = Color.Lime;
                    label10.Text = ("Server Online");
                }
            }
            catch
            {
                label10.ForeColor = Color.Tomato;
                label10.Text = ("Server Offline");
            }
            try
            {
                WebClient wc332 = new WebClient {};
                string REG3rfeer = wc332.DownloadString("");
                using (var client = new WebClient())
                using (var stream = client.OpenRead(REG3rfeer))
                {
                    label3.ForeColor = Color.Lime;
                    label3.Text = ("Server Online");
                }
            }
            catch
            {
                label3.ForeColor = Color.Tomato;
                label3.Text = ("Server Offline");
            }
            //
            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("https://google.com/"))
                {
                    IPStatus.ForeColor = Color.Lime;
                    IPStatus.Text = ("You Are Online");
                }
            }
            catch
            {
                IPStatus.ForeColor = Color.Tomato;
                IPStatus.Text = ("You Are Offline");
            }
            //
            try
            {
                using (var client = new WebClient())

                using (var stream = client.OpenRead("https://pastebin.com"))
                {
                    label12.ForeColor = Color.Lime;
                    label12.Text = ("Server Online");
                }
            }
            catch
            {
                label12.ForeColor = Color.Tomato;
                label12.Text = ("Server Offline");                
            }
            siticoneRoundedButton28.Enabled = true;
            status.Stop();
        }

        private void siticoneRoundedButton28_Click(object sender, EventArgs e)
        {
            siticoneRoundedButton28.Enabled = false;
            label10.ForeColor = Color.White;
            label12.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            IPStatus.ForeColor = Color.White;
            label10.Text = "Checking, please wait";
            label12.Text = "Checking, please wait";
            label3.Text = "Checking, please wait";
            IPStatus.Text = "Checking, please wait";
            status.Start();
            return;
        }

        private void siticoneRoundedButton7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage5;
        }

        private void genbutton_Click(object sender, EventArgs e)
        {
            if (comboBox3.Text == "Fatz Gift Card")
            {
                string[] array = new WebClient().DownloadString("").Split(new char[] 
                    {
                    '\n'
                    });
                richTextBox4.Text = array[new Random().Next(0, array.Length)];

            }
            if (comboBox3.Text == "Tidal.com Account")
            {
                string[] array = new WebClient().DownloadString("").Split(new char[]
                    {
                    '\n'
                    });
                richTextBox4.Text = array[new Random().Next(0, array.Length)];

            }
            if (comboBox3.Text == "Spotify Account")
            {
                string[] array = new WebClient().DownloadString("").Split(new char[]
                    {
                    '\n'
                    });
                richTextBox4.Text = array[new Random().Next(0, array.Length)];

            }
            if (comboBox3.Text == "Call of Duty Account")
            {
                string[] array = new WebClient().DownloadString("").Split(new char[]
                    {
                    '\n'
                    });
                richTextBox4.Text = array[new Random().Next(0, array.Length)];
            }

            if (comboBox3.Text == "Nord VPN Account")
            {
                string[] array = new WebClient().DownloadString("").Split(new char[]
                    {
                    '\n'
                    });
                richTextBox4.Text = array[new Random().Next(0, array.Length)];

            }
            if (comboBox3.Text == "Netflix Account")
            {
                string[] array = new WebClient().DownloadString("").Split(new char[]
                    {
                    '\n'
                    });
                richTextBox4.Text = array[new Random().Next(0, array.Length)];

            }

            if (comboBox3.Text == "crunchyroll.com Account")
            {
                string[] array = new WebClient().DownloadString("").Split(new char[]
                    {
                    '\n'
                    });
                richTextBox4.Text = array[new Random().Next(0, array.Length)];

            }
            genbutton.Enabled = false;
            int x = 20;
            while (x > 0)
            {
                x = x - 1;
                accdown.Text = "Cooldown: " + x + " Seconds Left";
                wait(1000);
            }
            accdown.Text = "Cooldown Status: Off";
            genbutton.Enabled = true;
        }

        private void siticoneRoundedButton30_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(richTextBox4.Text);
            }
            catch
            {
            }
        }

        private void cooldown1_Tick(object sender, EventArgs e)
        {
            cooldown1.Stop();
        }

        private void siticoneRoundedButton5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage6;
        }

        private void siticoneRoundedButton29_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var dirName = $@"{path}\MasterTools\";
            var dirname5 = dirName + "datasaver.txt";
            if (string.IsNullOrWhiteSpace(siticoneMaterialTextBox2.Text) || string.IsNullOrWhiteSpace(siticoneMaterialTextBox4.Text))
            {
                MessageBox.Show("IP And Username Fields Cannot Be Empty", "Master Tools", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                File.AppendAllText(dirname5, "IP: " + siticoneMaterialTextBox4.Text + " | Username: " + siticoneMaterialTextBox2.Text + " | Info: " + siticoneMaterialTextBox3.Text + Environment.NewLine);
                var content = File.ReadAllText(dirname5);
                richTextBox5.Text = content;
                MessageBox.Show("Your Input Has Been Successfully Saved To Local Database", "Master Tools", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void deletedata_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var dirName = $@"{path}\MasterTools\";
            var dirname5 = dirName + "datasaver.txt";
            var process = Process.Start(dirname5);
            process.WaitForExit();
            var content = File.ReadAllText(dirname5);
            richTextBox5.Text = content;
        }

        private void wait2_Tick(object sender, EventArgs e)
        {
            status.Start();
            wait2.Stop();
        }

        private void siticoneRoundedButton8_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage7;
        }
        public string RC4(string input, string key)
        {
            StringBuilder result = new StringBuilder();
            int x, y, j = 0;
            int[] box = new int[256];
            for (int i = 0; i < 256; i++)
                box[i] = i;
            for (int i = 0; i < 256; i++)
            {
                j = (key[i % key.Length] + box[i] + j) % 256;
                x = box[i];
                box[i] = box[j];
                box[j] = x;
            }
            for (int i = 0; i < input.Length; i++)
            {
                y = i % 256;
                j = (box[y] + j) % 256;
                x = box[y];
                box[y] = box[j];
                box[j] = x;
                result.Append((char)(input[i] ^ box[(box[y] + box[j]) % 256]));
            }
            return result.ToString();
        }

        public string corsairkeyboard(string input)
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

        private void siticoneRoundedButton31_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(siticoneMaterialTextBox5.Text) || string.IsNullOrWhiteSpace(siticoneComboBox2.Text))
            {
                MessageBox.Show("Message Input And Encryption Type Fields Cannot Be Empty", "Master Tools", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (siticoneComboBox2.Text == "Method 1")
            {
                encmsg.Text = RC4(siticoneMaterialTextBox5.Text, "123");
                return;
            }
            if (siticoneComboBox2.Text == "Method 2")
            {

                encmsg.Text = corsairkeyboard(siticoneMaterialTextBox5.Text);
                return;
            }
           
        }

        private void siticoneRoundedButton33_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(siticoneMaterialTextBox5.Text) || string.IsNullOrWhiteSpace(siticoneComboBox2.Text))
            {
                MessageBox.Show("Message Input And Encryption Type Fields Cannot Be Empty", "Master Tools", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (siticoneComboBox2.Text == "Method 1")
            {
                decmsg.Text = RC4(siticoneMaterialTextBox5.Text, "123");
                return;
            }
            if (siticoneComboBox2.Text == "Method 2")
            {
                decmsg.Text = corsairkeyboard(siticoneMaterialTextBox5.Text);
                return;
            }
            
        }

        private void siticoneRoundedButton2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage8;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            mouseDown = false;
        }

        private void label7_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseinX = MousePosition.X - Bounds.X;
            mouseinY = MousePosition.Y - Bounds.Y;
        }
    }
}

