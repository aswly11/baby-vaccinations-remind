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
    public partial class Doc : Form
    {
        string language;
        parent p;
        public Doc()
        {
            InitializeComponent();
        }
        public Doc(string lang,parent p )
        {
            InitializeComponent();
            language = lang;
            this.p = p;
         
        }

        private void Doc_Load(object sender, EventArgs e)
        {
            this.Controls.Clear();
            if (language.Equals("A"))
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ar-EG");

            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");

            }
            InitializeComponent();
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {

            CH3 h3 = new CH3(language,p);
            this.Hide();
            h3.ShowDialog();
            this.Close();

            
        }
    }
}
