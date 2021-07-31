namespace AU_Task
{
    partial class Splash_Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash_Screen));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.lang_pnl = new System.Windows.Forms.Panel();
            this.error_txt = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.add_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.gender_pnl = new System.Windows.Forms.GroupBox();
            this.arabic = new System.Windows.Forms.RadioButton();
            this.english = new System.Windows.Forms.RadioButton();
            this.splach_pnl = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuProgressBar1 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.lang_pnl.SuspendLayout();
            this.gender_pnl.SuspendLayout();
            this.splach_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // lang_pnl
            // 
            this.lang_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lang_pnl.Controls.Add(this.error_txt);
            this.lang_pnl.Controls.Add(this.add_btn);
            this.lang_pnl.Controls.Add(this.bunifuCustomLabel3);
            this.lang_pnl.Controls.Add(this.gender_pnl);
            resources.ApplyResources(this.lang_pnl, "lang_pnl");
            this.lang_pnl.Name = "lang_pnl";
            // 
            // error_txt
            // 
            resources.ApplyResources(this.error_txt, "error_txt");
            this.error_txt.BackColor = System.Drawing.Color.Transparent;
            this.error_txt.ForeColor = System.Drawing.Color.Red;
            this.error_txt.Name = "error_txt";
            // 
            // add_btn
            // 
            this.add_btn.ActiveBorderThickness = 1;
            this.add_btn.ActiveCornerRadius = 20;
            this.add_btn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.add_btn.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.add_btn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.add_btn.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.add_btn, "add_btn");
            this.add_btn.ButtonText = " Done";
            this.add_btn.Cursor = System.Windows.Forms.Cursors.Hand;
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
            // bunifuCustomLabel3
            // 
            resources.ApplyResources(this.bunifuCustomLabel3, "bunifuCustomLabel3");
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Click += new System.EventHandler(this.bunifuCustomLabel3_Click);
            // 
            // gender_pnl
            // 
            this.gender_pnl.BackColor = System.Drawing.Color.Transparent;
            this.gender_pnl.Controls.Add(this.arabic);
            this.gender_pnl.Controls.Add(this.english);
            resources.ApplyResources(this.gender_pnl, "gender_pnl");
            this.gender_pnl.Name = "gender_pnl";
            this.gender_pnl.TabStop = false;
            // 
            // arabic
            // 
            resources.ApplyResources(this.arabic, "arabic");
            this.arabic.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.arabic.Name = "arabic";
            this.arabic.TabStop = true;
            this.arabic.UseVisualStyleBackColor = true;
            // 
            // english
            // 
            resources.ApplyResources(this.english, "english");
            this.english.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.english.Name = "english";
            this.english.TabStop = true;
            this.english.UseVisualStyleBackColor = true;
            // 
            // splach_pnl
            // 
            this.splach_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.splach_pnl.Controls.Add(this.bunifuCustomLabel2);
            this.splach_pnl.Controls.Add(this.bunifuCustomLabel1);
            this.splach_pnl.Controls.Add(this.bunifuProgressBar1);
            this.splach_pnl.ForeColor = System.Drawing.Color.Chocolate;
            resources.ApplyResources(this.splach_pnl, "splach_pnl");
            this.splach_pnl.Name = "splach_pnl";
            this.splach_pnl.Paint += new System.Windows.Forms.PaintEventHandler(this.splach_pnl_Paint_1);
            // 
            // bunifuCustomLabel2
            // 
            resources.ApplyResources(this.bunifuCustomLabel2, "bunifuCustomLabel2");
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(179)))));
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Click += new System.EventHandler(this.bunifuCustomLabel2_Click);
            // 
            // bunifuCustomLabel1
            // 
            resources.ApplyResources(this.bunifuCustomLabel1, "bunifuCustomLabel1");
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(179)))));
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            // 
            // bunifuProgressBar1
            // 
            this.bunifuProgressBar1.BackColor = System.Drawing.Color.White;
            this.bunifuProgressBar1.BorderRadius = 30;
            resources.ApplyResources(this.bunifuProgressBar1, "bunifuProgressBar1");
            this.bunifuProgressBar1.MaximumValue = 100;
            this.bunifuProgressBar1.Name = "bunifuProgressBar1";
            this.bunifuProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(179)))));
            this.bunifuProgressBar1.Value = 0;
            // 
            // Splash_Screen
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.BackgroundImage = global::AU_Task.Properties.Resources.s2;
            this.Controls.Add(this.splach_pnl);
            this.Controls.Add(this.lang_pnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash_Screen";
            this.Load += new System.EventHandler(this.Splash_Screen_Load);
            this.lang_pnl.ResumeLayout(false);
            this.lang_pnl.PerformLayout();
            this.gender_pnl.ResumeLayout(false);
            this.gender_pnl.PerformLayout();
            this.splach_pnl.ResumeLayout(false);
            this.splach_pnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel splach_pnl;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuProgressBar bunifuProgressBar1;
        private System.Windows.Forms.Panel lang_pnl;
        private Bunifu.Framework.UI.BunifuThinButton2 add_btn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.GroupBox gender_pnl;
        private System.Windows.Forms.RadioButton arabic;
        private System.Windows.Forms.RadioButton english;
        private Bunifu.Framework.UI.BunifuCustomLabel error_txt;
    }
}

