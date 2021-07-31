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
    public partial class CH3 : Form
    {
        string language="";
        private parent p;

        public CH3()
        {
            InitializeComponent();
        }
        public CH3(string language, parent p)
        {
            InitializeComponent();
            this.language = language;
            this.p = p;
        }

      

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CH3_Load(object sender, EventArgs e)
        {
            this.Controls.Clear();
            if (language.Equals("A"))
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ar-EG");
                InitializeComponent();
              
              
              
                add_pnl.Visible = false;
                show_pnl.Visible = false;
                error_txt2.Visible = false;
                newName_txt.text = "رجاء قم بأدخال الاسم";
                surname_txt.text = "رجاء قم بأدخال اسم العائلة";
                add_btn.ButtonText = "أضافة";
                show_btn.Text = "    عرض كل الاطفال   ";
                addC_btn.Text = "   أضافة طفل   ";
                back_btn.Text = "   الرجوع   ";
                showD_btn.Text = "  عرض كل الاطباء   ";

            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
                InitializeComponent();
               
                add_pnl.Visible = false;
                show_pnl.Visible = false;
                error_txt2.Visible = false;

            }
            //////////////////////////////////////////////////////////////////////////////////////
            newName_txt.Enter += (sender2, e2) => enterAll(sender2, e2, newName_txt);
            surname_txt.Enter += (sender2, e2) => enterAll(sender2, e2, surname_txt);
           newName_txt.Leave += (sender2, e2) => leaveAll(sender2, e2, newName_txt);
            surname_txt.Leave += (sender2, e2) => leaveAll(sender2, e2, surname_txt);
        }
        private void enterAll(object sender , EventArgs e , Bunifu.Framework.UI.BunifuTextbox text)
        {
            if (language.Equals("A"))
            {
                if(text == newName_txt)
                {
                    if (newName_txt.text.Equals("رجاء قم بأدخال الاسم") )
                    {

                        newName_txt.text = "";
                       newName_txt.ForeColor = Color.DodgerBlue;
                    }

                }
                else if (text == surname_txt)
                {
                    if (surname_txt.text.Equals("رجاء قم بأدخال اسم العائلة"))
                    {
                        surname_txt.text = "";
                        surname_txt.ForeColor = Color.DodgerBlue;
                    }

                }
            }
            else
            {
                if (text == newName_txt)
                {
                    if (newName_txt.text.Equals("Enter Your Name please"))
                    {

                        newName_txt.text = "";
                        newName_txt.ForeColor = Color.DodgerBlue;
                    }

                }
                else if (text == surname_txt)
                {
                    if (surname_txt.text.Equals("Enter Your SurName please"))
                    {
                        surname_txt.text = "";
                        surname_txt.ForeColor = Color.DodgerBlue;
                    }

                }
            }
        }

        private void leaveAll(object sender, EventArgs e, Bunifu.Framework.UI.BunifuTextbox text)
        {
            if (language.Equals("A"))
            {
                if (text == newName_txt)
                {
                    if (newName_txt.text.Equals(""))
                    {

                        newName_txt.text = "رجاء قم بأدخال الاسم";

                            newName_txt.ForeColor = Color.DimGray;
                    }

                }
                else if (text == surname_txt)
                {
                    if (surname_txt.text.Equals(""))
                    {
                        surname_txt.text = "رجاء قم بأدخال اسم العائلة";

                            surname_txt.ForeColor = Color.DimGray;
                    }

                }
            }
            else
            {
                if (text == newName_txt)
                {
                    if (newName_txt.text.Equals(""))
                    {

                        newName_txt.text = "Enter Your Name please";
                        newName_txt.ForeColor = Color.DodgerBlue;
                    }

                }
                else if (text == surname_txt)
                {
                    if (surname_txt.text.Equals(""))
                    {
                        surname_txt.text = "Enter Your SurName please";
                        surname_txt.ForeColor = Color.DodgerBlue;
                    }

                }
            }
        }




        private void menu_btn_Click(object sender, EventArgs e)
        {
            if (panel6.Width == 72)
            {
                panel6.Visible = false;
                panel6.Width = 288;
                panel.ShowSync(panel6);
                logo.ShowSync(Pic);

            }
            else
            {
                logo.Hide(Pic);
                panel6.Visible = false;
                panel6.Width = 72;
                panel.ShowSync(panel6);
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Log_In log_In = new Log_In(language,p);
            this.Hide();
            log_In.ShowDialog();
            this.Close();
        }

        private void add_pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void show_btn_Click(object sender, EventArgs e)
        {
            show_pnl.Visible = true;
        }

        private void addC_btn_Click(object sender, EventArgs e)
        {
            show_pnl.Visible = false;
            add_pnl.Visible = true;
            error_txt2.Visible = false;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (language.Equals("A"))
            {
                if (newName_txt.text.Equals("رجاء قم بأدخال الاسم")||surname_txt.text.Equals( "رجاء قم بأدخال اسم العائلة"))
                {
                    error_txt2.Visible = true;
                }
                else
                {
                    error_txt2.Visible = false;
                    logo.HideSync(add_pnl);
                }
            }
            else
            {
              if (newName_txt.text.Equals("Enter Your Name please")||surname_txt.text.Equals("Enter Your SurName please"))
                {
                    error_txt2.Visible = true;

                }
                else
                {
                    error_txt2.Visible = false;
                    logo.HideSync(add_pnl);
                }

            }
        }

        private void showD_btn_Click(object sender, EventArgs e)
        {
            Doc all_Doc = new Doc(language,p);
            this.Hide();
            all_Doc.ShowDialog();
            this.Close();

        }

        private void show_pnl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
