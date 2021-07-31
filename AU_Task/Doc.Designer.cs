namespace AU_Task
{
    partial class Doc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doc));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.show_pnl = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.birthdate = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.surname = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.name = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.id = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.back_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.show_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // show_pnl
            // 
            this.show_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.show_pnl.Controls.Add(this.bunifuCustomLabel1);
            this.show_pnl.Controls.Add(this.birthdate);
            this.show_pnl.Controls.Add(this.surname);
            this.show_pnl.Controls.Add(this.name);
            this.show_pnl.Controls.Add(this.id);
            this.show_pnl.Controls.Add(this.flowLayoutPanel1);
            this.show_pnl.Controls.Add(this.bunifuCustomLabel2);
            this.show_pnl.ForeColor = System.Drawing.Color.Chocolate;
            resources.ApplyResources(this.show_pnl, "show_pnl");
            this.show_pnl.Name = "show_pnl";
            // 
            // bunifuCustomLabel1
            // 
            resources.ApplyResources(this.bunifuCustomLabel1, "bunifuCustomLabel1");
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            // 
            // birthdate
            // 
            resources.ApplyResources(this.birthdate, "birthdate");
            this.birthdate.BackColor = System.Drawing.Color.Transparent;
            this.birthdate.ForeColor = System.Drawing.Color.White;
            this.birthdate.Name = "birthdate";
            // 
            // surname
            // 
            resources.ApplyResources(this.surname, "surname");
            this.surname.BackColor = System.Drawing.Color.Transparent;
            this.surname.ForeColor = System.Drawing.Color.White;
            this.surname.Name = "surname";
            // 
            // name
            // 
            resources.ApplyResources(this.name, "name");
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Name = "name";
            // 
            // id
            // 
            resources.ApplyResources(this.id, "id");
            this.id.BackColor = System.Drawing.Color.Transparent;
            this.id.ForeColor = System.Drawing.Color.White;
            this.id.Name = "id";
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // bunifuCustomLabel2
            // 
            resources.ApplyResources(this.bunifuCustomLabel2, "bunifuCustomLabel2");
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::AU_Task.Properties.Resources.cancel_48px;
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // back_btn
            // 
            this.back_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.back_btn.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.back_btn, "back_btn");
            this.back_btn.BorderRadius = 0;
            this.back_btn.ButtonText = "";
            this.back_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_btn.DisabledColor = System.Drawing.Color.White;
            this.back_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.back_btn.Iconimage = global::AU_Task.Properties.Resources.back2;
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
            // Doc
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AU_Task.Properties.Resources.s2;
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.show_pnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Doc";
            this.Load += new System.EventHandler(this.Doc_Load);
            this.show_pnl.ResumeLayout(false);
            this.show_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel show_pnl;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel birthdate;
        private Bunifu.Framework.UI.BunifuCustomLabel surname;
        private Bunifu.Framework.UI.BunifuCustomLabel name;
        private Bunifu.Framework.UI.BunifuCustomLabel id;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuFlatButton back_btn;
    }
}