using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AU_Task
{
    public partial class Splash_Screen : Form
    {
        Log_In form1;
        parent p;
        int progress = 0;
        string language = "";
        public Splash_Screen()
        {
            InitializeComponent();
           splach_pnl.Visible = false;
            lang_pnl.Visible = true;
            error_txt.Visible = false;
        }

        private void Splash_Screen_Load(object sender, EventArgs e)
        {
          // timer1.Enabled = true;
          // timer1.Interval = 20;
         
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuProgressBar1_progressChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progress += 1;
            if (progress >= 100)
            {
                timer1.Enabled = false;
               timer1.Stop();
                this.Hide();
          
                form1.ShowDialog();
                this.Close();
            }
            bunifuProgressBar1.Value = progress;
        }

        private void age_combix_SelectedIndexChanged(object sender, EventArgs e)
        {
           
          
        }

        private void splach_pnl_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
           
            if (!arabic.Checked && !english.Checked)
            {
                error_txt.Visible = true;
                splach_pnl.Visible = false;
            }
            else if (arabic.Checked)
            {
                this.Controls.Clear();
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ar-EG");
                lang_pnl.Visible = false;
                splach_pnl.Visible = true;
                language = "A";
                form1 = new Log_In(language,p);
                InitializeComponent();
                timer1.Enabled = true;
                timer1.Interval = 20;

            }
            else
            {
                this.Controls.Clear();
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
                lang_pnl.Visible = false;
                splach_pnl.Visible = true;
                language = "E";
                form1 = new Log_In(language,p);
                InitializeComponent();
                timer1.Enabled = true;
                timer1.Interval = 20;
            }
          
           
        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void splach_pnl_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
