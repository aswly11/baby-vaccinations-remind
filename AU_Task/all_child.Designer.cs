namespace AU_Task
{
    partial class all_child
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(all_child));
            this.id = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.name = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.surname = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.birthdate = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // id
            // 
            resources.ApplyResources(this.id, "id");
            this.id.BackColor = System.Drawing.Color.Transparent;
            this.id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(179)))));
            this.id.Name = "id";
            this.toolTip1.SetToolTip(this.id, resources.GetString("id.ToolTip"));
            this.id.Click += new System.EventHandler(this.bunifuCustomLabel2_Click);
            // 
            // name
            // 
            resources.ApplyResources(this.name, "name");
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(179)))));
            this.name.Name = "name";
            this.toolTip1.SetToolTip(this.name, resources.GetString("name.ToolTip"));
            this.name.Click += new System.EventHandler(this.name_Click);
            // 
            // surname
            // 
            resources.ApplyResources(this.surname, "surname");
            this.surname.BackColor = System.Drawing.Color.Transparent;
            this.surname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(179)))));
            this.surname.Name = "surname";
            this.toolTip1.SetToolTip(this.surname, resources.GetString("surname.ToolTip"));
            // 
            // birthdate
            // 
            resources.ApplyResources(this.birthdate, "birthdate");
            this.birthdate.BackColor = System.Drawing.Color.Transparent;
            this.birthdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(179)))));
            this.birthdate.Name = "birthdate";
            this.toolTip1.SetToolTip(this.birthdate, resources.GetString("birthdate.ToolTip"));
            // 
            // all_child
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.birthdate);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.name);
            this.Controls.Add(this.id);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Name = "all_child";
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.Load += new System.EventHandler(this.all_child_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel id;
        private Bunifu.Framework.UI.BunifuCustomLabel name;
        private Bunifu.Framework.UI.BunifuCustomLabel surname;
        private Bunifu.Framework.UI.BunifuCustomLabel birthdate;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
