namespace AU_Task
{
    partial class all_doc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(all_doc));
            this.hours = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.email = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.name = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.id = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.days = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // hours
            // 
            resources.ApplyResources(this.hours, "hours");
            this.hours.BackColor = System.Drawing.Color.Transparent;
            this.hours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(179)))));
            this.hours.Name = "hours";
            // 
            // email
            // 
            resources.ApplyResources(this.email, "email");
            this.email.BackColor = System.Drawing.Color.Transparent;
            this.email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(179)))));
            this.email.Name = "email";
            // 
            // name
            // 
            resources.ApplyResources(this.name, "name");
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(179)))));
            this.name.Name = "name";
            // 
            // id
            // 
            resources.ApplyResources(this.id, "id");
            this.id.BackColor = System.Drawing.Color.Transparent;
            this.id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(179)))));
            this.id.Name = "id";
            // 
            // days
            // 
            resources.ApplyResources(this.days, "days");
            this.days.BackColor = System.Drawing.Color.Transparent;
            this.days.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(179)))));
            this.days.Name = "days";
            // 
            // all_doc
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.days);
            this.Controls.Add(this.hours);
            this.Controls.Add(this.email);
            this.Controls.Add(this.name);
            this.Controls.Add(this.id);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Name = "all_doc";
            this.Load += new System.EventHandler(this.all_doc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel hours;
        private Bunifu.Framework.UI.BunifuCustomLabel email;
        private Bunifu.Framework.UI.BunifuCustomLabel name;
        private Bunifu.Framework.UI.BunifuCustomLabel id;
        private Bunifu.Framework.UI.BunifuCustomLabel days;
    }
}
