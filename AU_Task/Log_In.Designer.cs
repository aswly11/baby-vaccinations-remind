namespace AU_Task
{
    partial class Log_In
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            AnimatorNS.Animation animation1 = new AnimatorNS.Animation();
            AnimatorNS.Animation animation2 = new AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Log_In));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.log_pnl = new System.Windows.Forms.Panel();
            this.error_txt = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pass_txt = new Bunifu.Framework.UI.BunifuTextbox();
            this.btn_pnl = new System.Windows.Forms.Panel();
            this.LogA = new Bunifu.Framework.UI.BunifuThinButton2();
            this.signA = new Bunifu.Framework.UI.BunifuThinButton2();
            this.signE = new Bunifu.Framework.UI.BunifuThinButton2();
            this.logE = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.name_txt = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.animator1 = new AnimatorNS.Animator(this.components);
            this.add_pnl = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.add_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.error_txt2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.id_txt = new Bunifu.Framework.UI.BunifuTextbox();
            this.city_txt = new Bunifu.Framework.UI.BunifuTextbox();
            this.street_txt = new Bunifu.Framework.UI.BunifuTextbox();
            this.phone_txt = new Bunifu.Framework.UI.BunifuTextbox();
            this.newPassword_txt = new Bunifu.Framework.UI.BunifuTextbox();
            this.email_txt = new Bunifu.Framework.UI.BunifuTextbox();
            this.surname_txt = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.newName_txt = new Bunifu.Framework.UI.BunifuTextbox();
            this.animator2 = new AnimatorNS.Animator(this.components);
            this.log_pnl.SuspendLayout();
            this.btn_pnl.SuspendLayout();
            this.add_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuCustomLabel1
            // 
            resources.ApplyResources(this.bunifuCustomLabel1, "bunifuCustomLabel1");
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.bunifuCustomLabel1, AnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.bunifuCustomLabel1, AnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // log_pnl
            // 
            this.log_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.log_pnl.Controls.Add(this.error_txt);
            this.log_pnl.Controls.Add(this.pass_txt);
            this.log_pnl.Controls.Add(this.btn_pnl);
            this.log_pnl.Controls.Add(this.signE);
            this.log_pnl.Controls.Add(this.logE);
            this.log_pnl.Controls.Add(this.bunifuCustomLabel3);
            this.log_pnl.Controls.Add(this.bunifuCustomLabel2);
            this.log_pnl.Controls.Add(this.name_txt);
            this.log_pnl.Controls.Add(this.bunifuCustomLabel1);
            this.animator2.SetDecoration(this.log_pnl, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.log_pnl, AnimatorNS.DecorationType.None);
            this.log_pnl.ForeColor = System.Drawing.Color.Chocolate;
            resources.ApplyResources(this.log_pnl, "log_pnl");
            this.log_pnl.Name = "log_pnl";
            this.log_pnl.Paint += new System.Windows.Forms.PaintEventHandler(this.log_pnl_Paint);
            // 
            // error_txt
            // 
            resources.ApplyResources(this.error_txt, "error_txt");
            this.error_txt.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.error_txt, AnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.error_txt, AnimatorNS.DecorationType.None);
            this.error_txt.ForeColor = System.Drawing.Color.Red;
            this.error_txt.Name = "error_txt";
            // 
            // pass_txt
            // 
            this.pass_txt.BackColor = System.Drawing.Color.BurlyWood;
            resources.ApplyResources(this.pass_txt, "pass_txt");
            this.animator2.SetDecoration(this.pass_txt, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.pass_txt, AnimatorNS.DecorationType.None);
            this.pass_txt.ForeColor = System.Drawing.Color.DimGray;
            this.pass_txt.Icon = ((System.Drawing.Image)(resources.GetObject("pass_txt.Icon")));
            this.pass_txt.Name = "pass_txt";
            this.pass_txt.text = "Enter Your Password please";
            this.pass_txt.Enter += new System.EventHandler(this.pass_txt_Enter);
            this.pass_txt.Leave += new System.EventHandler(this.pass_txt_Leave);
            // 
            // btn_pnl
            // 
            this.btn_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_pnl.Controls.Add(this.LogA);
            this.btn_pnl.Controls.Add(this.signA);
            this.animator2.SetDecoration(this.btn_pnl, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.btn_pnl, AnimatorNS.DecorationType.None);
            resources.ApplyResources(this.btn_pnl, "btn_pnl");
            this.btn_pnl.Name = "btn_pnl";
            // 
            // LogA
            // 
            this.LogA.ActiveBorderThickness = 1;
            this.LogA.ActiveCornerRadius = 20;
            this.LogA.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.LogA.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LogA.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.LogA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.LogA, "LogA");
            this.LogA.ButtonText = "دخول الان";
            this.LogA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator2.SetDecoration(this.LogA, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.LogA, AnimatorNS.DecorationType.None);
            this.LogA.ForeColor = System.Drawing.Color.Gainsboro;
            this.LogA.IdleBorderThickness = 1;
            this.LogA.IdleCornerRadius = 40;
            this.LogA.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.LogA.IdleForecolor = System.Drawing.Color.Gainsboro;
            this.LogA.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.LogA.Name = "LogA";
            this.LogA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LogA.Click += new System.EventHandler(this.LogA_Click);
            // 
            // signA
            // 
            this.signA.ActiveBorderThickness = 1;
            this.signA.ActiveCornerRadius = 20;
            this.signA.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.signA.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.signA.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.signA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.signA, "signA");
            this.signA.ButtonText = "أنشاء حساب";
            this.signA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator2.SetDecoration(this.signA, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.signA, AnimatorNS.DecorationType.None);
            this.signA.ForeColor = System.Drawing.Color.Gainsboro;
            this.signA.IdleBorderThickness = 1;
            this.signA.IdleCornerRadius = 40;
            this.signA.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.signA.IdleForecolor = System.Drawing.Color.Gainsboro;
            this.signA.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.signA.Name = "signA";
            this.signA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.signA.Click += new System.EventHandler(this.signA_Click);
            // 
            // signE
            // 
            this.signE.ActiveBorderThickness = 1;
            this.signE.ActiveCornerRadius = 20;
            this.signE.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.signE.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.signE.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.signE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.signE, "signE");
            this.signE.ButtonText = "   SIGN IN";
            this.signE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator2.SetDecoration(this.signE, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.signE, AnimatorNS.DecorationType.None);
            this.signE.ForeColor = System.Drawing.Color.Gainsboro;
            this.signE.IdleBorderThickness = 1;
            this.signE.IdleCornerRadius = 40;
            this.signE.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.signE.IdleForecolor = System.Drawing.Color.Gainsboro;
            this.signE.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.signE.Name = "signE";
            this.signE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.signE.Click += new System.EventHandler(this.signE_Click);
            // 
            // logE
            // 
            this.logE.ActiveBorderThickness = 1;
            this.logE.ActiveCornerRadius = 20;
            this.logE.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.logE.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.logE.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.logE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.logE, "logE");
            this.logE.ButtonText = "  LOG IN NOW";
            this.logE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator2.SetDecoration(this.logE, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.logE, AnimatorNS.DecorationType.None);
            this.logE.ForeColor = System.Drawing.Color.Gainsboro;
            this.logE.IdleBorderThickness = 1;
            this.logE.IdleCornerRadius = 40;
            this.logE.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.logE.IdleForecolor = System.Drawing.Color.Gainsboro;
            this.logE.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.logE.Name = "logE";
            this.logE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logE.Click += new System.EventHandler(this.logE_Click);
            // 
            // bunifuCustomLabel3
            // 
            resources.ApplyResources(this.bunifuCustomLabel3, "bunifuCustomLabel3");
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.bunifuCustomLabel3, AnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.bunifuCustomLabel3, AnimatorNS.DecorationType.None);
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(179)))));
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            // 
            // bunifuCustomLabel2
            // 
            resources.ApplyResources(this.bunifuCustomLabel2, "bunifuCustomLabel2");
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.bunifuCustomLabel2, AnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.bunifuCustomLabel2, AnimatorNS.DecorationType.None);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(179)))));
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            // 
            // name_txt
            // 
            this.name_txt.BackColor = System.Drawing.Color.BurlyWood;
            resources.ApplyResources(this.name_txt, "name_txt");
            this.animator2.SetDecoration(this.name_txt, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.name_txt, AnimatorNS.DecorationType.None);
            this.name_txt.ForeColor = System.Drawing.Color.DimGray;
            this.name_txt.Icon = ((System.Drawing.Image)(resources.GetObject("name_txt.Icon")));
            this.name_txt.Name = "name_txt";
            this.name_txt.text = "Enter Your Email please";
            this.name_txt.OnTextChange += new System.EventHandler(this.bunifuTextbox1_OnTextChange);
            this.name_txt.Enter += new System.EventHandler(this.name_txt_Enter);
            this.name_txt.Leave += new System.EventHandler(this.name_txt_Leave);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // animator1
            // 
            this.animator1.AnimationType = AnimatorNS.AnimationType.Mosaic;
            this.animator1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 20;
            animation1.Padding = new System.Windows.Forms.Padding(30);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.animator1.DefaultAnimation = animation1;
            this.animator1.TimeStep = 0.005F;
            // 
            // add_pnl
            // 
            this.add_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.add_pnl.Controls.Add(this.pictureBox3);
            this.add_pnl.Controls.Add(this.add_btn);
            this.add_pnl.Controls.Add(this.error_txt2);
            this.add_pnl.Controls.Add(this.id_txt);
            this.add_pnl.Controls.Add(this.city_txt);
            this.add_pnl.Controls.Add(this.street_txt);
            this.add_pnl.Controls.Add(this.phone_txt);
            this.add_pnl.Controls.Add(this.newPassword_txt);
            this.add_pnl.Controls.Add(this.email_txt);
            this.add_pnl.Controls.Add(this.surname_txt);
            this.add_pnl.Controls.Add(this.bunifuCustomLabel4);
            this.add_pnl.Controls.Add(this.newName_txt);
            this.animator2.SetDecoration(this.add_pnl, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.add_pnl, AnimatorNS.DecorationType.None);
            resources.ApplyResources(this.add_pnl, "add_pnl");
            this.add_pnl.Name = "add_pnl";
            this.add_pnl.Paint += new System.Windows.Forms.PaintEventHandler(this.add_pnl_Paint);
            // 
            // pictureBox3
            // 
            this.animator1.SetDecoration(this.pictureBox3, AnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.pictureBox3, AnimatorNS.DecorationType.None);
            this.pictureBox3.Image = global::AU_Task.Properties.Resources.cancel_48px;
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // add_btn
            // 
            this.add_btn.ActiveBorderThickness = 1;
            this.add_btn.ActiveCornerRadius = 20;
            this.add_btn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.add_btn.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.add_btn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.add_btn, "add_btn");
            this.add_btn.ButtonText = "Done ";
            this.add_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator2.SetDecoration(this.add_btn, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.add_btn, AnimatorNS.DecorationType.None);
            this.add_btn.ForeColor = System.Drawing.Color.SeaGreen;
            this.add_btn.IdleBorderThickness = 1;
            this.add_btn.IdleCornerRadius = 30;
            this.add_btn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.add_btn.IdleForecolor = System.Drawing.Color.White;
            this.add_btn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.add_btn.Name = "add_btn";
            this.add_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // error_txt2
            // 
            resources.ApplyResources(this.error_txt2, "error_txt2");
            this.error_txt2.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.error_txt2, AnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.error_txt2, AnimatorNS.DecorationType.None);
            this.error_txt2.ForeColor = System.Drawing.Color.Red;
            this.error_txt2.Name = "error_txt2";
            // 
            // id_txt
            // 
            this.id_txt.BackColor = System.Drawing.Color.BurlyWood;
            resources.ApplyResources(this.id_txt, "id_txt");
            this.animator2.SetDecoration(this.id_txt, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.id_txt, AnimatorNS.DecorationType.None);
            this.id_txt.ForeColor = System.Drawing.Color.DimGray;
            this.id_txt.Icon = ((System.Drawing.Image)(resources.GetObject("id_txt.Icon")));
            this.id_txt.Name = "id_txt";
            this.id_txt.text = "Enter National ID please";
            // 
            // city_txt
            // 
            this.city_txt.BackColor = System.Drawing.Color.BurlyWood;
            resources.ApplyResources(this.city_txt, "city_txt");
            this.animator2.SetDecoration(this.city_txt, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.city_txt, AnimatorNS.DecorationType.None);
            this.city_txt.ForeColor = System.Drawing.Color.DimGray;
            this.city_txt.Icon = ((System.Drawing.Image)(resources.GetObject("city_txt.Icon")));
            this.city_txt.Name = "city_txt";
            this.city_txt.text = "Enter Your City please";
            // 
            // street_txt
            // 
            this.street_txt.BackColor = System.Drawing.Color.BurlyWood;
            resources.ApplyResources(this.street_txt, "street_txt");
            this.animator2.SetDecoration(this.street_txt, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.street_txt, AnimatorNS.DecorationType.None);
            this.street_txt.ForeColor = System.Drawing.Color.DimGray;
            this.street_txt.Icon = ((System.Drawing.Image)(resources.GetObject("street_txt.Icon")));
            this.street_txt.Name = "street_txt";
            this.street_txt.text = "Enter Your Street please";
            // 
            // phone_txt
            // 
            this.phone_txt.BackColor = System.Drawing.Color.BurlyWood;
            resources.ApplyResources(this.phone_txt, "phone_txt");
            this.animator2.SetDecoration(this.phone_txt, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.phone_txt, AnimatorNS.DecorationType.None);
            this.phone_txt.ForeColor = System.Drawing.Color.DimGray;
            this.phone_txt.Icon = ((System.Drawing.Image)(resources.GetObject("phone_txt.Icon")));
            this.phone_txt.Name = "phone_txt";
            this.phone_txt.text = "Enter Your Moblie Number please";
            // 
            // newPassword_txt
            // 
            this.newPassword_txt.BackColor = System.Drawing.Color.BurlyWood;
            resources.ApplyResources(this.newPassword_txt, "newPassword_txt");
            this.animator2.SetDecoration(this.newPassword_txt, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.newPassword_txt, AnimatorNS.DecorationType.None);
            this.newPassword_txt.ForeColor = System.Drawing.Color.DimGray;
            this.newPassword_txt.Icon = ((System.Drawing.Image)(resources.GetObject("newPassword_txt.Icon")));
            this.newPassword_txt.Name = "newPassword_txt";
            this.newPassword_txt.text = "Enter Your Password please";
            // 
            // email_txt
            // 
            this.email_txt.BackColor = System.Drawing.Color.BurlyWood;
            resources.ApplyResources(this.email_txt, "email_txt");
            this.animator2.SetDecoration(this.email_txt, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.email_txt, AnimatorNS.DecorationType.None);
            this.email_txt.ForeColor = System.Drawing.Color.DimGray;
            this.email_txt.Icon = ((System.Drawing.Image)(resources.GetObject("email_txt.Icon")));
            this.email_txt.Name = "email_txt";
            this.email_txt.text = "Enter Your Email please";
            // 
            // surname_txt
            // 
            this.surname_txt.BackColor = System.Drawing.Color.BurlyWood;
            resources.ApplyResources(this.surname_txt, "surname_txt");
            this.animator2.SetDecoration(this.surname_txt, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.surname_txt, AnimatorNS.DecorationType.None);
            this.surname_txt.ForeColor = System.Drawing.Color.DimGray;
            this.surname_txt.Icon = ((System.Drawing.Image)(resources.GetObject("surname_txt.Icon")));
            this.surname_txt.Name = "surname_txt";
            this.surname_txt.text = "Enter Your SurName please";
            // 
            // bunifuCustomLabel4
            // 
            resources.ApplyResources(this.bunifuCustomLabel4, "bunifuCustomLabel4");
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.bunifuCustomLabel4, AnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.bunifuCustomLabel4, AnimatorNS.DecorationType.None);
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            // 
            // newName_txt
            // 
            this.newName_txt.BackColor = System.Drawing.Color.BurlyWood;
            resources.ApplyResources(this.newName_txt, "newName_txt");
            this.animator2.SetDecoration(this.newName_txt, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.newName_txt, AnimatorNS.DecorationType.None);
            this.newName_txt.ForeColor = System.Drawing.Color.DimGray;
            this.newName_txt.Icon = ((System.Drawing.Image)(resources.GetObject("newName_txt.Icon")));
            this.newName_txt.Name = "newName_txt";
            this.newName_txt.text = "Enter Your Name please";
            // 
            // animator2
            // 
            this.animator2.AnimationType = AnimatorNS.AnimationType.Rotate;
            this.animator2.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(50);
            animation2.RotateCoeff = 1F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 1F;
            this.animator2.DefaultAnimation = animation2;
            this.animator2.TimeStep = 0.005F;
            // 
            // Log_In
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AU_Task.Properties.Resources.s2;
            this.Controls.Add(this.add_pnl);
            this.Controls.Add(this.log_pnl);
            this.animator1.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Log_In";
            this.Load += new System.EventHandler(this.Log_In_Load);
            this.log_pnl.ResumeLayout(false);
            this.log_pnl.PerformLayout();
            this.btn_pnl.ResumeLayout(false);
            this.add_pnl.ResumeLayout(false);
            this.add_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel log_pnl;
        private Bunifu.Framework.UI.BunifuTextbox name_txt;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuThinButton2 signE;
        private Bunifu.Framework.UI.BunifuThinButton2 logE;
        private System.Windows.Forms.Panel btn_pnl;
        private Bunifu.Framework.UI.BunifuThinButton2 LogA;
        private Bunifu.Framework.UI.BunifuThinButton2 signA;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuTextbox pass_txt;
        private Bunifu.Framework.UI.BunifuCustomLabel error_txt;
        private AnimatorNS.Animator animator1;
        private System.Windows.Forms.Panel add_pnl;
        private Bunifu.Framework.UI.BunifuTextbox id_txt;
        private Bunifu.Framework.UI.BunifuTextbox city_txt;
        private Bunifu.Framework.UI.BunifuTextbox street_txt;
        private Bunifu.Framework.UI.BunifuTextbox phone_txt;
        private Bunifu.Framework.UI.BunifuTextbox newPassword_txt;
        private Bunifu.Framework.UI.BunifuTextbox email_txt;
        private Bunifu.Framework.UI.BunifuTextbox surname_txt;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuTextbox newName_txt;
        private Bunifu.Framework.UI.BunifuCustomLabel error_txt2;
        private Bunifu.Framework.UI.BunifuThinButton2 add_btn;
        private AnimatorNS.Animator animator2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}