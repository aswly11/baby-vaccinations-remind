using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace AU_Task
{
    public partial class all_child : UserControl
    {
        string lang , ID , NameC , SurnameC, BD;
        public all_child()
        {
            InitializeComponent();
        }
        public all_child(string idC , string nameC , string surnameC , string bC , string language)
        {
            InitializeComponent();
            lang = language;
            NameC = nameC;
            ID = idC;
            SurnameC = surnameC;
            BD = bC;
           
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void all_child_Load(object sender, EventArgs e)
        {
            this.Controls.Clear();
            if (lang.Equals("A"))
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ar-EG");

            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");

            }
            InitializeComponent();
            id.Text = ID;
            name.Text = NameC;
            surname.Text = SurnameC;
            birthdate.Text = BD;
        }

        private void name_Click(object sender, EventArgs e)
        {

        }
    }
}
