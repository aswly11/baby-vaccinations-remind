namespace AU_Task
{
    partial class CH3
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
            AnimatorNS.Animation animation3 = new AnimatorNS.Animation();
            AnimatorNS.Animation animation2 = new AnimatorNS.Animation();
            AnimatorNS.Animation animation1 = new AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CH3));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel6 = new System.Windows.Forms.Panel();
            this.showD_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.show_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.menu_btn = new Bunifu.Framework.UI.BunifuImageButton();
            this.Pic = new System.Windows.Forms.PictureBox();
            this.back_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.addC_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.animator1 = new AnimatorNS.Animator(this.components);
            this.add_pnl = new System.Windows.Forms.Panel();
            this.error_txt2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.add_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuDatepicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.surname_txt = new Bunifu.Framework.UI.BunifuTextbox();
            this.newName_txt = new Bunifu.Framework.UI.BunifuTextbox();
            this.show_pnl = new System.Windows.Forms.Panel();
            this.birthdate = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.surname = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.name = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.id = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.logo = new AnimatorNS.Animator(this.components);
            this.panel = new AnimatorNS.Animator(this.components);
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menu_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).BeginInit();
            this.add_pnl.SuspendLayout();
            this.show_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.panel6.Controls.Add(this.showD_btn);
            this.panel6.Controls.Add(this.show_btn);
            this.panel6.Controls.Add(this.menu_btn);
            this.panel6.Controls.Add(this.Pic);
            this.panel6.Controls.Add(this.back_btn);
            this.panel6.Controls.Add(this.addC_btn);
            this.animator1.SetDecoration(this.panel6, AnimatorNS.DecorationType.None);
            this.logo.SetDecoration(this.panel6, AnimatorNS.DecorationType.None);
            this.panel.SetDecoration(this.panel6, AnimatorNS.DecorationType.None);
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.Name = "panel6";
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // showD_btn
            // 
            this.showD_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.showD_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            resources.ApplyResources(this.showD_btn, "showD_btn");
            this.showD_btn.BorderRadius = 0;
            this.showD_btn.ButtonText = "        Show all Doctors";
            this.showD_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel.SetDecoration(this.showD_btn, AnimatorNS.DecorationType.None);
            this.logo.SetDecoration(this.showD_btn, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.showD_btn, AnimatorNS.DecorationType.None);
            this.showD_btn.DisabledColor = System.Drawing.Color.Gray;
            this.showD_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.showD_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("showD_btn.Iconimage")));
            this.showD_btn.Iconimage_right = null;
            this.showD_btn.Iconimage_right_Selected = null;
            this.showD_btn.Iconimage_Selected = null;
            this.showD_btn.IconMarginLeft = 0;
            this.showD_btn.IconMarginRight = 0;
            this.showD_btn.IconRightVisible = true;
            this.showD_btn.IconRightZoom = 0D;
            this.showD_btn.IconVisible = true;
            this.showD_btn.IconZoom = 60D;
            this.showD_btn.IsTab = true;
            this.showD_btn.Name = "showD_btn";
            this.showD_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.showD_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.showD_btn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.showD_btn.selected = false;
            this.showD_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showD_btn.Textcolor = System.Drawing.Color.Silver;
            this.showD_btn.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showD_btn.Click += new System.EventHandler(this.showD_btn_Click);
            // 
            // show_btn
            // 
            this.show_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.show_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            resources.ApplyResources(this.show_btn, "show_btn");
            this.show_btn.BorderRadius = 0;
            this.show_btn.ButtonText = "        Show all Childeren";
            this.show_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel.SetDecoration(this.show_btn, AnimatorNS.DecorationType.None);
            this.logo.SetDecoration(this.show_btn, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.show_btn, AnimatorNS.DecorationType.None);
            this.show_btn.DisabledColor = System.Drawing.Color.Gray;
            this.show_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.show_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("show_btn.Iconimage")));
            this.show_btn.Iconimage_right = null;
            this.show_btn.Iconimage_right_Selected = null;
            this.show_btn.Iconimage_Selected = null;
            this.show_btn.IconMarginLeft = 0;
            this.show_btn.IconMarginRight = 0;
            this.show_btn.IconRightVisible = true;
            this.show_btn.IconRightZoom = 0D;
            this.show_btn.IconVisible = true;
            this.show_btn.IconZoom = 60D;
            this.show_btn.IsTab = true;
            this.show_btn.Name = "show_btn";
            this.show_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.show_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.show_btn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.show_btn.selected = false;
            this.show_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.show_btn.Textcolor = System.Drawing.Color.Silver;
            this.show_btn.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_btn.Click += new System.EventHandler(this.show_btn_Click);
            // 
            // menu_btn
            // 
            this.menu_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.animator1.SetDecoration(this.menu_btn, AnimatorNS.DecorationType.None);
            this.logo.SetDecoration(this.menu_btn, AnimatorNS.DecorationType.None);
            this.panel.SetDecoration(this.menu_btn, AnimatorNS.DecorationType.None);
            resources.ApplyResources(this.menu_btn, "menu_btn");
            this.menu_btn.ImageActive = null;
            this.menu_btn.Name = "menu_btn";
            this.menu_btn.TabStop = false;
            this.menu_btn.Zoom = 10;
            this.menu_btn.Click += new System.EventHandler(this.menu_btn_Click);
            // 
            // Pic
            // 
            this.panel.SetDecoration(this.Pic, AnimatorNS.DecorationType.None);
            this.logo.SetDecoration(this.Pic, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.Pic, AnimatorNS.DecorationType.None);
            this.Pic.Image = global::AU_Task.Properties.Resources.images__16_;
            resources.ApplyResources(this.Pic, "Pic");
            this.Pic.Name = "Pic";
            this.Pic.TabStop = false;
            // 
            // back_btn
            // 
            this.back_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.back_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            resources.ApplyResources(this.back_btn, "back_btn");
            this.back_btn.BorderRadius = 0;
            this.back_btn.ButtonText = "               Back";
            this.back_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel.SetDecoration(this.back_btn, AnimatorNS.DecorationType.None);
            this.logo.SetDecoration(this.back_btn, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.back_btn, AnimatorNS.DecorationType.None);
            this.back_btn.DisabledColor = System.Drawing.Color.Gray;
            this.back_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.back_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("back_btn.Iconimage")));
            this.back_btn.Iconimage_right = null;
            this.back_btn.Iconimage_right_Selected = null;
            this.back_btn.Iconimage_Selected = null;
            this.back_btn.IconMarginLeft = 0;
            this.back_btn.IconMarginRight = 0;
            this.back_btn.IconRightVisible = true;
            this.back_btn.IconRightZoom = 0D;
            this.back_btn.IconVisible = true;
            this.back_btn.IconZoom = 40D;
            this.back_btn.IsTab = true;
            this.back_btn.Name = "back_btn";
            this.back_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.back_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.back_btn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.back_btn.selected = false;
            this.back_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.back_btn.Textcolor = System.Drawing.Color.Silver;
            this.back_btn.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // addC_btn
            // 
            this.addC_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.addC_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            resources.ApplyResources(this.addC_btn, "addC_btn");
            this.addC_btn.BorderRadius = 0;
            this.addC_btn.ButtonText = "        Add Childeren";
            this.addC_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel.SetDecoration(this.addC_btn, AnimatorNS.DecorationType.None);
            this.logo.SetDecoration(this.addC_btn, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.addC_btn, AnimatorNS.DecorationType.None);
            this.addC_btn.DisabledColor = System.Drawing.Color.Gray;
            this.addC_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.addC_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("addC_btn.Iconimage")));
            this.addC_btn.Iconimage_right = null;
            this.addC_btn.Iconimage_right_Selected = null;
            this.addC_btn.Iconimage_Selected = null;
            this.addC_btn.IconMarginLeft = 0;
            this.addC_btn.IconMarginRight = 0;
            this.addC_btn.IconRightVisible = true;
            this.addC_btn.IconRightZoom = 0D;
            this.addC_btn.IconVisible = true;
            this.addC_btn.IconZoom = 60D;
            this.addC_btn.IsTab = true;
            this.addC_btn.Name = "addC_btn";
            this.addC_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.addC_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.addC_btn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.addC_btn.selected = false;
            this.addC_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addC_btn.Textcolor = System.Drawing.Color.Silver;
            this.addC_btn.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addC_btn.Click += new System.EventHandler(this.addC_btn_Click);
            // 
            // animator1
            // 
            this.animator1.AnimationType = AnimatorNS.AnimationType.Mosaic;
            this.animator1.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 20;
            animation3.Padding = new System.Windows.Forms.Padding(30);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.animator1.DefaultAnimation = animation3;
            this.animator1.TimeStep = 0.005F;
            // 
            // add_pnl
            // 
            this.add_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.add_pnl.Controls.Add(this.error_txt2);
            this.add_pnl.Controls.Add(this.add_btn);
            this.add_pnl.Controls.Add(this.bunifuDatepicker1);
            this.add_pnl.Controls.Add(this.bunifuCustomLabel4);
            this.add_pnl.Controls.Add(this.surname_txt);
            this.add_pnl.Controls.Add(this.newName_txt);
            this.animator1.SetDecoration(this.add_pnl, AnimatorNS.DecorationType.None);
            this.logo.SetDecoration(this.add_pnl, AnimatorNS.DecorationType.None);
            this.panel.SetDecoration(this.add_pnl, AnimatorNS.DecorationType.None);
            this.add_pnl.ForeColor = System.Drawing.Color.Chocolate;
            resources.ApplyResources(this.add_pnl, "add_pnl");
            this.add_pnl.Name = "add_pnl";
            this.add_pnl.Paint += new System.Windows.Forms.PaintEventHandler(this.add_pnl_Paint);
            // 
            // error_txt2
            // 
            resources.ApplyResources(this.error_txt2, "error_txt2");
            this.error_txt2.BackColor = System.Drawing.Color.Transparent;
            this.panel.SetDecoration(this.error_txt2, AnimatorNS.DecorationType.None);
            this.logo.SetDecoration(this.error_txt2, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.error_txt2, AnimatorNS.DecorationType.None);
            this.error_txt2.ForeColor = System.Drawing.Color.Red;
            this.error_txt2.Name = "error_txt2";
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
            this.animator1.SetDecoration(this.add_btn, AnimatorNS.DecorationType.None);
            this.panel.SetDecoration(this.add_btn, AnimatorNS.DecorationType.None);
            this.logo.SetDecoration(this.add_btn, AnimatorNS.DecorationType.None);
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
            // bunifuDatepicker1
            // 
            this.bunifuDatepicker1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuDatepicker1.BorderRadius = 0;
            this.logo.SetDecoration(this.bunifuDatepicker1, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.bunifuDatepicker1, AnimatorNS.DecorationType.None);
            this.panel.SetDecoration(this.bunifuDatepicker1, AnimatorNS.DecorationType.None);
            this.bunifuDatepicker1.ForeColor = System.Drawing.Color.White;
            this.bunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bunifuDatepicker1.FormatCustom = null;
            resources.ApplyResources(this.bunifuDatepicker1, "bunifuDatepicker1");
            this.bunifuDatepicker1.Name = "bunifuDatepicker1";
            this.bunifuDatepicker1.Value = new System.DateTime(2019, 8, 26, 17, 46, 18, 513);
            // 
            // bunifuCustomLabel4
            // 
            resources.ApplyResources(this.bunifuCustomLabel4, "bunifuCustomLabel4");
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.panel.SetDecoration(this.bunifuCustomLabel4, AnimatorNS.DecorationType.None);
            this.logo.SetDecoration(this.bunifuCustomLabel4, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.bunifuCustomLabel4, AnimatorNS.DecorationType.None);
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            // 
            // surname_txt
            // 
            this.surname_txt.BackColor = System.Drawing.Color.BurlyWood;
            resources.ApplyResources(this.surname_txt, "surname_txt");
            this.animator1.SetDecoration(this.surname_txt, AnimatorNS.DecorationType.None);
            this.logo.SetDecoration(this.surname_txt, AnimatorNS.DecorationType.None);
            this.panel.SetDecoration(this.surname_txt, AnimatorNS.DecorationType.None);
            this.surname_txt.ForeColor = System.Drawing.Color.DimGray;
            this.surname_txt.Icon = ((System.Drawing.Image)(resources.GetObject("surname_txt.Icon")));
            this.surname_txt.Name = "surname_txt";
            this.surname_txt.text = "Enter Your SurName please";
            // 
            // newName_txt
            // 
            this.newName_txt.BackColor = System.Drawing.Color.BurlyWood;
            resources.ApplyResources(this.newName_txt, "newName_txt");
            this.animator1.SetDecoration(this.newName_txt, AnimatorNS.DecorationType.None);
            this.logo.SetDecoration(this.newName_txt, AnimatorNS.DecorationType.None);
            this.panel.SetDecoration(this.newName_txt, AnimatorNS.DecorationType.None);
            this.newName_txt.ForeColor = System.Drawing.Color.DimGray;
            this.newName_txt.Icon = ((System.Drawing.Image)(resources.GetObject("newName_txt.Icon")));
            this.newName_txt.Name = "newName_txt";
            this.newName_txt.text = "Enter Your Name please";
            // 
            // show_pnl
            // 
            this.show_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.show_pnl.Controls.Add(this.birthdate);
            this.show_pnl.Controls.Add(this.surname);
            this.show_pnl.Controls.Add(this.name);
            this.show_pnl.Controls.Add(this.id);
            this.show_pnl.Controls.Add(this.flowLayoutPanel1);
            this.show_pnl.Controls.Add(this.bunifuCustomLabel2);
            this.animator1.SetDecoration(this.show_pnl, AnimatorNS.DecorationType.None);
            this.logo.SetDecoration(this.show_pnl, AnimatorNS.DecorationType.None);
            this.panel.SetDecoration(this.show_pnl, AnimatorNS.DecorationType.None);
            this.show_pnl.ForeColor = System.Drawing.Color.Chocolate;
            resources.ApplyResources(this.show_pnl, "show_pnl");
            this.show_pnl.Name = "show_pnl";
            this.show_pnl.Paint += new System.Windows.Forms.PaintEventHandler(this.show_pnl_Paint);
            // 
            // birthdate
            // 
            resources.ApplyResources(this.birthdate, "birthdate");
            this.birthdate.BackColor = System.Drawing.Color.Transparent;
            this.panel.SetDecoration(this.birthdate, AnimatorNS.DecorationType.None);
            this.logo.SetDecoration(this.birthdate, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.birthdate, AnimatorNS.DecorationType.None);
            this.birthdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(179)))));
            this.birthdate.Name = "birthdate";
            // 
            // surname
            // 
            resources.ApplyResources(this.surname, "surname");
            this.surname.BackColor = System.Drawing.Color.Transparent;
            this.panel.SetDecoration(this.surname, AnimatorNS.DecorationType.None);
            this.logo.SetDecoration(this.surname, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.surname, AnimatorNS.DecorationType.None);
            this.surname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(179)))));
            this.surname.Name = "surname";
            // 
            // name
            // 
            resources.ApplyResources(this.name, "name");
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.panel.SetDecoration(this.name, AnimatorNS.DecorationType.None);
            this.logo.SetDecoration(this.name, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.name, AnimatorNS.DecorationType.None);
            this.name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(179)))));
            this.name.Name = "name";
            // 
            // id
            // 
            resources.ApplyResources(this.id, "id");
            this.id.BackColor = System.Drawing.Color.Transparent;
            this.panel.SetDecoration(this.id, AnimatorNS.DecorationType.None);
            this.logo.SetDecoration(this.id, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.id, AnimatorNS.DecorationType.None);
            this.id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(179)))));
            this.id.Name = "id";
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.panel.SetDecoration(this.flowLayoutPanel1, AnimatorNS.DecorationType.None);
            this.logo.SetDecoration(this.flowLayoutPanel1, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.flowLayoutPanel1, AnimatorNS.DecorationType.None);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // bunifuCustomLabel2
            // 
            resources.ApplyResources(this.bunifuCustomLabel2, "bunifuCustomLabel2");
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.panel.SetDecoration(this.bunifuCustomLabel2, AnimatorNS.DecorationType.None);
            this.logo.SetDecoration(this.bunifuCustomLabel2, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.bunifuCustomLabel2, AnimatorNS.DecorationType.None);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            // 
            // logo
            // 
            this.logo.AnimationType = AnimatorNS.AnimationType.Mosaic;
            this.logo.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 20;
            animation2.Padding = new System.Windows.Forms.Padding(30);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.logo.DefaultAnimation = animation2;
            this.logo.TimeStep = 0.005F;
            // 
            // panel
            // 
            this.panel.AnimationType = AnimatorNS.AnimationType.Rotate;
            this.panel.Cursor = null;
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
            this.panel.DefaultAnimation = animation1;
            this.panel.TimeStep = 0.005F;
            // 
            // CH3
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AU_Task.Properties.Resources.s2;
            this.Controls.Add(this.show_pnl);
            this.Controls.Add(this.add_pnl);
            this.Controls.Add(this.panel6);
            this.logo.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.panel.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CH3";
            this.Load += new System.EventHandler(this.CH3_Load);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menu_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).EndInit();
            this.add_pnl.ResumeLayout(false);
            this.add_pnl.PerformLayout();
            this.show_pnl.ResumeLayout(false);
            this.show_pnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel6;
        private Bunifu.Framework.UI.BunifuFlatButton show_btn;
        private AnimatorNS.Animator panel;
        private AnimatorNS.Animator logo;
        private AnimatorNS.Animator animator1;
        private Bunifu.Framework.UI.BunifuImageButton menu_btn;
        private System.Windows.Forms.PictureBox Pic;
        private Bunifu.Framework.UI.BunifuFlatButton back_btn;
        private Bunifu.Framework.UI.BunifuFlatButton addC_btn;
        private System.Windows.Forms.Panel add_pnl;
        private Bunifu.Framework.UI.BunifuTextbox surname_txt;
        private Bunifu.Framework.UI.BunifuTextbox newName_txt;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker1;
        private Bunifu.Framework.UI.BunifuThinButton2 add_btn;
        private Bunifu.Framework.UI.BunifuCustomLabel error_txt2;
        private System.Windows.Forms.Panel show_pnl;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel birthdate;
        private Bunifu.Framework.UI.BunifuCustomLabel surname;
        private Bunifu.Framework.UI.BunifuCustomLabel name;
        private Bunifu.Framework.UI.BunifuCustomLabel id;
        private Bunifu.Framework.UI.BunifuFlatButton showD_btn;
    }
}