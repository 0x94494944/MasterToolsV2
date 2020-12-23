namespace MasterTools
{
    public partial class Main : global::System.Windows.Forms.Form
    {
        protected override void Dispose(bool disposing)
        {
            bool flag = disposing && this.components != null;
            if (flag)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Siticone.UI.AnimatorNS.Animation animation1 = new Siticone.UI.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.siticoneDragControl1 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.siticoneControlBox1 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox2 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneTransition1 = new Siticone.UI.WinForms.SiticoneTransition();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.siticoneRoundedButton1 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton3 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton4 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton5 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton6 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton7 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton8 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.siticoneRoundedButton12 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton11 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.updatebox = new System.Windows.Forms.RichTextBox();
            this.siticoneLabel2 = new Siticone.UI.WinForms.SiticoneLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.siticoneRoundedButton28 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.IPStatus = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.siticoneRoundedButton17 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton16 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.siticoneRoundedButton18 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton14 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton15 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton13 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.action = new Siticone.UI.WinForms.SiticoneComboBox();
            this.porttext = new Siticone.UI.WinForms.SiticoneMaterialTextBox();
            this.iptext = new Siticone.UI.WinForms.SiticoneMaterialTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.siticoneRoundedButton27 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton10 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.siticoneRoundedButton19 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton20 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton21 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.act = new Siticone.UI.WinForms.SiticoneComboBox();
            this.host = new Siticone.UI.WinForms.SiticoneMaterialTextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.siticoneRoundedButton24 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton23 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton22 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.nigger = new System.Windows.Forms.Label();
            this.timeattack = new Siticone.UI.WinForms.SiticoneMaterialTextBox();
            this.stresshost = new Siticone.UI.WinForms.SiticoneMaterialTextBox();
            this.siticoneComboBox1 = new Siticone.UI.WinForms.SiticoneComboBox();
            this.startattack = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneMaterialTextBox1 = new Siticone.UI.WinForms.SiticoneMaterialTextBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.attacklog = new System.Windows.Forms.RichTextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.accdown = new System.Windows.Forms.Label();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.comboBox3 = new Siticone.UI.WinForms.SiticoneComboBox();
            this.siticoneRoundedButton30 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.genbutton = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.deletedata = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneMaterialTextBox4 = new Siticone.UI.WinForms.SiticoneMaterialTextBox();
            this.siticoneRoundedButton29 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneMaterialTextBox3 = new Siticone.UI.WinForms.SiticoneMaterialTextBox();
            this.siticoneMaterialTextBox2 = new Siticone.UI.WinForms.SiticoneMaterialTextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.groupBox22 = new System.Windows.Forms.GroupBox();
            this.encmsg = new System.Windows.Forms.RichTextBox();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.decmsg = new System.Windows.Forms.RichTextBox();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.siticoneComboBox2 = new Siticone.UI.WinForms.SiticoneComboBox();
            this.siticoneRoundedButton33 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneMaterialTextBox5 = new Siticone.UI.WinForms.SiticoneMaterialTextBox();
            this.siticoneRoundedButton31 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.siticoneRoundedButton26 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton25 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.label7 = new System.Windows.Forms.Label();
            this.siticoneRoundedButton9 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.registerdate = new Siticone.UI.WinForms.SiticoneLabel();
            this.lastlogin = new Siticone.UI.WinForms.SiticoneLabel();
            this.expiry = new Siticone.UI.WinForms.SiticoneLabel();
            this.email = new Siticone.UI.WinForms.SiticoneLabel();
            this.hwid = new Siticone.UI.WinForms.SiticoneLabel();
            this.username = new Siticone.UI.WinForms.SiticoneLabel();
            this.uservariable = new Siticone.UI.WinForms.SiticoneLabel();
            this.userid = new Siticone.UI.WinForms.SiticoneLabel();
            this.userrank = new Siticone.UI.WinForms.SiticoneLabel();
            this.ip = new Siticone.UI.WinForms.SiticoneLabel();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.siticoneShadowForm = new Siticone.UI.WinForms.SiticoneShadowForm(this.components);
            this.helpbutton = new System.Windows.Forms.Timer(this.components);
            this.siticoneAnimateWindow1 = new Siticone.UI.WinForms.SiticoneAnimateWindow(this.components);
            this.cooldown = new System.Windows.Forms.Timer(this.components);
            this.rank1 = new System.Windows.Forms.Timer(this.components);
            this.rank2 = new System.Windows.Forms.Timer(this.components);
            this.rank3 = new System.Windows.Forms.Timer(this.components);
            this.pagecolor = new System.Windows.Forms.ColorDialog();
            this.buttonback = new System.Windows.Forms.ColorDialog();
            this.buttonfill = new System.Windows.Forms.ColorDialog();
            this.status = new System.Windows.Forms.Timer(this.components);
            this.cooldown1 = new System.Windows.Forms.Timer(this.components);
            this.wait2 = new System.Windows.Forms.Timer(this.components);
            this.timerR = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.groupBox22.SuspendLayout();
            this.groupBox21.SuspendLayout();
            this.groupBox20.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = this;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneControlBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneControlBox1.BorderRadius = 10;
            this.siticoneTransition1.SetDecoration(this.siticoneControlBox1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneControlBox1.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.siticoneControlBox1.HoveredState.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.Location = new System.Drawing.Point(896, 5);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.Size = new System.Drawing.Size(52, 29);
            this.siticoneControlBox1.TabIndex = 1;
            this.siticoneControlBox1.Click += new System.EventHandler(this.siticoneControlBox1_Click);
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneControlBox2.BorderRadius = 10;
            this.siticoneControlBox2.ControlBoxType = Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneTransition1.SetDecoration(this.siticoneControlBox2, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneControlBox2.HoveredState.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox2.Location = new System.Drawing.Point(833, 5);
            this.siticoneControlBox2.Name = "siticoneControlBox2";
            this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.Size = new System.Drawing.Size(52, 29);
            this.siticoneControlBox2.TabIndex = 2;
            // 
            // siticoneTransition1
            // 
            this.siticoneTransition1.AnimationType = Siticone.UI.AnimatorNS.AnimationType.Rotate;
            this.siticoneTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(50);
            animation1.RotateCoeff = 1F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.siticoneTransition1.DefaultAnimation = animation1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-1, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label2, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(12, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 19);
            this.label2.TabIndex = 27;
            // 
            // siticoneRoundedButton1
            // 
            this.siticoneRoundedButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton1.CheckedState.Parent = this.siticoneRoundedButton1;
            this.siticoneRoundedButton1.CustomImages.Parent = this.siticoneRoundedButton1;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton1.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton1.HoveredState.Parent = this.siticoneRoundedButton1;
            this.siticoneRoundedButton1.Image = ((System.Drawing.Image)(resources.GetObject("siticoneRoundedButton1.Image")));
            this.siticoneRoundedButton1.Location = new System.Drawing.Point(10, 61);
            this.siticoneRoundedButton1.Name = "siticoneRoundedButton1";
            this.siticoneRoundedButton1.ShadowDecoration.Parent = this.siticoneRoundedButton1;
            this.siticoneRoundedButton1.Size = new System.Drawing.Size(188, 35);
            this.siticoneRoundedButton1.TabIndex = 1;
            this.siticoneRoundedButton1.Text = "Home";
            this.siticoneRoundedButton1.Click += new System.EventHandler(this.siticoneRoundedButton1_Click_1);
            // 
            // siticoneRoundedButton3
            // 
            this.siticoneRoundedButton3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton3.CheckedState.Parent = this.siticoneRoundedButton3;
            this.siticoneRoundedButton3.CustomImages.Parent = this.siticoneRoundedButton3;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton3, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton3.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.siticoneRoundedButton3.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton3.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton3.HoveredState.Parent = this.siticoneRoundedButton3;
            this.siticoneRoundedButton3.Image = ((System.Drawing.Image)(resources.GetObject("siticoneRoundedButton3.Image")));
            this.siticoneRoundedButton3.Location = new System.Drawing.Point(10, 108);
            this.siticoneRoundedButton3.Name = "siticoneRoundedButton3";
            this.siticoneRoundedButton3.ShadowDecoration.Parent = this.siticoneRoundedButton3;
            this.siticoneRoundedButton3.Size = new System.Drawing.Size(188, 35);
            this.siticoneRoundedButton3.TabIndex = 2;
            this.siticoneRoundedButton3.Text = "IP Tools";
            this.siticoneRoundedButton3.Click += new System.EventHandler(this.siticoneRoundedButton3_Click);
            // 
            // siticoneRoundedButton4
            // 
            this.siticoneRoundedButton4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton4.CheckedState.Parent = this.siticoneRoundedButton4;
            this.siticoneRoundedButton4.CustomImages.Parent = this.siticoneRoundedButton4;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton4, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton4.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.siticoneRoundedButton4.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton4.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton4.HoveredState.Parent = this.siticoneRoundedButton4;
            this.siticoneRoundedButton4.Image = ((System.Drawing.Image)(resources.GetObject("siticoneRoundedButton4.Image")));
            this.siticoneRoundedButton4.Location = new System.Drawing.Point(10, 158);
            this.siticoneRoundedButton4.Name = "siticoneRoundedButton4";
            this.siticoneRoundedButton4.ShadowDecoration.Parent = this.siticoneRoundedButton4;
            this.siticoneRoundedButton4.Size = new System.Drawing.Size(188, 35);
            this.siticoneRoundedButton4.TabIndex = 3;
            this.siticoneRoundedButton4.Text = "Other Tools";
            this.siticoneRoundedButton4.Click += new System.EventHandler(this.siticoneRoundedButton4_Click);
            // 
            // siticoneRoundedButton5
            // 
            this.siticoneRoundedButton5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton5.CheckedState.Parent = this.siticoneRoundedButton5;
            this.siticoneRoundedButton5.CustomImages.Parent = this.siticoneRoundedButton5;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton5, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton5.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.siticoneRoundedButton5.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton5.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton5.HoveredState.Parent = this.siticoneRoundedButton5;
            this.siticoneRoundedButton5.Image = ((System.Drawing.Image)(resources.GetObject("siticoneRoundedButton5.Image")));
            this.siticoneRoundedButton5.Location = new System.Drawing.Point(10, 306);
            this.siticoneRoundedButton5.Name = "siticoneRoundedButton5";
            this.siticoneRoundedButton5.ShadowDecoration.Parent = this.siticoneRoundedButton5;
            this.siticoneRoundedButton5.Size = new System.Drawing.Size(188, 35);
            this.siticoneRoundedButton5.TabIndex = 6;
            this.siticoneRoundedButton5.Text = "Data Saver";
            this.siticoneRoundedButton5.Click += new System.EventHandler(this.siticoneRoundedButton5_Click);
            // 
            // siticoneRoundedButton6
            // 
            this.siticoneRoundedButton6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton6.CheckedState.Parent = this.siticoneRoundedButton6;
            this.siticoneRoundedButton6.CustomImages.Parent = this.siticoneRoundedButton6;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton6, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton6.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.siticoneRoundedButton6.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton6.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton6.HoveredState.Parent = this.siticoneRoundedButton6;
            this.siticoneRoundedButton6.Image = ((System.Drawing.Image)(resources.GetObject("siticoneRoundedButton6.Image")));
            this.siticoneRoundedButton6.Location = new System.Drawing.Point(9, 401);
            this.siticoneRoundedButton6.Name = "siticoneRoundedButton6";
            this.siticoneRoundedButton6.ShadowDecoration.Parent = this.siticoneRoundedButton6;
            this.siticoneRoundedButton6.Size = new System.Drawing.Size(188, 35);
            this.siticoneRoundedButton6.TabIndex = 8;
            this.siticoneRoundedButton6.Text = "Support";
            this.siticoneRoundedButton6.Click += new System.EventHandler(this.siticoneRoundedButton6_Click);
            // 
            // siticoneRoundedButton7
            // 
            this.siticoneRoundedButton7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton7.CheckedState.Parent = this.siticoneRoundedButton7;
            this.siticoneRoundedButton7.CustomImages.Parent = this.siticoneRoundedButton7;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton7, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton7.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.siticoneRoundedButton7.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton7.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton7.HoveredState.Parent = this.siticoneRoundedButton7;
            this.siticoneRoundedButton7.Image = ((System.Drawing.Image)(resources.GetObject("siticoneRoundedButton7.Image")));
            this.siticoneRoundedButton7.Location = new System.Drawing.Point(10, 256);
            this.siticoneRoundedButton7.Name = "siticoneRoundedButton7";
            this.siticoneRoundedButton7.ShadowDecoration.Parent = this.siticoneRoundedButton7;
            this.siticoneRoundedButton7.Size = new System.Drawing.Size(188, 35);
            this.siticoneRoundedButton7.TabIndex = 5;
            this.siticoneRoundedButton7.Text = "Account Generator";
            this.siticoneRoundedButton7.Click += new System.EventHandler(this.siticoneRoundedButton7_Click);
            // 
            // siticoneRoundedButton8
            // 
            this.siticoneRoundedButton8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton8.CheckedState.Parent = this.siticoneRoundedButton8;
            this.siticoneRoundedButton8.CustomImages.Parent = this.siticoneRoundedButton8;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton8, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton8.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.siticoneRoundedButton8.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton8.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton8.HoveredState.Parent = this.siticoneRoundedButton8;
            this.siticoneRoundedButton8.Image = ((System.Drawing.Image)(resources.GetObject("siticoneRoundedButton8.Image")));
            this.siticoneRoundedButton8.Location = new System.Drawing.Point(10, 355);
            this.siticoneRoundedButton8.Name = "siticoneRoundedButton8";
            this.siticoneRoundedButton8.ShadowDecoration.Parent = this.siticoneRoundedButton8;
            this.siticoneRoundedButton8.Size = new System.Drawing.Size(188, 35);
            this.siticoneRoundedButton8.TabIndex = 7;
            this.siticoneRoundedButton8.Text = "Message Encrypt";
            this.siticoneRoundedButton8.Click += new System.EventHandler(this.siticoneRoundedButton8_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.siticoneTransition1.SetDecoration(this.tabControl1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.tabControl1.Location = new System.Drawing.Point(204, 49);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(789, 482);
            this.tabControl1.TabIndex = 56;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.siticoneLabel2);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.siticoneTransition1.SetDecoration(this.tabPage1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(781, 456);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label5);
            this.siticoneTransition1.SetDecoration(this.groupBox1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(324, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 145);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Your Account Info";
            // 
            // label20
            // 
            this.siticoneTransition1.SetDecoration(this.label20, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(5, 23);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(192, 20);
            this.label20.TabIndex = 17;
            this.label20.Text = "Checking, please wait";
            // 
            // label19
            // 
            this.siticoneTransition1.SetDecoration(this.label19, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(6, 46);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(192, 20);
            this.label19.TabIndex = 16;
            this.label19.Text = "Checking, please wait";
            // 
            // label14
            // 
            this.siticoneTransition1.SetDecoration(this.label14, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(6, 116);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(192, 20);
            this.label14.TabIndex = 14;
            this.label14.Text = "Checking, please wait";
            // 
            // label15
            // 
            this.siticoneTransition1.SetDecoration(this.label15, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(5, 93);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(192, 20);
            this.label15.TabIndex = 15;
            this.label15.Text = "Checking, please wait";
            // 
            // label5
            // 
            this.siticoneTransition1.SetDecoration(this.label5, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(5, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Checking, please wait";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.siticoneRoundedButton12);
            this.groupBox3.Controls.Add(this.siticoneRoundedButton11);
            this.groupBox3.Controls.Add(this.label16);
            this.siticoneTransition1.SetDecoration(this.groupBox3, Siticone.UI.AnimatorNS.DecorationType.None);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(12, 44);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(300, 147);
            this.groupBox3.TabIndex = 53;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Suggestions Tab";
            // 
            // label6
            // 
            this.siticoneTransition1.SetDecoration(this.label6, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(5, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(264, 44);
            this.label6.TabIndex = 13;
            this.label6.Text = "In IP Tools, you can use tools like:\r\nlookup, ping, port scanner and more";
            // 
            // siticoneRoundedButton12
            // 
            this.siticoneRoundedButton12.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton12.BorderThickness = 9999;
            this.siticoneRoundedButton12.CheckedState.Parent = this.siticoneRoundedButton12;
            this.siticoneRoundedButton12.CustomImages.Parent = this.siticoneRoundedButton12;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton12, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton12.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton12.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.siticoneRoundedButton12.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton12.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton12.HoveredState.Parent = this.siticoneRoundedButton12;
            this.siticoneRoundedButton12.Location = new System.Drawing.Point(159, 103);
            this.siticoneRoundedButton12.Name = "siticoneRoundedButton12";
            this.siticoneRoundedButton12.ShadowDecoration.Parent = this.siticoneRoundedButton12;
            this.siticoneRoundedButton12.Size = new System.Drawing.Size(131, 25);
            this.siticoneRoundedButton12.TabIndex = 1;
            this.siticoneRoundedButton12.Text = "Open Stresser";
            this.siticoneRoundedButton12.Click += new System.EventHandler(this.siticoneRoundedButton12_Click);
            // 
            // siticoneRoundedButton11
            // 
            this.siticoneRoundedButton11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton11.BorderThickness = 9999;
            this.siticoneRoundedButton11.CheckedState.Parent = this.siticoneRoundedButton11;
            this.siticoneRoundedButton11.CustomImages.Parent = this.siticoneRoundedButton11;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton11, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton11.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton11.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.siticoneRoundedButton11.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton11.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton11.HoveredState.Parent = this.siticoneRoundedButton11;
            this.siticoneRoundedButton11.Location = new System.Drawing.Point(9, 103);
            this.siticoneRoundedButton11.Name = "siticoneRoundedButton11";
            this.siticoneRoundedButton11.ShadowDecoration.Parent = this.siticoneRoundedButton11;
            this.siticoneRoundedButton11.Size = new System.Drawing.Size(136, 25);
            this.siticoneRoundedButton11.TabIndex = 0;
            this.siticoneRoundedButton11.Text = "Open Tools";
            this.siticoneRoundedButton11.Click += new System.EventHandler(this.siticoneRoundedButton11_Click);
            // 
            // label16
            // 
            this.siticoneTransition1.SetDecoration(this.label16, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(6, 69);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(264, 25);
            this.label16.TabIndex = 10;
            this.label16.Text = "Stresser has basic and good methods";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.siticoneTransition1.SetDecoration(this.groupBox2, Siticone.UI.AnimatorNS.DecorationType.None);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(322, 188);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 184);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "My IP Info";
            // 
            // checkBox1
            // 
            this.siticoneTransition1.SetDecoration(this.checkBox1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.checkBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(3, 157);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(205, 24);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Show My Current IP Info";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.siticoneTransition1.SetDecoration(this.richTextBox1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.HideSelection = false;
            this.richTextBox1.Location = new System.Drawing.Point(3, 23);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(205, 121);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "IP Address: Hidden\nCountry: Hidden\nState: Hidden\nCity: Hidden\nLatitude: Hidden\nLo" +
    "ngitude: Hidden";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.updatebox);
            this.siticoneTransition1.SetDecoration(this.groupBox5, Siticone.UI.AnimatorNS.DecorationType.None);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(12, 191);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(300, 181);
            this.groupBox5.TabIndex = 50;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "News Tab";
            // 
            // updatebox
            // 
            this.updatebox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.updatebox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.updatebox.Cursor = System.Windows.Forms.Cursors.Default;
            this.siticoneTransition1.SetDecoration(this.updatebox, Siticone.UI.AnimatorNS.DecorationType.None);
            this.updatebox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updatebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F);
            this.updatebox.ForeColor = System.Drawing.Color.White;
            this.updatebox.Location = new System.Drawing.Point(3, 23);
            this.updatebox.Name = "updatebox";
            this.updatebox.ReadOnly = true;
            this.updatebox.Size = new System.Drawing.Size(294, 155);
            this.updatebox.TabIndex = 0;
            this.updatebox.Text = "";
            // 
            // siticoneLabel2
            // 
            this.siticoneLabel2.AutoSize = false;
            this.siticoneLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneTransition1.SetDecoration(this.siticoneLabel2, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneLabel2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.siticoneLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.siticoneLabel2.IsSelectionEnabled = false;
            this.siticoneLabel2.Location = new System.Drawing.Point(11, 16);
            this.siticoneLabel2.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneLabel2.Name = "siticoneLabel2";
            this.siticoneLabel2.Size = new System.Drawing.Size(681, 27);
            this.siticoneLabel2.TabIndex = 49;
            this.siticoneLabel2.Text = "Welcome Back: User  |  Account Expiry: 00000";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.siticoneRoundedButton28);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.IPStatus);
            this.siticoneTransition1.SetDecoration(this.groupBox4, Siticone.UI.AnimatorNS.DecorationType.None);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(543, 44);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(189, 328);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Connection Status";
            // 
            // siticoneRoundedButton28
            // 
            this.siticoneRoundedButton28.BackColor = System.Drawing.Color.Transparent;
            this.siticoneRoundedButton28.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton28.BorderThickness = 9999;
            this.siticoneRoundedButton28.CheckedState.Parent = this.siticoneRoundedButton28;
            this.siticoneRoundedButton28.CustomImages.Parent = this.siticoneRoundedButton28;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton28, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton28.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton28.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.siticoneRoundedButton28.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton28.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton28.HoveredState.Parent = this.siticoneRoundedButton28;
            this.siticoneRoundedButton28.Location = new System.Drawing.Point(15, 284);
            this.siticoneRoundedButton28.Name = "siticoneRoundedButton28";
            this.siticoneRoundedButton28.ShadowDecoration.Parent = this.siticoneRoundedButton28;
            this.siticoneRoundedButton28.Size = new System.Drawing.Size(156, 30);
            this.siticoneRoundedButton28.TabIndex = 3;
            this.siticoneRoundedButton28.Text = "Check Again";
            this.siticoneRoundedButton28.Click += new System.EventHandler(this.siticoneRoundedButton28_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label3, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(11, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Checking, please wait";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label4, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Stress Server Status:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label8, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(13, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Your WIFI Status:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label12, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(12, 112);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(162, 20);
            this.label12.TabIndex = 17;
            this.label12.Text = "Checking, please wait";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label13, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(11, 85);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(162, 20);
            this.label13.TabIndex = 16;
            this.label13.Text = "Account Gen. Status:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label10, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(10, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(162, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Checking, please wait";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label11, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(11, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "API Tools Status:";
            // 
            // label9
            // 
            this.siticoneTransition1.SetDecoration(this.label9, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label9.Location = new System.Drawing.Point(9, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 21);
            this.label9.TabIndex = 13;
            this.label9.Text = "___________________";
            // 
            // IPStatus
            // 
            this.IPStatus.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.IPStatus, Siticone.UI.AnimatorNS.DecorationType.None);
            this.IPStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.IPStatus.ForeColor = System.Drawing.Color.White;
            this.IPStatus.Location = new System.Drawing.Point(14, 248);
            this.IPStatus.Name = "IPStatus";
            this.IPStatus.Size = new System.Drawing.Size(162, 20);
            this.IPStatus.TabIndex = 12;
            this.IPStatus.Text = "Checking, please wait";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.tabPage2.Controls.Add(this.groupBox7);
            this.tabPage2.Controls.Add(this.groupBox8);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.siticoneTransition1.SetDecoration(this.tabPage2, Siticone.UI.AnimatorNS.DecorationType.None);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(781, 456);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.richTextBox2);
            this.siticoneTransition1.SetDecoration(this.groupBox7, Siticone.UI.AnimatorNS.DecorationType.None);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox7.ForeColor = System.Drawing.Color.White;
            this.groupBox7.Location = new System.Drawing.Point(324, 1);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(413, 368);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Output Box ";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.siticoneTransition1.SetDecoration(this.richTextBox2, Siticone.UI.AnimatorNS.DecorationType.None);
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.richTextBox2.ForeColor = System.Drawing.Color.White;
            this.richTextBox2.Location = new System.Drawing.Point(3, 25);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(407, 340);
            this.richTextBox2.TabIndex = 8;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.siticoneRoundedButton17);
            this.groupBox8.Controls.Add(this.siticoneRoundedButton16);
            this.siticoneTransition1.SetDecoration(this.groupBox8, Siticone.UI.AnimatorNS.DecorationType.None);
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox8.ForeColor = System.Drawing.Color.White;
            this.groupBox8.Location = new System.Drawing.Point(12, 1);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(303, 58);
            this.groupBox8.TabIndex = 2;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Ping options";
            // 
            // siticoneRoundedButton17
            // 
            this.siticoneRoundedButton17.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton17.BorderThickness = 100;
            this.siticoneRoundedButton17.CheckedState.Parent = this.siticoneRoundedButton17;
            this.siticoneRoundedButton17.CustomImages.Parent = this.siticoneRoundedButton17;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton17, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton17.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton17.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.siticoneRoundedButton17.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton17.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton17.HoveredState.Parent = this.siticoneRoundedButton17;
            this.siticoneRoundedButton17.Location = new System.Drawing.Point(160, 25);
            this.siticoneRoundedButton17.Name = "siticoneRoundedButton17";
            this.siticoneRoundedButton17.ShadowDecoration.Parent = this.siticoneRoundedButton17;
            this.siticoneRoundedButton17.Size = new System.Drawing.Size(132, 24);
            this.siticoneRoundedButton17.TabIndex = 4;
            this.siticoneRoundedButton17.Text = "Ping in Output Box";
            this.siticoneRoundedButton17.Click += new System.EventHandler(this.siticoneRoundedButton17_Click);
            // 
            // siticoneRoundedButton16
            // 
            this.siticoneRoundedButton16.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton16.BorderThickness = 100;
            this.siticoneRoundedButton16.CheckedState.Parent = this.siticoneRoundedButton16;
            this.siticoneRoundedButton16.CustomImages.Parent = this.siticoneRoundedButton16;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton16, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton16.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton16.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.siticoneRoundedButton16.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton16.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton16.HoveredState.Parent = this.siticoneRoundedButton16;
            this.siticoneRoundedButton16.Location = new System.Drawing.Point(11, 25);
            this.siticoneRoundedButton16.Name = "siticoneRoundedButton16";
            this.siticoneRoundedButton16.ShadowDecoration.Parent = this.siticoneRoundedButton16;
            this.siticoneRoundedButton16.Size = new System.Drawing.Size(135, 24);
            this.siticoneRoundedButton16.TabIndex = 5;
            this.siticoneRoundedButton16.Text = "ICMP Ping in CMD";
            this.siticoneRoundedButton16.Click += new System.EventHandler(this.siticoneRoundedButton16_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.siticoneRoundedButton18);
            this.groupBox6.Controls.Add(this.siticoneRoundedButton14);
            this.groupBox6.Controls.Add(this.siticoneRoundedButton15);
            this.groupBox6.Controls.Add(this.siticoneRoundedButton13);
            this.groupBox6.Controls.Add(this.action);
            this.groupBox6.Controls.Add(this.porttext);
            this.groupBox6.Controls.Add(this.iptext);
            this.siticoneTransition1.SetDecoration(this.groupBox6, Siticone.UI.AnimatorNS.DecorationType.None);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox6.Location = new System.Drawing.Point(12, 61);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(303, 308);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            // 
            // siticoneRoundedButton18
            // 
            this.siticoneRoundedButton18.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton18.BorderThickness = 100;
            this.siticoneRoundedButton18.CheckedState.Parent = this.siticoneRoundedButton18;
            this.siticoneRoundedButton18.CustomImages.Parent = this.siticoneRoundedButton18;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton18, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton18.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton18.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.siticoneRoundedButton18.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton18.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton18.HoveredState.Parent = this.siticoneRoundedButton18;
            this.siticoneRoundedButton18.Location = new System.Drawing.Point(156, 251);
            this.siticoneRoundedButton18.Name = "siticoneRoundedButton18";
            this.siticoneRoundedButton18.ShadowDecoration.Parent = this.siticoneRoundedButton18;
            this.siticoneRoundedButton18.Size = new System.Drawing.Size(132, 32);
            this.siticoneRoundedButton18.TabIndex = 12;
            this.siticoneRoundedButton18.Text = "Clear Output Box";
            this.siticoneRoundedButton18.Click += new System.EventHandler(this.siticoneRoundedButton18_Click);
            // 
            // siticoneRoundedButton14
            // 
            this.siticoneRoundedButton14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton14.BorderThickness = 100;
            this.siticoneRoundedButton14.CheckedState.Parent = this.siticoneRoundedButton14;
            this.siticoneRoundedButton14.CustomImages.Parent = this.siticoneRoundedButton14;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton14, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton14.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.siticoneRoundedButton14.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton14.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton14.HoveredState.Parent = this.siticoneRoundedButton14;
            this.siticoneRoundedButton14.Location = new System.Drawing.Point(14, 188);
            this.siticoneRoundedButton14.Name = "siticoneRoundedButton14";
            this.siticoneRoundedButton14.ShadowDecoration.Parent = this.siticoneRoundedButton14;
            this.siticoneRoundedButton14.Size = new System.Drawing.Size(274, 35);
            this.siticoneRoundedButton14.TabIndex = 10;
            this.siticoneRoundedButton14.Text = "Start";
            this.siticoneRoundedButton14.Click += new System.EventHandler(this.siticoneRoundedButton14_Click);
            // 
            // siticoneRoundedButton15
            // 
            this.siticoneRoundedButton15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton15.BorderThickness = 100;
            this.siticoneRoundedButton15.CheckedState.Parent = this.siticoneRoundedButton15;
            this.siticoneRoundedButton15.CustomImages.Parent = this.siticoneRoundedButton15;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton15, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton15.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton15.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.siticoneRoundedButton15.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton15.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton15.HoveredState.Parent = this.siticoneRoundedButton15;
            this.siticoneRoundedButton15.Location = new System.Drawing.Point(14, 251);
            this.siticoneRoundedButton15.Name = "siticoneRoundedButton15";
            this.siticoneRoundedButton15.ShadowDecoration.Parent = this.siticoneRoundedButton15;
            this.siticoneRoundedButton15.Size = new System.Drawing.Size(130, 32);
            this.siticoneRoundedButton15.TabIndex = 11;
            this.siticoneRoundedButton15.Text = "Copy Output Text";
            this.siticoneRoundedButton15.Click += new System.EventHandler(this.siticoneRoundedButton15_Click);
            // 
            // siticoneRoundedButton13
            // 
            this.siticoneRoundedButton13.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton13.BorderThickness = 100;
            this.siticoneRoundedButton13.CheckedState.Parent = this.siticoneRoundedButton13;
            this.siticoneRoundedButton13.CustomImages.Parent = this.siticoneRoundedButton13;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton13, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton13.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton13.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.siticoneRoundedButton13.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton13.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton13.HoveredState.Parent = this.siticoneRoundedButton13;
            this.siticoneRoundedButton13.Location = new System.Drawing.Point(154, 135);
            this.siticoneRoundedButton13.Name = "siticoneRoundedButton13";
            this.siticoneRoundedButton13.ShadowDecoration.Parent = this.siticoneRoundedButton13;
            this.siticoneRoundedButton13.Size = new System.Drawing.Size(134, 35);
            this.siticoneRoundedButton13.TabIndex = 9;
            this.siticoneRoundedButton13.Text = "TCP Ping";
            this.siticoneRoundedButton13.Click += new System.EventHandler(this.siticoneRoundedButton13_Click);
            // 
            // action
            // 
            this.action.Animated = true;
            this.action.BackColor = System.Drawing.Color.Transparent;
            this.action.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.action.BorderThickness = 0;
            this.siticoneTransition1.SetDecoration(this.action, Siticone.UI.AnimatorNS.DecorationType.None);
            this.action.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.action.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.action.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.action.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.action.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.action.FormattingEnabled = true;
            this.action.HoveredState.Parent = this.action;
            this.action.ItemHeight = 30;
            this.action.Items.AddRange(new object[] {
            "Geo IP",
            "Nmap Port Scan",
            "Custom Port Scan",
            "Who Is",
            "Subnet Lookup",
            "Traceroute"});
            this.action.ItemsAppearance.Parent = this.action;
            this.action.Location = new System.Drawing.Point(14, 81);
            this.action.Name = "action";
            this.action.ShadowDecoration.Parent = this.action;
            this.action.Size = new System.Drawing.Size(274, 36);
            this.action.StartIndex = 0;
            this.action.TabIndex = 7;
            // 
            // porttext
            // 
            this.porttext.Animated = false;
            this.porttext.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.porttext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.porttext, Siticone.UI.AnimatorNS.DecorationType.None);
            this.porttext.DefaultText = "";
            this.porttext.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.porttext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.porttext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.porttext.DisabledState.Parent = this.porttext;
            this.porttext.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.porttext.FillColor = System.Drawing.Color.WhiteSmoke;
            this.porttext.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.porttext.FocusedState.Parent = this.porttext;
            this.porttext.ForeColor = System.Drawing.Color.Black;
            this.porttext.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.porttext.HoveredState.Parent = this.porttext;
            this.porttext.Location = new System.Drawing.Point(15, 135);
            this.porttext.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.porttext.Name = "porttext";
            this.porttext.PasswordChar = '\0';
            this.porttext.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.porttext.PlaceholderText = "Enter Port";
            this.porttext.SelectedText = "";
            this.porttext.ShadowDecoration.Parent = this.porttext;
            this.porttext.Size = new System.Drawing.Size(130, 35);
            this.porttext.TabIndex = 8;
            // 
            // iptext
            // 
            this.iptext.Animated = false;
            this.iptext.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.iptext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.iptext, Siticone.UI.AnimatorNS.DecorationType.None);
            this.iptext.DefaultText = "";
            this.iptext.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.iptext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.iptext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.iptext.DisabledState.Parent = this.iptext;
            this.iptext.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.iptext.FillColor = System.Drawing.Color.WhiteSmoke;
            this.iptext.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.iptext.FocusedState.Parent = this.iptext;
            this.iptext.ForeColor = System.Drawing.Color.Black;
            this.iptext.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.iptext.HoveredState.Parent = this.iptext;
            this.iptext.IconLeft = ((System.Drawing.Image)(resources.GetObject("iptext.IconLeft")));
            this.iptext.Location = new System.Drawing.Point(15, 29);
            this.iptext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iptext.Name = "iptext";
            this.iptext.PasswordChar = '\0';
            this.iptext.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.iptext.PlaceholderText = "Enter Host";
            this.iptext.SelectedText = "";
            this.iptext.ShadowDecoration.Parent = this.iptext;
            this.iptext.Size = new System.Drawing.Size(274, 35);
            this.iptext.TabIndex = 6;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.tabPage3.Controls.Add(this.groupBox14);
            this.tabPage3.Controls.Add(this.groupBox9);
            this.tabPage3.Controls.Add(this.groupBox10);
            this.siticoneTransition1.SetDecoration(this.tabPage3, Siticone.UI.AnimatorNS.DecorationType.None);
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(781, 456);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.siticoneRoundedButton27);
            this.groupBox14.Controls.Add(this.siticoneRoundedButton10);
            this.siticoneTransition1.SetDecoration(this.groupBox14, Siticone.UI.AnimatorNS.DecorationType.None);
            this.groupBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox14.ForeColor = System.Drawing.Color.White;
            this.groupBox14.Location = new System.Drawing.Point(12, 13);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(303, 94);
            this.groupBox14.TabIndex = 57;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Tools options";
            // 
            // siticoneRoundedButton27
            // 
            this.siticoneRoundedButton27.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton27.BorderThickness = 100;
            this.siticoneRoundedButton27.CheckedState.Parent = this.siticoneRoundedButton27;
            this.siticoneRoundedButton27.CustomImages.Parent = this.siticoneRoundedButton27;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton27, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton27.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton27.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.siticoneRoundedButton27.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton27.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton27.HoveredState.Parent = this.siticoneRoundedButton27;
            this.siticoneRoundedButton27.Location = new System.Drawing.Point(12, 58);
            this.siticoneRoundedButton27.Name = "siticoneRoundedButton27";
            this.siticoneRoundedButton27.ShadowDecoration.Parent = this.siticoneRoundedButton27;
            this.siticoneRoundedButton27.Size = new System.Drawing.Size(278, 24);
            this.siticoneRoundedButton27.TabIndex = 14;
            this.siticoneRoundedButton27.Text = "Open  1.1.1.1 Pinger";
            this.siticoneRoundedButton27.Click += new System.EventHandler(this.siticoneRoundedButton27_Click);
            // 
            // siticoneRoundedButton10
            // 
            this.siticoneRoundedButton10.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton10.BorderThickness = 100;
            this.siticoneRoundedButton10.CheckedState.Parent = this.siticoneRoundedButton10;
            this.siticoneRoundedButton10.CustomImages.Parent = this.siticoneRoundedButton10;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton10, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton10.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.siticoneRoundedButton10.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton10.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton10.HoveredState.Parent = this.siticoneRoundedButton10;
            this.siticoneRoundedButton10.Location = new System.Drawing.Point(12, 24);
            this.siticoneRoundedButton10.Name = "siticoneRoundedButton10";
            this.siticoneRoundedButton10.ShadowDecoration.Parent = this.siticoneRoundedButton10;
            this.siticoneRoundedButton10.Size = new System.Drawing.Size(278, 25);
            this.siticoneRoundedButton10.TabIndex = 13;
            this.siticoneRoundedButton10.Text = "Open Password Generator";
            this.siticoneRoundedButton10.Click += new System.EventHandler(this.siticoneRoundedButton10_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.richTextBox3);
            this.siticoneTransition1.SetDecoration(this.groupBox9, Siticone.UI.AnimatorNS.DecorationType.None);
            this.groupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox9.ForeColor = System.Drawing.Color.White;
            this.groupBox9.Location = new System.Drawing.Point(321, 12);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(413, 355);
            this.groupBox9.TabIndex = 56;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Output Box ";
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.siticoneTransition1.SetDecoration(this.richTextBox3, Siticone.UI.AnimatorNS.DecorationType.None);
            this.richTextBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.richTextBox3.ForeColor = System.Drawing.Color.White;
            this.richTextBox3.Location = new System.Drawing.Point(3, 25);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.Size = new System.Drawing.Size(407, 327);
            this.richTextBox3.TabIndex = 8;
            this.richTextBox3.Text = "";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.siticoneRoundedButton19);
            this.groupBox10.Controls.Add(this.siticoneRoundedButton20);
            this.groupBox10.Controls.Add(this.siticoneRoundedButton21);
            this.groupBox10.Controls.Add(this.act);
            this.groupBox10.Controls.Add(this.host);
            this.siticoneTransition1.SetDecoration(this.groupBox10, Siticone.UI.AnimatorNS.DecorationType.None);
            this.groupBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox10.Location = new System.Drawing.Point(12, 105);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(303, 262);
            this.groupBox10.TabIndex = 55;
            this.groupBox10.TabStop = false;
            // 
            // siticoneRoundedButton19
            // 
            this.siticoneRoundedButton19.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton19.BorderThickness = 100;
            this.siticoneRoundedButton19.CheckedState.Parent = this.siticoneRoundedButton19;
            this.siticoneRoundedButton19.CustomImages.Parent = this.siticoneRoundedButton19;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton19, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton19.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton19.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.siticoneRoundedButton19.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton19.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton19.HoveredState.Parent = this.siticoneRoundedButton19;
            this.siticoneRoundedButton19.Location = new System.Drawing.Point(158, 208);
            this.siticoneRoundedButton19.Name = "siticoneRoundedButton19";
            this.siticoneRoundedButton19.ShadowDecoration.Parent = this.siticoneRoundedButton19;
            this.siticoneRoundedButton19.Size = new System.Drawing.Size(132, 32);
            this.siticoneRoundedButton19.TabIndex = 19;
            this.siticoneRoundedButton19.Text = "Clear Output Box";
            this.siticoneRoundedButton19.Click += new System.EventHandler(this.siticoneRoundedButton19_Click);
            // 
            // siticoneRoundedButton20
            // 
            this.siticoneRoundedButton20.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton20.BorderThickness = 100;
            this.siticoneRoundedButton20.CheckedState.Parent = this.siticoneRoundedButton20;
            this.siticoneRoundedButton20.CustomImages.Parent = this.siticoneRoundedButton20;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton20, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton20.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton20.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.siticoneRoundedButton20.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton20.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton20.HoveredState.Parent = this.siticoneRoundedButton20;
            this.siticoneRoundedButton20.Location = new System.Drawing.Point(16, 152);
            this.siticoneRoundedButton20.Name = "siticoneRoundedButton20";
            this.siticoneRoundedButton20.ShadowDecoration.Parent = this.siticoneRoundedButton20;
            this.siticoneRoundedButton20.Size = new System.Drawing.Size(274, 35);
            this.siticoneRoundedButton20.TabIndex = 17;
            this.siticoneRoundedButton20.Text = "Start";
            this.siticoneRoundedButton20.Click += new System.EventHandler(this.siticoneRoundedButton20_Click);
            // 
            // siticoneRoundedButton21
            // 
            this.siticoneRoundedButton21.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton21.BorderThickness = 100;
            this.siticoneRoundedButton21.CheckedState.Parent = this.siticoneRoundedButton21;
            this.siticoneRoundedButton21.CustomImages.Parent = this.siticoneRoundedButton21;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton21, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton21.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton21.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.siticoneRoundedButton21.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton21.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton21.HoveredState.Parent = this.siticoneRoundedButton21;
            this.siticoneRoundedButton21.Location = new System.Drawing.Point(16, 208);
            this.siticoneRoundedButton21.Name = "siticoneRoundedButton21";
            this.siticoneRoundedButton21.ShadowDecoration.Parent = this.siticoneRoundedButton21;
            this.siticoneRoundedButton21.Size = new System.Drawing.Size(130, 32);
            this.siticoneRoundedButton21.TabIndex = 18;
            this.siticoneRoundedButton21.Text = "Copy Output Text";
            this.siticoneRoundedButton21.Click += new System.EventHandler(this.siticoneRoundedButton21_Click);
            // 
            // act
            // 
            this.act.Animated = true;
            this.act.BackColor = System.Drawing.Color.Transparent;
            this.act.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.act.BorderThickness = 0;
            this.siticoneTransition1.SetDecoration(this.act, Siticone.UI.AnimatorNS.DecorationType.None);
            this.act.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.act.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.act.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.act.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.act.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.act.FormattingEnabled = true;
            this.act.HoveredState.Parent = this.act;
            this.act.ItemHeight = 30;
            this.act.Items.AddRange(new object[] {
            "DNS Lookup",
            "Whois Lookup",
            "Reverse IP Lookup",
            "Website Whois",
            "Website Headers",
            "Domain information",
            "IP to Websites",
            "Disposable email checker",
            "CloudFlare Resolver",
            "Page Links"});
            this.act.ItemsAppearance.Parent = this.act;
            this.act.Location = new System.Drawing.Point(16, 91);
            this.act.Name = "act";
            this.act.ShadowDecoration.Parent = this.act;
            this.act.Size = new System.Drawing.Size(274, 36);
            this.act.StartIndex = 0;
            this.act.TabIndex = 16;
            // 
            // host
            // 
            this.host.Animated = false;
            this.host.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.host.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.host, Siticone.UI.AnimatorNS.DecorationType.None);
            this.host.DefaultText = "";
            this.host.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.host.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.host.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.host.DisabledState.Parent = this.host;
            this.host.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.host.FillColor = System.Drawing.Color.WhiteSmoke;
            this.host.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.host.FocusedState.Parent = this.host;
            this.host.ForeColor = System.Drawing.Color.Black;
            this.host.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.host.HoveredState.Parent = this.host;
            this.host.IconLeft = ((System.Drawing.Image)(resources.GetObject("host.IconLeft")));
            this.host.Location = new System.Drawing.Point(16, 34);
            this.host.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.host.Name = "host";
            this.host.PasswordChar = '\0';
            this.host.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.host.PlaceholderText = "Enter Host";
            this.host.SelectedText = "";
            this.host.ShadowDecoration.Parent = this.host;
            this.host.Size = new System.Drawing.Size(274, 35);
            this.host.TabIndex = 15;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.tabPage4.Controls.Add(this.groupBox13);
            this.tabPage4.Controls.Add(this.groupBox12);
            this.tabPage4.Controls.Add(this.groupBox11);
            this.siticoneTransition1.SetDecoration(this.tabPage4, Siticone.UI.AnimatorNS.DecorationType.None);
            this.tabPage4.Location = new System.Drawing.Point(4, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(781, 456);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.siticoneRoundedButton24);
            this.groupBox13.Controls.Add(this.siticoneRoundedButton23);
            this.groupBox13.Controls.Add(this.siticoneRoundedButton22);
            this.siticoneTransition1.SetDecoration(this.groupBox13, Siticone.UI.AnimatorNS.DecorationType.None);
            this.groupBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox13.ForeColor = System.Drawing.Color.White;
            this.groupBox13.Location = new System.Drawing.Point(12, 15);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(309, 68);
            this.groupBox13.TabIndex = 59;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Quick Tools";
            // 
            // siticoneRoundedButton24
            // 
            this.siticoneRoundedButton24.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton24.BorderThickness = 100;
            this.siticoneRoundedButton24.CheckedState.Parent = this.siticoneRoundedButton24;
            this.siticoneRoundedButton24.CustomImages.Parent = this.siticoneRoundedButton24;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton24, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton24.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton24.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.siticoneRoundedButton24.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton24.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton24.HoveredState.Parent = this.siticoneRoundedButton24;
            this.siticoneRoundedButton24.Location = new System.Drawing.Point(208, 25);
            this.siticoneRoundedButton24.Name = "siticoneRoundedButton24";
            this.siticoneRoundedButton24.ShadowDecoration.Parent = this.siticoneRoundedButton24;
            this.siticoneRoundedButton24.Size = new System.Drawing.Size(94, 32);
            this.siticoneRoundedButton24.TabIndex = 21;
            this.siticoneRoundedButton24.Text = "Port Scan";
            this.siticoneRoundedButton24.Click += new System.EventHandler(this.siticoneRoundedButton24_Click);
            // 
            // siticoneRoundedButton23
            // 
            this.siticoneRoundedButton23.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton23.BorderThickness = 100;
            this.siticoneRoundedButton23.CheckedState.Parent = this.siticoneRoundedButton23;
            this.siticoneRoundedButton23.CustomImages.Parent = this.siticoneRoundedButton23;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton23, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton23.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton23.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.siticoneRoundedButton23.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton23.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton23.HoveredState.Parent = this.siticoneRoundedButton23;
            this.siticoneRoundedButton23.Location = new System.Drawing.Point(108, 25);
            this.siticoneRoundedButton23.Name = "siticoneRoundedButton23";
            this.siticoneRoundedButton23.ShadowDecoration.Parent = this.siticoneRoundedButton23;
            this.siticoneRoundedButton23.Size = new System.Drawing.Size(94, 32);
            this.siticoneRoundedButton23.TabIndex = 20;
            this.siticoneRoundedButton23.Text = "Geo Location";
            this.siticoneRoundedButton23.Click += new System.EventHandler(this.siticoneRoundedButton23_Click);
            // 
            // siticoneRoundedButton22
            // 
            this.siticoneRoundedButton22.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton22.BorderThickness = 100;
            this.siticoneRoundedButton22.CheckedState.Parent = this.siticoneRoundedButton22;
            this.siticoneRoundedButton22.CustomImages.Parent = this.siticoneRoundedButton22;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton22, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton22.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton22.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.siticoneRoundedButton22.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton22.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton22.HoveredState.Parent = this.siticoneRoundedButton22;
            this.siticoneRoundedButton22.Location = new System.Drawing.Point(7, 25);
            this.siticoneRoundedButton22.Name = "siticoneRoundedButton22";
            this.siticoneRoundedButton22.ShadowDecoration.Parent = this.siticoneRoundedButton22;
            this.siticoneRoundedButton22.Size = new System.Drawing.Size(94, 32);
            this.siticoneRoundedButton22.TabIndex = 18;
            this.siticoneRoundedButton22.Text = "CMD Ping";
            this.siticoneRoundedButton22.Click += new System.EventHandler(this.siticoneRoundedButton22_Click);
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.nigger);
            this.groupBox12.Controls.Add(this.timeattack);
            this.groupBox12.Controls.Add(this.stresshost);
            this.groupBox12.Controls.Add(this.siticoneComboBox1);
            this.groupBox12.Controls.Add(this.startattack);
            this.groupBox12.Controls.Add(this.siticoneMaterialTextBox1);
            this.siticoneTransition1.SetDecoration(this.groupBox12, Siticone.UI.AnimatorNS.DecorationType.None);
            this.groupBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox12.ForeColor = System.Drawing.Color.White;
            this.groupBox12.Location = new System.Drawing.Point(12, 83);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(309, 283);
            this.groupBox12.TabIndex = 58;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Stresser";
            // 
            // nigger
            // 
            this.nigger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneTransition1.SetDecoration(this.nigger, Siticone.UI.AnimatorNS.DecorationType.None);
            this.nigger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nigger.ForeColor = System.Drawing.Color.White;
            this.nigger.Location = new System.Drawing.Point(10, 249);
            this.nigger.Name = "nigger";
            this.nigger.Size = new System.Drawing.Size(286, 20);
            this.nigger.TabIndex = 27;
            this.nigger.Text = "Cooldown Status: Off";
            this.nigger.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeattack
            // 
            this.timeattack.Animated = false;
            this.timeattack.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.timeattack.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.timeattack, Siticone.UI.AnimatorNS.DecorationType.None);
            this.timeattack.DefaultText = "";
            this.timeattack.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.timeattack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.timeattack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.timeattack.DisabledState.Parent = this.timeattack;
            this.timeattack.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.timeattack.FillColor = System.Drawing.Color.WhiteSmoke;
            this.timeattack.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.timeattack.FocusedState.Parent = this.timeattack;
            this.timeattack.ForeColor = System.Drawing.Color.Black;
            this.timeattack.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.timeattack.HoveredState.Parent = this.timeattack;
            this.timeattack.Location = new System.Drawing.Point(157, 84);
            this.timeattack.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.timeattack.Name = "timeattack";
            this.timeattack.PasswordChar = '\0';
            this.timeattack.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.timeattack.PlaceholderText = "Enter Time";
            this.timeattack.SelectedText = "";
            this.timeattack.ShadowDecoration.Parent = this.timeattack;
            this.timeattack.Size = new System.Drawing.Size(140, 33);
            this.timeattack.TabIndex = 24;
            // 
            // stresshost
            // 
            this.stresshost.Animated = false;
            this.stresshost.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.stresshost.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.stresshost, Siticone.UI.AnimatorNS.DecorationType.None);
            this.stresshost.DefaultText = "";
            this.stresshost.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.stresshost.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.stresshost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.stresshost.DisabledState.Parent = this.stresshost;
            this.stresshost.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.stresshost.FillColor = System.Drawing.Color.WhiteSmoke;
            this.stresshost.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.stresshost.FocusedState.Parent = this.stresshost;
            this.stresshost.ForeColor = System.Drawing.Color.Black;
            this.stresshost.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.stresshost.HoveredState.Parent = this.stresshost;
            this.stresshost.IconLeft = ((System.Drawing.Image)(resources.GetObject("stresshost.IconLeft")));
            this.stresshost.Location = new System.Drawing.Point(11, 33);
            this.stresshost.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.stresshost.Name = "stresshost";
            this.stresshost.PasswordChar = '\0';
            this.stresshost.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.stresshost.PlaceholderText = "Enter IP";
            this.stresshost.SelectedText = "";
            this.stresshost.ShadowDecoration.Parent = this.stresshost;
            this.stresshost.Size = new System.Drawing.Size(286, 34);
            this.stresshost.TabIndex = 22;
            // 
            // siticoneComboBox1
            // 
            this.siticoneComboBox1.Animated = true;
            this.siticoneComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneComboBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneComboBox1.BorderThickness = 0;
            this.siticoneTransition1.SetDecoration(this.siticoneComboBox1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.siticoneComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.siticoneComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.siticoneComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.siticoneComboBox1.FormattingEnabled = true;
            this.siticoneComboBox1.HoveredState.Parent = this.siticoneComboBox1;
            this.siticoneComboBox1.ItemHeight = 30;
            this.siticoneComboBox1.Items.AddRange(new object[] {
            "STDHEX",
            "UDP",
            "VSE",
            "TCP"});
            this.siticoneComboBox1.ItemsAppearance.Parent = this.siticoneComboBox1;
            this.siticoneComboBox1.Location = new System.Drawing.Point(11, 132);
            this.siticoneComboBox1.Name = "siticoneComboBox1";
            this.siticoneComboBox1.ShadowDecoration.Parent = this.siticoneComboBox1;
            this.siticoneComboBox1.Size = new System.Drawing.Size(286, 36);
            this.siticoneComboBox1.StartIndex = 0;
            this.siticoneComboBox1.TabIndex = 25;
            // 
            // startattack
            // 
            this.startattack.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.startattack.BorderThickness = 100;
            this.startattack.CheckedState.Parent = this.startattack;
            this.startattack.CustomImages.Parent = this.startattack;
            this.siticoneTransition1.SetDecoration(this.startattack, Siticone.UI.AnimatorNS.DecorationType.None);
            this.startattack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.startattack.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.startattack.ForeColor = System.Drawing.Color.White;
            this.startattack.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.startattack.HoveredState.Parent = this.startattack;
            this.startattack.Location = new System.Drawing.Point(11, 186);
            this.startattack.Name = "startattack";
            this.startattack.ShadowDecoration.Parent = this.startattack;
            this.startattack.Size = new System.Drawing.Size(286, 35);
            this.startattack.TabIndex = 26;
            this.startattack.Text = "Start Stress Test";
            this.startattack.Click += new System.EventHandler(this.startattack_Click);
            // 
            // siticoneMaterialTextBox1
            // 
            this.siticoneMaterialTextBox1.Animated = false;
            this.siticoneMaterialTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneMaterialTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.siticoneMaterialTextBox1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneMaterialTextBox1.DefaultText = "";
            this.siticoneMaterialTextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneMaterialTextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneMaterialTextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneMaterialTextBox1.DisabledState.Parent = this.siticoneMaterialTextBox1;
            this.siticoneMaterialTextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneMaterialTextBox1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.siticoneMaterialTextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneMaterialTextBox1.FocusedState.Parent = this.siticoneMaterialTextBox1;
            this.siticoneMaterialTextBox1.ForeColor = System.Drawing.Color.Black;
            this.siticoneMaterialTextBox1.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneMaterialTextBox1.HoveredState.Parent = this.siticoneMaterialTextBox1;
            this.siticoneMaterialTextBox1.Location = new System.Drawing.Point(11, 84);
            this.siticoneMaterialTextBox1.Margin = new System.Windows.Forms.Padding(8);
            this.siticoneMaterialTextBox1.Name = "siticoneMaterialTextBox1";
            this.siticoneMaterialTextBox1.PasswordChar = '\0';
            this.siticoneMaterialTextBox1.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.siticoneMaterialTextBox1.PlaceholderText = "Enter Port";
            this.siticoneMaterialTextBox1.SelectedText = "";
            this.siticoneMaterialTextBox1.ShadowDecoration.Parent = this.siticoneMaterialTextBox1;
            this.siticoneMaterialTextBox1.Size = new System.Drawing.Size(139, 33);
            this.siticoneMaterialTextBox1.TabIndex = 23;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.attacklog);
            this.siticoneTransition1.SetDecoration(this.groupBox11, Siticone.UI.AnimatorNS.DecorationType.None);
            this.groupBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox11.ForeColor = System.Drawing.Color.White;
            this.groupBox11.Location = new System.Drawing.Point(327, 15);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(413, 351);
            this.groupBox11.TabIndex = 57;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Your Attacks Logs";
            // 
            // attacklog
            // 
            this.attacklog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.attacklog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.attacklog.Cursor = System.Windows.Forms.Cursors.Default;
            this.siticoneTransition1.SetDecoration(this.attacklog, Siticone.UI.AnimatorNS.DecorationType.None);
            this.attacklog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.attacklog.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attacklog.ForeColor = System.Drawing.Color.White;
            this.attacklog.Location = new System.Drawing.Point(3, 25);
            this.attacklog.Name = "attacklog";
            this.attacklog.ReadOnly = true;
            this.attacklog.Size = new System.Drawing.Size(407, 323);
            this.attacklog.TabIndex = 28;
            this.attacklog.Text = "";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.tabPage5.Controls.Add(this.groupBox17);
            this.tabPage5.Controls.Add(this.groupBox15);
            this.tabPage5.Controls.Add(this.groupBox16);
            this.siticoneTransition1.SetDecoration(this.tabPage5, Siticone.UI.AnimatorNS.DecorationType.None);
            this.tabPage5.Location = new System.Drawing.Point(4, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(781, 456);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.accdown);
            this.siticoneTransition1.SetDecoration(this.groupBox17, Siticone.UI.AnimatorNS.DecorationType.None);
            this.groupBox17.ForeColor = System.Drawing.Color.White;
            this.groupBox17.Location = new System.Drawing.Point(270, 309);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(469, 57);
            this.groupBox17.TabIndex = 8;
            this.groupBox17.TabStop = false;
            // 
            // accdown
            // 
            this.accdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneTransition1.SetDecoration(this.accdown, Siticone.UI.AnimatorNS.DecorationType.None);
            this.accdown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.accdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accdown.ForeColor = System.Drawing.Color.White;
            this.accdown.Location = new System.Drawing.Point(3, 10);
            this.accdown.Name = "accdown";
            this.accdown.Size = new System.Drawing.Size(463, 44);
            this.accdown.TabIndex = 16;
            this.accdown.Text = "Cooldown Status: Off";
            this.accdown.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.comboBox3);
            this.groupBox15.Controls.Add(this.siticoneRoundedButton30);
            this.groupBox15.Controls.Add(this.genbutton);
            this.groupBox15.Controls.Add(this.label21);
            this.groupBox15.Controls.Add(this.label22);
            this.siticoneTransition1.SetDecoration(this.groupBox15, Siticone.UI.AnimatorNS.DecorationType.None);
            this.groupBox15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox15.ForeColor = System.Drawing.Color.White;
            this.groupBox15.Location = new System.Drawing.Point(12, 6);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(250, 361);
            this.groupBox15.TabIndex = 44;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Account Generator";
            // 
            // comboBox3
            // 
            this.comboBox3.Animated = true;
            this.comboBox3.BackColor = System.Drawing.Color.Transparent;
            this.comboBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.comboBox3.BorderThickness = 0;
            this.siticoneTransition1.SetDecoration(this.comboBox3, Siticone.UI.AnimatorNS.DecorationType.None);
            this.comboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.HoveredState.Parent = this.comboBox3;
            this.comboBox3.ItemHeight = 30;
            this.comboBox3.Items.AddRange(new object[] {
            "Call of Duty Account",
            "crunchyroll.com Account",
            "Fatz Gift Card",
            "Netflix Account",
            "Nord VPN Account",
            "Spotify Account",
            "Tidal.com Account"});
            this.comboBox3.ItemsAppearance.Parent = this.comboBox3;
            this.comboBox3.Location = new System.Drawing.Point(14, 103);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.ShadowDecoration.Parent = this.comboBox3;
            this.comboBox3.Size = new System.Drawing.Size(219, 36);
            this.comboBox3.StartIndex = 0;
            this.comboBox3.TabIndex = 43;
            // 
            // siticoneRoundedButton30
            // 
            this.siticoneRoundedButton30.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton30.BorderThickness = 100;
            this.siticoneRoundedButton30.CheckedState.Parent = this.siticoneRoundedButton30;
            this.siticoneRoundedButton30.CustomImages.Parent = this.siticoneRoundedButton30;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton30, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton30.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton30.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.siticoneRoundedButton30.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton30.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton30.HoveredState.Parent = this.siticoneRoundedButton30;
            this.siticoneRoundedButton30.Location = new System.Drawing.Point(14, 241);
            this.siticoneRoundedButton30.Name = "siticoneRoundedButton30";
            this.siticoneRoundedButton30.ShadowDecoration.Parent = this.siticoneRoundedButton30;
            this.siticoneRoundedButton30.Size = new System.Drawing.Size(218, 35);
            this.siticoneRoundedButton30.TabIndex = 31;
            this.siticoneRoundedButton30.Text = "Copy  Output Box Text";
            this.siticoneRoundedButton30.Click += new System.EventHandler(this.siticoneRoundedButton30_Click);
            // 
            // genbutton
            // 
            this.genbutton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.genbutton.BorderThickness = 100;
            this.genbutton.CheckedState.Parent = this.genbutton;
            this.genbutton.CustomImages.Parent = this.genbutton;
            this.siticoneTransition1.SetDecoration(this.genbutton, Siticone.UI.AnimatorNS.DecorationType.None);
            this.genbutton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.genbutton.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.genbutton.ForeColor = System.Drawing.Color.White;
            this.genbutton.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.genbutton.HoveredState.Parent = this.genbutton;
            this.genbutton.Location = new System.Drawing.Point(15, 164);
            this.genbutton.Name = "genbutton";
            this.genbutton.ShadowDecoration.Parent = this.genbutton;
            this.genbutton.Size = new System.Drawing.Size(218, 35);
            this.genbutton.TabIndex = 30;
            this.genbutton.Text = "Generate";
            this.genbutton.Click += new System.EventHandler(this.genbutton_Click);
            // 
            // label21
            // 
            this.siticoneTransition1.SetDecoration(this.label21, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(18, 297);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(214, 55);
            this.label21.TabIndex = 42;
            this.label21.Text = "Please Note: \r\nNot Every Account Work,\r\nWe Are Upgrading Accounts\r\n";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label22, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(13, 35);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(220, 40);
            this.label22.TabIndex = 41;
            this.label22.Text = "Select Type of Account You \r\nWant to Generate Below\r\n";
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.richTextBox4);
            this.groupBox16.Controls.Add(this.label23);
            this.siticoneTransition1.SetDecoration(this.groupBox16, Siticone.UI.AnimatorNS.DecorationType.None);
            this.groupBox16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox16.ForeColor = System.Drawing.Color.White;
            this.groupBox16.Location = new System.Drawing.Point(270, 7);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(469, 297);
            this.groupBox16.TabIndex = 43;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Output Box ";
            // 
            // richTextBox4
            // 
            this.richTextBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.richTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox4.Cursor = System.Windows.Forms.Cursors.Default;
            this.siticoneTransition1.SetDecoration(this.richTextBox4, Siticone.UI.AnimatorNS.DecorationType.None);
            this.richTextBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox4.ForeColor = System.Drawing.Color.White;
            this.richTextBox4.Location = new System.Drawing.Point(3, 25);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.ReadOnly = true;
            this.richTextBox4.Size = new System.Drawing.Size(463, 269);
            this.richTextBox4.TabIndex = 33;
            this.richTextBox4.Text = "";
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneTransition1.SetDecoration(this.label23, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(31, 209);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(286, 20);
            this.label23.TabIndex = 45;
            this.label23.Text = "Cooldown Status: Off";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.panel1);
            this.siticoneTransition1.SetDecoration(this.tabPage6, Siticone.UI.AnimatorNS.DecorationType.None);
            this.tabPage6.Location = new System.Drawing.Point(4, 4);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(781, 456);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "tabPage6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.groupBox19);
            this.panel1.Controls.Add(this.groupBox18);
            this.siticoneTransition1.SetDecoration(this.panel1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(813, 506);
            this.panel1.TabIndex = 0;
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.richTextBox5);
            this.siticoneTransition1.SetDecoration(this.groupBox19, Siticone.UI.AnimatorNS.DecorationType.None);
            this.groupBox19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox19.ForeColor = System.Drawing.Color.White;
            this.groupBox19.Location = new System.Drawing.Point(285, 6);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(449, 361);
            this.groupBox19.TabIndex = 20;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "Your Database";
            // 
            // richTextBox5
            // 
            this.richTextBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.richTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox5.Cursor = System.Windows.Forms.Cursors.Default;
            this.siticoneTransition1.SetDecoration(this.richTextBox5, Siticone.UI.AnimatorNS.DecorationType.None);
            this.richTextBox5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox5.ForeColor = System.Drawing.Color.White;
            this.richTextBox5.Location = new System.Drawing.Point(3, 40);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.ReadOnly = true;
            this.richTextBox5.Size = new System.Drawing.Size(443, 318);
            this.richTextBox5.TabIndex = 8;
            this.richTextBox5.Text = "";
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.deletedata);
            this.groupBox18.Controls.Add(this.siticoneMaterialTextBox4);
            this.groupBox18.Controls.Add(this.siticoneRoundedButton29);
            this.groupBox18.Controls.Add(this.siticoneMaterialTextBox3);
            this.groupBox18.Controls.Add(this.siticoneMaterialTextBox2);
            this.groupBox18.Controls.Add(this.label25);
            this.groupBox18.Controls.Add(this.label26);
            this.groupBox18.Controls.Add(this.label27);
            this.siticoneTransition1.SetDecoration(this.groupBox18, Siticone.UI.AnimatorNS.DecorationType.None);
            this.groupBox18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox18.ForeColor = System.Drawing.Color.White;
            this.groupBox18.Location = new System.Drawing.Point(12, 6);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(267, 361);
            this.groupBox18.TabIndex = 19;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "Data Saver";
            // 
            // deletedata
            // 
            this.deletedata.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.deletedata.BorderThickness = 100;
            this.deletedata.CheckedState.Parent = this.deletedata;
            this.deletedata.CustomImages.Parent = this.deletedata;
            this.siticoneTransition1.SetDecoration(this.deletedata, Siticone.UI.AnimatorNS.DecorationType.None);
            this.deletedata.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.deletedata.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.deletedata.ForeColor = System.Drawing.Color.White;
            this.deletedata.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.deletedata.HoveredState.Parent = this.deletedata;
            this.deletedata.Location = new System.Drawing.Point(20, 316);
            this.deletedata.Name = "deletedata";
            this.deletedata.ShadowDecoration.Parent = this.deletedata;
            this.deletedata.Size = new System.Drawing.Size(224, 32);
            this.deletedata.TabIndex = 39;
            this.deletedata.Text = "Edit Database";
            this.deletedata.Click += new System.EventHandler(this.deletedata_Click);
            // 
            // siticoneMaterialTextBox4
            // 
            this.siticoneMaterialTextBox4.Animated = false;
            this.siticoneMaterialTextBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneMaterialTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.siticoneMaterialTextBox4, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneMaterialTextBox4.DefaultText = "";
            this.siticoneMaterialTextBox4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneMaterialTextBox4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneMaterialTextBox4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneMaterialTextBox4.DisabledState.Parent = this.siticoneMaterialTextBox4;
            this.siticoneMaterialTextBox4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneMaterialTextBox4.FillColor = System.Drawing.Color.WhiteSmoke;
            this.siticoneMaterialTextBox4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneMaterialTextBox4.FocusedState.Parent = this.siticoneMaterialTextBox4;
            this.siticoneMaterialTextBox4.ForeColor = System.Drawing.Color.Black;
            this.siticoneMaterialTextBox4.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneMaterialTextBox4.HoveredState.Parent = this.siticoneMaterialTextBox4;
            this.siticoneMaterialTextBox4.IconLeft = ((System.Drawing.Image)(resources.GetObject("siticoneMaterialTextBox4.IconLeft")));
            this.siticoneMaterialTextBox4.Location = new System.Drawing.Point(19, 131);
            this.siticoneMaterialTextBox4.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.siticoneMaterialTextBox4.Name = "siticoneMaterialTextBox4";
            this.siticoneMaterialTextBox4.PasswordChar = '\0';
            this.siticoneMaterialTextBox4.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.siticoneMaterialTextBox4.PlaceholderText = "Enter IP";
            this.siticoneMaterialTextBox4.SelectedText = "";
            this.siticoneMaterialTextBox4.ShadowDecoration.Parent = this.siticoneMaterialTextBox4;
            this.siticoneMaterialTextBox4.Size = new System.Drawing.Size(224, 32);
            this.siticoneMaterialTextBox4.TabIndex = 35;
            // 
            // siticoneRoundedButton29
            // 
            this.siticoneRoundedButton29.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton29.BorderThickness = 100;
            this.siticoneRoundedButton29.CheckedState.Parent = this.siticoneRoundedButton29;
            this.siticoneRoundedButton29.CustomImages.Parent = this.siticoneRoundedButton29;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton29, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton29.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton29.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.siticoneRoundedButton29.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton29.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton29.HoveredState.Parent = this.siticoneRoundedButton29;
            this.siticoneRoundedButton29.Location = new System.Drawing.Point(19, 252);
            this.siticoneRoundedButton29.Name = "siticoneRoundedButton29";
            this.siticoneRoundedButton29.ShadowDecoration.Parent = this.siticoneRoundedButton29;
            this.siticoneRoundedButton29.Size = new System.Drawing.Size(224, 35);
            this.siticoneRoundedButton29.TabIndex = 37;
            this.siticoneRoundedButton29.Text = "Save to Database";
            this.siticoneRoundedButton29.Click += new System.EventHandler(this.siticoneRoundedButton29_Click);
            // 
            // siticoneMaterialTextBox3
            // 
            this.siticoneMaterialTextBox3.Animated = false;
            this.siticoneMaterialTextBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneMaterialTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.siticoneMaterialTextBox3, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneMaterialTextBox3.DefaultText = "";
            this.siticoneMaterialTextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneMaterialTextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneMaterialTextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneMaterialTextBox3.DisabledState.Parent = this.siticoneMaterialTextBox3;
            this.siticoneMaterialTextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneMaterialTextBox3.FillColor = System.Drawing.Color.WhiteSmoke;
            this.siticoneMaterialTextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneMaterialTextBox3.FocusedState.Parent = this.siticoneMaterialTextBox3;
            this.siticoneMaterialTextBox3.ForeColor = System.Drawing.Color.Black;
            this.siticoneMaterialTextBox3.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneMaterialTextBox3.HoveredState.Parent = this.siticoneMaterialTextBox3;
            this.siticoneMaterialTextBox3.IconLeft = ((System.Drawing.Image)(resources.GetObject("siticoneMaterialTextBox3.IconLeft")));
            this.siticoneMaterialTextBox3.Location = new System.Drawing.Point(19, 202);
            this.siticoneMaterialTextBox3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.siticoneMaterialTextBox3.Name = "siticoneMaterialTextBox3";
            this.siticoneMaterialTextBox3.PasswordChar = '\0';
            this.siticoneMaterialTextBox3.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.siticoneMaterialTextBox3.PlaceholderText = "Enter Some Info";
            this.siticoneMaterialTextBox3.SelectedText = "";
            this.siticoneMaterialTextBox3.ShadowDecoration.Parent = this.siticoneMaterialTextBox3;
            this.siticoneMaterialTextBox3.Size = new System.Drawing.Size(224, 32);
            this.siticoneMaterialTextBox3.TabIndex = 36;
            // 
            // siticoneMaterialTextBox2
            // 
            this.siticoneMaterialTextBox2.Animated = false;
            this.siticoneMaterialTextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneMaterialTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.siticoneMaterialTextBox2, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneMaterialTextBox2.DefaultText = "";
            this.siticoneMaterialTextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneMaterialTextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneMaterialTextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneMaterialTextBox2.DisabledState.Parent = this.siticoneMaterialTextBox2;
            this.siticoneMaterialTextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneMaterialTextBox2.FillColor = System.Drawing.Color.WhiteSmoke;
            this.siticoneMaterialTextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneMaterialTextBox2.FocusedState.Parent = this.siticoneMaterialTextBox2;
            this.siticoneMaterialTextBox2.ForeColor = System.Drawing.Color.Black;
            this.siticoneMaterialTextBox2.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneMaterialTextBox2.HoveredState.Parent = this.siticoneMaterialTextBox2;
            this.siticoneMaterialTextBox2.IconLeft = ((System.Drawing.Image)(resources.GetObject("siticoneMaterialTextBox2.IconLeft")));
            this.siticoneMaterialTextBox2.Location = new System.Drawing.Point(19, 59);
            this.siticoneMaterialTextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.siticoneMaterialTextBox2.Name = "siticoneMaterialTextBox2";
            this.siticoneMaterialTextBox2.PasswordChar = '\0';
            this.siticoneMaterialTextBox2.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.siticoneMaterialTextBox2.PlaceholderText = "Enter Username";
            this.siticoneMaterialTextBox2.SelectedText = "";
            this.siticoneMaterialTextBox2.ShadowDecoration.Parent = this.siticoneMaterialTextBox2;
            this.siticoneMaterialTextBox2.Size = new System.Drawing.Size(224, 32);
            this.siticoneMaterialTextBox2.TabIndex = 34;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label25, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(16, 176);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(85, 20);
            this.label25.TabIndex = 16;
            this.label25.Text = "Extra Info:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label26, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label26.ForeColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(15, 32);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(91, 20);
            this.label26.TabIndex = 14;
            this.label26.Text = "Username:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label27, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label27.ForeColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(16, 103);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(96, 20);
            this.label27.TabIndex = 12;
            this.label27.Text = "IP Address:";
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.tabPage7.Controls.Add(this.groupBox22);
            this.tabPage7.Controls.Add(this.groupBox21);
            this.tabPage7.Controls.Add(this.groupBox20);
            this.siticoneTransition1.SetDecoration(this.tabPage7, Siticone.UI.AnimatorNS.DecorationType.None);
            this.tabPage7.Location = new System.Drawing.Point(4, 4);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(781, 456);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "tabPage7";
            // 
            // groupBox22
            // 
            this.groupBox22.Controls.Add(this.encmsg);
            this.siticoneTransition1.SetDecoration(this.groupBox22, Siticone.UI.AnimatorNS.DecorationType.None);
            this.groupBox22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox22.ForeColor = System.Drawing.Color.White;
            this.groupBox22.Location = new System.Drawing.Point(302, 0);
            this.groupBox22.Name = "groupBox22";
            this.groupBox22.Size = new System.Drawing.Size(423, 180);
            this.groupBox22.TabIndex = 49;
            this.groupBox22.TabStop = false;
            this.groupBox22.Text = "Encrypted Message";
            // 
            // encmsg
            // 
            this.encmsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.encmsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.siticoneTransition1.SetDecoration(this.encmsg, Siticone.UI.AnimatorNS.DecorationType.None);
            this.encmsg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.encmsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.encmsg.ForeColor = System.Drawing.Color.White;
            this.encmsg.Location = new System.Drawing.Point(3, 25);
            this.encmsg.Name = "encmsg";
            this.encmsg.ReadOnly = true;
            this.encmsg.Size = new System.Drawing.Size(417, 152);
            this.encmsg.TabIndex = 44;
            this.encmsg.Text = "";
            // 
            // groupBox21
            // 
            this.groupBox21.Controls.Add(this.decmsg);
            this.siticoneTransition1.SetDecoration(this.groupBox21, Siticone.UI.AnimatorNS.DecorationType.None);
            this.groupBox21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox21.ForeColor = System.Drawing.Color.White;
            this.groupBox21.Location = new System.Drawing.Point(302, 183);
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.Size = new System.Drawing.Size(423, 185);
            this.groupBox21.TabIndex = 49;
            this.groupBox21.TabStop = false;
            this.groupBox21.Text = "Decrypted Message";
            // 
            // decmsg
            // 
            this.decmsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.decmsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.siticoneTransition1.SetDecoration(this.decmsg, Siticone.UI.AnimatorNS.DecorationType.None);
            this.decmsg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.decmsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.decmsg.ForeColor = System.Drawing.Color.White;
            this.decmsg.Location = new System.Drawing.Point(3, 25);
            this.decmsg.Name = "decmsg";
            this.decmsg.ReadOnly = true;
            this.decmsg.Size = new System.Drawing.Size(417, 157);
            this.decmsg.TabIndex = 45;
            this.decmsg.Text = "";
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.label29);
            this.groupBox20.Controls.Add(this.label28);
            this.groupBox20.Controls.Add(this.label24);
            this.groupBox20.Controls.Add(this.siticoneComboBox2);
            this.groupBox20.Controls.Add(this.siticoneRoundedButton33);
            this.groupBox20.Controls.Add(this.siticoneMaterialTextBox5);
            this.groupBox20.Controls.Add(this.siticoneRoundedButton31);
            this.siticoneTransition1.SetDecoration(this.groupBox20, Siticone.UI.AnimatorNS.DecorationType.None);
            this.groupBox20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox20.ForeColor = System.Drawing.Color.White;
            this.groupBox20.Location = new System.Drawing.Point(12, 0);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(284, 369);
            this.groupBox20.TabIndex = 0;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "Encrypt and Decrypt Message";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label29, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label29.ForeColor = System.Drawing.Color.White;
            this.label29.Location = new System.Drawing.Point(8, 221);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(108, 20);
            this.label29.TabIndex = 51;
            this.label29.Text = "Select Action";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label28, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label28.ForeColor = System.Drawing.Color.White;
            this.label28.Location = new System.Drawing.Point(7, 136);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(186, 20);
            this.label28.TabIndex = 50;
            this.label28.Text = "Select Encryption Type ";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label24, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(6, 40);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(178, 20);
            this.label24.TabIndex = 49;
            this.label24.Text = "Enter Message Below:";
            // 
            // siticoneComboBox2
            // 
            this.siticoneComboBox2.Animated = true;
            this.siticoneComboBox2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneComboBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneComboBox2.BorderThickness = 0;
            this.siticoneTransition1.SetDecoration(this.siticoneComboBox2, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.siticoneComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.siticoneComboBox2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneComboBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.siticoneComboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.siticoneComboBox2.FormattingEnabled = true;
            this.siticoneComboBox2.HoveredState.Parent = this.siticoneComboBox2;
            this.siticoneComboBox2.ItemHeight = 30;
            this.siticoneComboBox2.Items.AddRange(new object[] {
            "Method 1",
            "Method 2"});
            this.siticoneComboBox2.ItemsAppearance.Parent = this.siticoneComboBox2;
            this.siticoneComboBox2.Location = new System.Drawing.Point(10, 163);
            this.siticoneComboBox2.Name = "siticoneComboBox2";
            this.siticoneComboBox2.ShadowDecoration.Parent = this.siticoneComboBox2;
            this.siticoneComboBox2.Size = new System.Drawing.Size(263, 36);
            this.siticoneComboBox2.StartIndex = 0;
            this.siticoneComboBox2.TabIndex = 41;
            // 
            // siticoneRoundedButton33
            // 
            this.siticoneRoundedButton33.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton33.BorderThickness = 100;
            this.siticoneRoundedButton33.CheckedState.Parent = this.siticoneRoundedButton33;
            this.siticoneRoundedButton33.CustomImages.Parent = this.siticoneRoundedButton33;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton33, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton33.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton33.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.siticoneRoundedButton33.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton33.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton33.HoveredState.Parent = this.siticoneRoundedButton33;
            this.siticoneRoundedButton33.Location = new System.Drawing.Point(9, 314);
            this.siticoneRoundedButton33.Name = "siticoneRoundedButton33";
            this.siticoneRoundedButton33.ShadowDecoration.Parent = this.siticoneRoundedButton33;
            this.siticoneRoundedButton33.Size = new System.Drawing.Size(264, 38);
            this.siticoneRoundedButton33.TabIndex = 43;
            this.siticoneRoundedButton33.Text = "Decrypt Message";
            this.siticoneRoundedButton33.Click += new System.EventHandler(this.siticoneRoundedButton33_Click);
            // 
            // siticoneMaterialTextBox5
            // 
            this.siticoneMaterialTextBox5.Animated = false;
            this.siticoneMaterialTextBox5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneMaterialTextBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTransition1.SetDecoration(this.siticoneMaterialTextBox5, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneMaterialTextBox5.DefaultText = "";
            this.siticoneMaterialTextBox5.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneMaterialTextBox5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneMaterialTextBox5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneMaterialTextBox5.DisabledState.Parent = this.siticoneMaterialTextBox5;
            this.siticoneMaterialTextBox5.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneMaterialTextBox5.FillColor = System.Drawing.Color.WhiteSmoke;
            this.siticoneMaterialTextBox5.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneMaterialTextBox5.FocusedState.Parent = this.siticoneMaterialTextBox5;
            this.siticoneMaterialTextBox5.ForeColor = System.Drawing.Color.Black;
            this.siticoneMaterialTextBox5.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneMaterialTextBox5.HoveredState.Parent = this.siticoneMaterialTextBox5;
            this.siticoneMaterialTextBox5.IconLeft = ((System.Drawing.Image)(resources.GetObject("siticoneMaterialTextBox5.IconLeft")));
            this.siticoneMaterialTextBox5.Location = new System.Drawing.Point(9, 74);
            this.siticoneMaterialTextBox5.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.siticoneMaterialTextBox5.Name = "siticoneMaterialTextBox5";
            this.siticoneMaterialTextBox5.PasswordChar = '\0';
            this.siticoneMaterialTextBox5.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.siticoneMaterialTextBox5.PlaceholderText = "Enter Message";
            this.siticoneMaterialTextBox5.SelectedText = "";
            this.siticoneMaterialTextBox5.ShadowDecoration.Parent = this.siticoneMaterialTextBox5;
            this.siticoneMaterialTextBox5.Size = new System.Drawing.Size(264, 38);
            this.siticoneMaterialTextBox5.TabIndex = 40;
            // 
            // siticoneRoundedButton31
            // 
            this.siticoneRoundedButton31.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton31.BorderThickness = 100;
            this.siticoneRoundedButton31.CheckedState.Parent = this.siticoneRoundedButton31;
            this.siticoneRoundedButton31.CustomImages.Parent = this.siticoneRoundedButton31;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton31, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton31.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton31.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.siticoneRoundedButton31.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton31.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton31.HoveredState.Parent = this.siticoneRoundedButton31;
            this.siticoneRoundedButton31.Location = new System.Drawing.Point(9, 259);
            this.siticoneRoundedButton31.Name = "siticoneRoundedButton31";
            this.siticoneRoundedButton31.ShadowDecoration.Parent = this.siticoneRoundedButton31;
            this.siticoneRoundedButton31.Size = new System.Drawing.Size(264, 38);
            this.siticoneRoundedButton31.TabIndex = 42;
            this.siticoneRoundedButton31.Text = "Encrypt Message";
            this.siticoneRoundedButton31.Click += new System.EventHandler(this.siticoneRoundedButton31_Click);
            // 
            // tabPage8
            // 
            this.tabPage8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.tabPage8.Controls.Add(this.siticoneRoundedButton26);
            this.tabPage8.Controls.Add(this.siticoneRoundedButton25);
            this.siticoneTransition1.SetDecoration(this.tabPage8, Siticone.UI.AnimatorNS.DecorationType.None);
            this.tabPage8.Location = new System.Drawing.Point(4, 4);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(781, 456);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "tabPage8";
            // 
            // siticoneRoundedButton26
            // 
            this.siticoneRoundedButton26.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton26.BorderThickness = 100;
            this.siticoneRoundedButton26.CheckedState.Parent = this.siticoneRoundedButton26;
            this.siticoneRoundedButton26.CustomImages.Parent = this.siticoneRoundedButton26;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton26, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton26.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton26.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.siticoneRoundedButton26.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton26.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton26.HoveredState.Parent = this.siticoneRoundedButton26;
            this.siticoneRoundedButton26.Location = new System.Drawing.Point(223, 241);
            this.siticoneRoundedButton26.Name = "siticoneRoundedButton26";
            this.siticoneRoundedButton26.ShadowDecoration.Parent = this.siticoneRoundedButton26;
            this.siticoneRoundedButton26.Size = new System.Drawing.Size(264, 38);
            this.siticoneRoundedButton26.TabIndex = 44;
            this.siticoneRoundedButton26.Text = "Reset";
            // 
            // siticoneRoundedButton25
            // 
            this.siticoneRoundedButton25.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton25.BorderThickness = 100;
            this.siticoneRoundedButton25.CheckedState.Parent = this.siticoneRoundedButton25;
            this.siticoneRoundedButton25.CustomImages.Parent = this.siticoneRoundedButton25;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton25, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton25.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton25.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.siticoneRoundedButton25.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton25.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton25.HoveredState.Parent = this.siticoneRoundedButton25;
            this.siticoneRoundedButton25.Location = new System.Drawing.Point(223, 187);
            this.siticoneRoundedButton25.Name = "siticoneRoundedButton25";
            this.siticoneRoundedButton25.ShadowDecoration.Parent = this.siticoneRoundedButton25;
            this.siticoneRoundedButton25.Size = new System.Drawing.Size(264, 38);
            this.siticoneRoundedButton25.TabIndex = 43;
            this.siticoneRoundedButton25.Text = "Multicolor";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneTransition1.SetDecoration(this.label7, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(960, 40);
            this.label7.TabIndex = 57;
            this.label7.Click += new System.EventHandler(this.label7_Click_1);
            this.label7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label7_MouseDown_1);
            this.label7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label7_MouseMove);
            this.label7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label7_MouseUp);
            // 
            // siticoneRoundedButton9
            // 
            this.siticoneRoundedButton9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton9.CheckedState.Parent = this.siticoneRoundedButton9;
            this.siticoneRoundedButton9.CustomImages.Parent = this.siticoneRoundedButton9;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton9, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton9.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton9.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton9.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton9.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton9.HoveredState.Parent = this.siticoneRoundedButton9;
            this.siticoneRoundedButton9.Image = ((System.Drawing.Image)(resources.GetObject("siticoneRoundedButton9.Image")));
            this.siticoneRoundedButton9.Location = new System.Drawing.Point(10, 207);
            this.siticoneRoundedButton9.Name = "siticoneRoundedButton9";
            this.siticoneRoundedButton9.ShadowDecoration.Parent = this.siticoneRoundedButton9;
            this.siticoneRoundedButton9.Size = new System.Drawing.Size(188, 35);
            this.siticoneRoundedButton9.TabIndex = 4;
            this.siticoneRoundedButton9.Text = "Stresser";
            this.siticoneRoundedButton9.Click += new System.EventHandler(this.siticoneRoundedButton9_Click);
            // 
            // label17
            // 
            this.siticoneTransition1.SetDecoration(this.label17, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label17.Location = new System.Drawing.Point(213, 46);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(749, 10);
            this.label17.TabIndex = 59;
            this.label17.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label17_MouseDown);
            this.label17.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label17_MouseMove);
            this.label17.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label17_MouseUp);
            // 
            // label18
            // 
            this.siticoneTransition1.SetDecoration(this.label18, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label18.Location = new System.Drawing.Point(203, 44);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(10, 412);
            this.label18.TabIndex = 60;
            this.label18.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label18_MouseDown);
            this.label18.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label18_MouseMove);
            this.label18.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label18_MouseUp);
            // 
            // registerdate
            // 
            this.registerdate.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.registerdate, Siticone.UI.AnimatorNS.DecorationType.None);
            this.registerdate.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.registerdate.Location = new System.Drawing.Point(179, 236);
            this.registerdate.Margin = new System.Windows.Forms.Padding(2);
            this.registerdate.Name = "registerdate";
            this.registerdate.Size = new System.Drawing.Size(69, 14);
            this.registerdate.TabIndex = 46;
            this.registerdate.Text = "siticoneLabel4";
            // 
            // lastlogin
            // 
            this.lastlogin.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.lastlogin, Siticone.UI.AnimatorNS.DecorationType.None);
            this.lastlogin.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastlogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lastlogin.Location = new System.Drawing.Point(179, 216);
            this.lastlogin.Margin = new System.Windows.Forms.Padding(2);
            this.lastlogin.Name = "lastlogin";
            this.lastlogin.Size = new System.Drawing.Size(69, 14);
            this.lastlogin.TabIndex = 45;
            this.lastlogin.Text = "siticoneLabel4";
            // 
            // expiry
            // 
            this.expiry.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.expiry, Siticone.UI.AnimatorNS.DecorationType.None);
            this.expiry.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expiry.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.expiry.Location = new System.Drawing.Point(179, 195);
            this.expiry.Margin = new System.Windows.Forms.Padding(2);
            this.expiry.Name = "expiry";
            this.expiry.Size = new System.Drawing.Size(69, 14);
            this.expiry.TabIndex = 44;
            this.expiry.Text = "siticoneLabel4";
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.email, Siticone.UI.AnimatorNS.DecorationType.None);
            this.email.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.email.Location = new System.Drawing.Point(300, 119);
            this.email.Margin = new System.Windows.Forms.Padding(2);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(69, 14);
            this.email.TabIndex = 39;
            this.email.Text = "siticoneLabel3";
            // 
            // hwid
            // 
            this.hwid.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.hwid, Siticone.UI.AnimatorNS.DecorationType.None);
            this.hwid.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hwid.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hwid.Location = new System.Drawing.Point(300, 139);
            this.hwid.Margin = new System.Windows.Forms.Padding(2);
            this.hwid.Name = "hwid";
            this.hwid.Size = new System.Drawing.Size(69, 14);
            this.hwid.TabIndex = 40;
            this.hwid.Text = "siticoneLabel4";
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.username, Siticone.UI.AnimatorNS.DecorationType.None);
            this.username.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.username.Location = new System.Drawing.Point(300, 98);
            this.username.Margin = new System.Windows.Forms.Padding(2);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(69, 14);
            this.username.TabIndex = 38;
            this.username.Text = "siticoneLabel2";
            // 
            // uservariable
            // 
            this.uservariable.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.uservariable, Siticone.UI.AnimatorNS.DecorationType.None);
            this.uservariable.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uservariable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uservariable.Location = new System.Drawing.Point(300, 159);
            this.uservariable.Margin = new System.Windows.Forms.Padding(2);
            this.uservariable.Name = "uservariable";
            this.uservariable.Size = new System.Drawing.Size(69, 14);
            this.uservariable.TabIndex = 41;
            this.uservariable.Text = "siticoneLabel4";
            // 
            // userid
            // 
            this.userid.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.userid, Siticone.UI.AnimatorNS.DecorationType.None);
            this.userid.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userid.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userid.Location = new System.Drawing.Point(300, 78);
            this.userid.Margin = new System.Windows.Forms.Padding(2);
            this.userid.Name = "userid";
            this.userid.Size = new System.Drawing.Size(69, 14);
            this.userid.TabIndex = 37;
            this.userid.Text = "siticoneLabel1";
            // 
            // userrank
            // 
            this.userrank.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.userrank, Siticone.UI.AnimatorNS.DecorationType.None);
            this.userrank.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userrank.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userrank.Location = new System.Drawing.Point(300, 180);
            this.userrank.Margin = new System.Windows.Forms.Padding(2);
            this.userrank.Name = "userrank";
            this.userrank.Size = new System.Drawing.Size(69, 14);
            this.userrank.TabIndex = 42;
            this.userrank.Text = "siticoneLabel4";
            // 
            // ip
            // 
            this.ip.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.ip, Siticone.UI.AnimatorNS.DecorationType.None);
            this.ip.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ip.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ip.Location = new System.Drawing.Point(300, 200);
            this.ip.Margin = new System.Windows.Forms.Padding(2);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(69, 14);
            this.ip.TabIndex = 43;
            this.ip.Text = "siticoneLabel4";
            // 
            // label30
            // 
            this.siticoneTransition1.SetDecoration(this.label30, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label30.Location = new System.Drawing.Point(203, 449);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(10, 57);
            this.label30.TabIndex = 62;
            // 
            // label31
            // 
            this.label31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneTransition1.SetDecoration(this.label31, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label31.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label31.ForeColor = System.Drawing.Color.White;
            this.label31.Location = new System.Drawing.Point(16, 5);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(162, 30);
            this.label31.TabIndex = 18;
            this.label31.Text = "Master Tools v2";
            // 
            // helpbutton
            // 
            this.helpbutton.Interval = 7000;
            // 
            // siticoneAnimateWindow1
            // 
            this.siticoneAnimateWindow1.AnimationType = Siticone.UI.WinForms.SiticoneAnimateWindow.AnimateWindowType.AW_SLIDE;
            this.siticoneAnimateWindow1.Interval = 5000;
            // 
            // cooldown
            // 
            this.cooldown.Interval = 120000;
            this.cooldown.Tick += new System.EventHandler(this.cooldown_Tick);
            // 
            // rank1
            // 
            this.rank1.Interval = 100000;
            this.rank1.Tick += new System.EventHandler(this.rank1_Tick);
            // 
            // rank2
            // 
            this.rank2.Interval = 60000;
            this.rank2.Tick += new System.EventHandler(this.rank2_Tick);
            // 
            // rank3
            // 
            this.rank3.Interval = 15000;
            this.rank3.Tick += new System.EventHandler(this.rank3_Tick);
            // 
            // pagecolor
            // 
            this.pagecolor.AnyColor = true;
            this.pagecolor.Color = System.Drawing.Color.Red;
            this.pagecolor.FullOpen = true;
            // 
            // buttonback
            // 
            this.buttonback.AnyColor = true;
            this.buttonback.Color = System.Drawing.Color.Blue;
            this.buttonback.FullOpen = true;
            // 
            // buttonfill
            // 
            this.buttonfill.AnyColor = true;
            this.buttonfill.Color = System.Drawing.Color.Green;
            this.buttonfill.FullOpen = true;
            // 
            // status
            // 
            this.status.Interval = 1000;
            this.status.Tick += new System.EventHandler(this.status_Tick);
            // 
            // cooldown1
            // 
            this.cooldown1.Interval = 20000;
            this.cooldown1.Tick += new System.EventHandler(this.cooldown1_Tick);
            // 
            // wait2
            // 
            this.wait2.Interval = 1000;
            this.wait2.Tick += new System.EventHandler(this.wait2_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(960, 447);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.siticoneControlBox1);
            this.Controls.Add(this.siticoneControlBox2);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.siticoneRoundedButton9);
            this.Controls.Add(this.siticoneRoundedButton8);
            this.Controls.Add(this.siticoneRoundedButton7);
            this.Controls.Add(this.siticoneRoundedButton6);
            this.Controls.Add(this.siticoneRoundedButton5);
            this.Controls.Add(this.siticoneRoundedButton4);
            this.Controls.Add(this.siticoneRoundedButton3);
            this.Controls.Add(this.siticoneRoundedButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tabControl1);
            this.siticoneTransition1.SetDecoration(this, Siticone.UI.AnimatorNS.DecorationType.BottomMirror);
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox14.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.groupBox17.ResumeLayout(false);
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox19.ResumeLayout(false);
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.groupBox22.ResumeLayout(false);
            this.groupBox21.ResumeLayout(false);
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Token: 0x04000001 RID: 1
        private global::System.ComponentModel.IContainer components = null;

        // Token: 0x04000002 RID: 2
        private global::Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;

        // Token: 0x04000004 RID: 4
        private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;

        // Token: 0x04000005 RID: 5
        private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox2;

        // Token: 0x04000009 RID: 9
        private global::Siticone.UI.WinForms.SiticoneTransition siticoneTransition1;

        // Token: 0x0400000A RID: 10
        private global::System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Siticone.UI.WinForms.SiticoneShadowForm siticoneShadowForm;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton3;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton1;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton7;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton6;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton5;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton4;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton8;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Timer helpbutton;
        private System.Windows.Forms.Label label7;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label IPStatus;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Siticone.UI.WinForms.SiticoneAnimateWindow siticoneAnimateWindow1;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RichTextBox updatebox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label6;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton12;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton11;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private Siticone.UI.WinForms.SiticoneMaterialTextBox iptext;
        private Siticone.UI.WinForms.SiticoneComboBox action;
        private Siticone.UI.WinForms.SiticoneMaterialTextBox porttext;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton13;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton14;
        private System.Windows.Forms.GroupBox groupBox8;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton15;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton16;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton17;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton18;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.GroupBox groupBox10;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton19;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton20;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton21;
        private Siticone.UI.WinForms.SiticoneComboBox act;
        private Siticone.UI.WinForms.SiticoneMaterialTextBox host;
        private Siticone.UI.WinForms.SiticoneMaterialTextBox stresshost;
        private Siticone.UI.WinForms.SiticoneRoundedButton startattack;
        private Siticone.UI.WinForms.SiticoneMaterialTextBox timeattack;
        private Siticone.UI.WinForms.SiticoneMaterialTextBox siticoneMaterialTextBox1;
        private Siticone.UI.WinForms.SiticoneComboBox siticoneComboBox1;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.RichTextBox attacklog;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.GroupBox groupBox13;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton22;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton24;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton23;
        private System.Windows.Forms.Timer cooldown;

        private System.Windows.Forms.Label nigger;
        private System.Windows.Forms.Timer rank1;
        private System.Windows.Forms.Timer rank2;
        private System.Windows.Forms.Timer rank3;
        private System.Windows.Forms.TabPage tabPage7;
        private Siticone.UI.WinForms.SiticoneLabel registerdate;
        private Siticone.UI.WinForms.SiticoneLabel lastlogin;
        private Siticone.UI.WinForms.SiticoneLabel expiry;
        private Siticone.UI.WinForms.SiticoneLabel email;
        private Siticone.UI.WinForms.SiticoneLabel hwid;
        private Siticone.UI.WinForms.SiticoneLabel username;
        private Siticone.UI.WinForms.SiticoneLabel uservariable;
        private Siticone.UI.WinForms.SiticoneLabel userid;
        private Siticone.UI.WinForms.SiticoneLabel userrank;
        private Siticone.UI.WinForms.SiticoneLabel ip;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.ColorDialog pagecolor;
        private System.Windows.Forms.ColorDialog buttonback;
        private System.Windows.Forms.ColorDialog buttonfill;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox14;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton27;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Timer status;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton28;
        private System.Windows.Forms.GroupBox groupBox15;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton30;
        private Siticone.UI.WinForms.SiticoneRoundedButton genbutton;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.Label accdown;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Timer cooldown1;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.GroupBox groupBox18;
        private Siticone.UI.WinForms.SiticoneMaterialTextBox siticoneMaterialTextBox2;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton29;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private Siticone.UI.WinForms.SiticoneMaterialTextBox siticoneMaterialTextBox4;
        private Siticone.UI.WinForms.SiticoneMaterialTextBox siticoneMaterialTextBox3;
        private Siticone.UI.WinForms.SiticoneRoundedButton deletedata;
        private System.Windows.Forms.Timer wait2;
        private System.Windows.Forms.GroupBox groupBox20;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton31;
        private Siticone.UI.WinForms.SiticoneMaterialTextBox siticoneMaterialTextBox5;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton33;
        private System.Windows.Forms.RichTextBox encmsg;
        private Siticone.UI.WinForms.SiticoneComboBox siticoneComboBox2;
        private System.Windows.Forms.RichTextBox decmsg;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.GroupBox groupBox22;
        private System.Windows.Forms.GroupBox groupBox21;
        private Siticone.UI.WinForms.SiticoneComboBox comboBox3;
        private System.Windows.Forms.Label label30;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton25;
        private System.Windows.Forms.Timer timerR;
        private System.Windows.Forms.Timer timer1;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton26;
        private System.Windows.Forms.Label label31;
    }
}