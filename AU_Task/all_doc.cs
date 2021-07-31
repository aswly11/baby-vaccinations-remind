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
    public partial class all_doc : UserControl
    {
        string language;
        string idD= "";
         string nameD = "";
        string emailD = "";
        string hoursD = "";
        string daysD = "";
        public all_doc()
        {
            InitializeComponent();
        }
        public all_doc(string id , string name, string email,string hours , string days , string lang)
        {
            InitializeComponent();
            idD = id;
            nameD = name;
            emailD = email;
            hoursD = hours;
            daysD = days;
            language = lang;

        }
        private void all_doc_Load(object sender, EventArgs e)
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
            id.Text = idD;
            name.Text = nameD;
            email.Text = emailD;
            hours.Text = hoursD;
            days.Text = daysD;
        }
    }
}
