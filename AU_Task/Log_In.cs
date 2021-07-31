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
    public partial class Log_In : Form
    {
        string lang = "";
        parent p;
        public Log_In()
        {
            InitializeComponent();
            error_txt.Visible = false;
            add_pnl.Visible = false;
            error_txt2.Visible = false;
        }
        public Log_In(string lang,parent p )
        {
            InitializeComponent();
            this.lang = lang;
            error_txt.Visible = false;
            error_txt2.Visible = false;
            this.p = p;
        }
       hackathonprojectEntities1 db;
        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Log_In_Load(object sender, EventArgs e)
        {
           db = new hackathonprojectEntities1();
            this.Controls.Clear();
            if (lang.Equals("A"))
            {
              Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ar-EG");
                InitializeComponent();
                btn_pnl.Visible = true;
                error_txt.Visible = false;
                error_txt2.Visible = false;
                add_pnl.Visible = false;
                name_txt.text = "رجاء قم بأدخال البريد الالكترونى";
                pass_txt.text = "رجاء قم بأدخال كلمة المرور";
                add_btn.ButtonText = "أضافة";
                id_txt.text = "";
                newName_txt.text = "رجاء قم بأدخال الاسم الاول";
                surname_txt.text = "رجاء قم بأدخال اسم العائلة";
                email_txt.text = "رجاء قم بأدخال البريدالالكترونى";
                newPassword_txt.text = "رجاء قم بأدخال كلمة المرور";
                phone_txt.text = "رجاء قم بأدخال رقم الهاتف";
                street_txt.text = "رجاء قم بأدخال عنوان السكن";
                city_txt.text = "رجاء قم بأدخال أسم المدينة";
                id_txt.text = "رجاء قم بأدخال الرقم القومى";
              
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
                InitializeComponent();
                error_txt2.Visible = false;
                add_pnl.Visible = false;
                error_txt.Visible = false;
                btn_pnl.Visible = false;

            }
            //////////////////////////////////////////////////////////////////////////////////////////
            name_txt.Enter += (sender2, e2) => enterAll(sender2, e2 , name_txt);
            pass_txt.Enter += (sender2, e2) => enterAll(sender2, e2, pass_txt);
            id_txt.Enter += (sender2, e2) => enterAll(sender2, e2, id_txt);
            newName_txt.Enter += (sender2, e2) => enterAll(sender2, e2, newName_txt);
            surname_txt.Enter += (sender2, e2) => enterAll(sender2, e2, surname_txt);
            phone_txt.Enter += (sender2, e2) => enterAll(sender2, e2, phone_txt);
            email_txt.Enter += (sender2, e2) => enterAll(sender2, e2, email_txt);
            newPassword_txt.Enter += (sender2, e2) => enterAll(sender2, e2, newPassword_txt);
            street_txt.Enter += (sender2, e2) => enterAll(sender2, e2, street_txt);
            city_txt.Enter += (sender2, e2) => enterAll(sender2, e2, city_txt);
            //***********************************************************************************
            name_txt.Leave += (sender2, e2) => leaveAll(sender2, e2, name_txt);
            pass_txt.Leave += (sender2, e2) => leaveAll(sender2, e2, pass_txt);
            id_txt.Leave += (sender2, e2) => leaveAll(sender2, e2, id_txt);
            newName_txt.Leave += (sender2, e2) => leaveAll(sender2, e2, newName_txt);
            surname_txt.Leave += (sender2, e2) => leaveAll(sender2, e2, surname_txt);
            phone_txt.Leave += (sender2, e2) => leaveAll(sender2, e2, phone_txt);
            email_txt.Leave += (sender2, e2) => leaveAll(sender2, e2, email_txt);
            newPassword_txt.Leave += (sender2, e2) => leaveAll(sender2, e2, newPassword_txt);
            street_txt.Leave += (sender2, e2) => leaveAll(sender2, e2, street_txt);
            city_txt.Leave += (sender2, e2) => leaveAll(sender2, e2, city_txt);













        }

        private void logE_Click(object sender, EventArgs e)
        {
            //check email and pass
            if (name_txt.text.Equals("") || name_txt.text.Equals("رجاء قم بأدخال البريد الالكترونى") || pass_txt.text.Equals("") || pass_txt.text.Equals("رجاء قم بأدخال كلمة المرور"))
            {
                error_txt.Visible = true;
            }
            else
            {
                //  error_txt.Visible = false;
                //check email and pass
                CH3 child = new CH3("E",p);
                this.Hide();
                child.ShowDialog();
                this.Close();
            }
        }

        private void signE_Click(object sender, EventArgs e)
        {
            animator1.HideSync(log_pnl);
            error_txt2.Visible = false;
            animator2.ShowSync(add_pnl);
        }

        private void log_pnl_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void LogA_Click(object sender, EventArgs e)
        {
            if (name_txt.text.Equals("") || name_txt.text.Equals("رجاء قم بأدخال البريد الالكترونى") || pass_txt.text.Equals("") || pass_txt.text.Equals("رجاء قم بأدخال كلمة المرور"))
            {
                error_txt.Visible = true;
            }
            else
            {
                

                parent c = db.parents.Where(x => x.email.Equals(name_txt.text) && x.password.Equals(pass_txt.text)).FirstOrDefault();
                if (c != null)
                {
                    error_txt.Visible = false;
                    p = c;
                    CH3 child = new CH3("A",p);
                    this.Hide();
                    child.ShowDialog();
                    this.Close();
                }
                else
                {

                    error_txt.Visible = true;
                }
              
                //check email and pass
            }
        }

        private void signA_Click(object sender, EventArgs e)
        {
            animator1.HideSync(log_pnl);
            error_txt2.Visible = false;
            animator2.ShowSync(add_pnl);
        
    }

        private void name_txt_Enter(object sender, EventArgs e)
        {
         //   if (name_txt.text.Equals("Enter Your Email please")|| name_txt.text.Equals("رجاء قم بأدخال البريد الالكترونى"))
           // {
             //   name_txt.text = "";
               // name_txt.ForeColor = Color.DodgerBlue;
            //}

        }
        private void enterAll(object sender, EventArgs e,Bunifu.Framework.UI.BunifuTextbox  text)
        {

            if(lang.Equals("A"))
            {
                if (text == name_txt)
                {
                    if (text.text.Equals("رجاء قم بأدخال البريد الالكترونى"))
                    {


                        name_txt.text = "";
                        name_txt.ForeColor = Color.DodgerBlue;
                    }
                }
                else if (text == pass_txt)
                {
                    if (text.text.Equals("رجاء قم بأدخال كلمة المرور"))
                    {
                        pass_txt.text = "";
                        pass_txt.ForeColor = Color.DodgerBlue;

                    }
                }
                else if (text == id_txt)
                {
                    if (id_txt.text.Equals("رجاء قم بأدخال الرقم القومى"))
                    {
                        id_txt.text = "";
                        id_txt.ForeColor = Color.DodgerBlue;
                    }
                }
                else if (text == newName_txt)
                {
                    if (newName_txt.text.Equals("رجاء قم بأدخال الاسم الاول"))
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
                else if (text == email_txt)
                {
                    if (email_txt.text.Equals("رجاء قم بأدخال البريدالالكترونى"))
                    {
                        email_txt.text = "";
                        email_txt.ForeColor = Color.DodgerBlue;
                    }

                }
                else if(text == newPassword_txt)
                {
                   if(newPassword_txt.text.Equals( "رجاء قم بأدخال كلمة المرور"))
                    {
                        newPassword_txt.text = "";
                        newPassword_txt.ForeColor = Color.DodgerBlue;
                    }
                }
                else if(text==phone_txt)
                {
                    if (phone_txt.text.Equals("رجاء قم بأدخال رقم الهاتف"))
                    {
                        phone_txt.text = "";
                        phone_txt.ForeColor = Color.DodgerBlue;
                    }

                }
                else if (text == city_txt)
                {
                    if (city_txt.text.Equals("رجاء قم بأدخال أسم المدينة"))
                    {
                        city_txt.text = "";
                        city_txt.ForeColor = Color.DodgerBlue;
                    }


                }
                else if (text == street_txt)
                {
                    if( street_txt.text.Equals("رجاء قم بأدخال عنوان السكن"))
                    {
                        street_txt.text = "";
                        street_txt.ForeColor = Color.DodgerBlue;
                    }
                }
            }
            /////////////////////////////////////////////////////////////////////////////////////////
            else
            {

                if (text == name_txt)
                {
                    if (text.text.Equals("Enter Your Email please"))
                    {


                        name_txt.text = "";
                        name_txt.ForeColor = Color.DodgerBlue;
                    }
                }
                else if (text == pass_txt)
                {
                    if (text.text.Equals("Enter Your Password please"))
                    {
                        pass_txt.text = "";
                        pass_txt.ForeColor = Color.DodgerBlue;

                    }
                }
                else if (text == id_txt)
                {
                    if (id_txt.text.Equals("Enter National ID please"))
                    {
                        id_txt.text = "";
                        id_txt.ForeColor = Color.DodgerBlue;
                    }
                }
                else if (text == newName_txt)
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
                else if (text == email_txt)
                {
                    if (email_txt.text.Equals("Enter Your Email please"))
                    {
                        email_txt.text = "";
                        email_txt.ForeColor = Color.DodgerBlue;
                    }

                }
                else if (text == newPassword_txt)
                {
                    if (newPassword_txt.text.Equals("Enter Your Password please"))
                    {
                        newPassword_txt.text = "";
                        newPassword_txt.ForeColor = Color.DodgerBlue;
                    }
                }
                else if (text == phone_txt)
                {
                    if (phone_txt.text.Equals("Enter Your Moblie Number please"))
                    {
                        phone_txt.text = "";
                        phone_txt.ForeColor = Color.DodgerBlue;
                    }

                }
                else if (text == city_txt)
                {
                    if (city_txt.text.Equals("Enter Your City please"))
                    {
                        city_txt.text = "";
                        city_txt.ForeColor = Color.DodgerBlue;
                    }


                }
                else if (text == street_txt)
                {
                    if (street_txt.text.Equals("Enter Your Street please"))
                    {
                        street_txt.text = "";
                        street_txt.ForeColor = Color.DodgerBlue;
                    }
                }

            }









        }
        ///**************************************************************************************
        private void leaveAll(object sender , EventArgs e , Bunifu.Framework.UI.BunifuTextbox text)
        {

            if (lang.Equals("A"))
            {
                if (text == name_txt)
                {
                    if (text.text.Equals(""))
                    {


                        name_txt.text = "رجاء قم بأدخال البريد الالكترونى";

                            name_txt.ForeColor = Color.DimGray;
                    }
                }
                else if (text == pass_txt)
                {
                    if (text.text.Equals(""))
                    {
                        pass_txt.text = "رجاء قم بأدخال كلمة المرور";
                            pass_txt.ForeColor = Color.DimGray;

                    }
                }
                else if (text == id_txt)
                {
                    if (id_txt.text.Equals(""))
                    {
                        id_txt.text = "رجاء قم بأدخال الرقم القومى";

                            id_txt.ForeColor = Color.DimGray;
                    }
                }
                else if (text == newName_txt)
                {
                    if (newName_txt.text.Equals(""))
                    {
                        newName_txt.text = "رجاء قم بأدخال الاسم الاول";

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
                else if (text == email_txt)
                {
                    if (email_txt.text.Equals(""))
                    {
                        email_txt.text = "رجاء قم بأدخال البريدالالكترونى";

                            email_txt.ForeColor = Color.DimGray;
                    }

                }
                else if (text == newPassword_txt)
                {
                    if (newPassword_txt.text.Equals(""))
                    {
                        newPassword_txt.text = "رجاء قم بأدخال كلمة المرور";

                            newPassword_txt.ForeColor = Color.DimGray;
                    }
                }
                else if (text == phone_txt)
                {
                    if (phone_txt.text.Equals(""))
                    {
                        phone_txt.text = "رجاء قم بأدخال رقم الهاتف";
                            phone_txt.ForeColor = Color.DimGray;
                    }

                }
                else if (text == city_txt)
                {
                    if (city_txt.text.Equals(""))
                    {
                        city_txt.text = "رجاء قم بأدخال أسم المدينة";

                            city_txt.ForeColor = Color.DimGray;
                    }


                }
                else if (text == street_txt)
                {
                    if (street_txt.text.Equals(""))
                    {
                        street_txt.text = "رجاء قم بأدخال عنوان السكن";

                            street_txt.ForeColor = Color.DimGray;
                    }
                }
            }
            /////////////////////////////////////////////////////////////////////////////////////////
            else
            {

                if (text == name_txt)
                {
                    if (text.text.Equals(""))
                    {


                        name_txt.text = "Enter Your Email please";

                            name_txt.ForeColor = Color.DimGray;
                    }
                }
                else if (text == pass_txt)
                {
                    if (text.text.Equals(""))
                    {
                        pass_txt.text = "Enter Your Password please";
                        pass_txt.ForeColor = Color.DimGray;

                    }
                }
                else if (text == id_txt)
                {
                    if (id_txt.text.Equals(""))
                    {
                        id_txt.text = "Enter National ID please";
                        id_txt.ForeColor = Color.DimGray;
                    }
                }
                else if (text == newName_txt)
                {
                    if (newName_txt.text.Equals(""))
                    {
                        newName_txt.text = "Enter Your Name please";
                        newName_txt.ForeColor = Color.DimGray;

                    }
                }
                else if (text == surname_txt)
                {

                    if (surname_txt.text.Equals(""))
                    {
                        surname_txt.text = "Enter Your SurName please";
                        surname_txt.ForeColor = Color.DimGray;
                    }

                }
                else if (text == email_txt)
                {
                    if (email_txt.text.Equals(""))
                    {
                        email_txt.text = "Enter Your Email please";
                        email_txt.ForeColor = Color.DimGray;
                    }

                }
                else if (text == newPassword_txt)
                {
                    if (newPassword_txt.text.Equals(""))
                    {
                        newPassword_txt.text = "Enter Your Password please";
                        newPassword_txt.ForeColor = Color.DimGray;
                    }
                }
                else if (text == phone_txt)
                {
                    if (phone_txt.text.Equals(""))
                    {
                        phone_txt.text = "Enter Your Moblie Number please";
                        phone_txt.ForeColor = Color.DimGray;
                    }

                }
                else if (text == city_txt)
                {
                    if (city_txt.text.Equals(""))
                    {
                        city_txt.text = "Enter Your City please";
                        city_txt.ForeColor = Color.DimGray;
                    }


                }
                else if (text == street_txt)
                {
                    if (street_txt.text.Equals(""))
                    {
                        street_txt.text = "Enter Your Street please";
                        street_txt.ForeColor = Color.DimGray;
                    }
                }


                





            }

            }
            private void name_txt_Leave(object sender, EventArgs e)
        {
           // if (name_txt.text.Equals(""))
         //   {
         //       if (lang.Equals("A"))
         //       {
         //           name_txt.text = "رجاء قم بأدخال البريد الالكترونى";
         //           name_txt.ForeColor = Color.DimGray;

         //       }
          //      else
         //       {

         //           name_txt.text = "Enter Your Email please" ;
         //           name_txt.ForeColor = Color.DimGray;
         //       }
           // }
        }

        private void pass_txt_Enter(object sender, EventArgs e)
        {
            //if (pass_txt.text.Equals("Enter Your Password please") || pass_txt.text.Equals("رجاء قم بأدخال كلمة المرور"))
            //{
            //    pass_txt.text = "";
            //    pass_txt.ForeColor = Color.DodgerBlue;
            //}
        }

        private void pass_txt_Leave(object sender, EventArgs e)
        {
            //if (pass_txt.text.Equals(""))
            //{
            //    if (lang.Equals("A"))
            //    {
            //        pass_txt.text = "رجاء قم بأدخال كلمة المرور";
            //        pass_txt.ForeColor = Color.DimGray;

            //    }
            //    else
            //    {

            //        pass_txt.text = "Enter Your Password please";
            //        pass_txt.ForeColor = Color.DimGray;
            //    }
            //}
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (id_txt.text.Equals("رجاء قم بأدخال الرقم القومى")|| id_txt.text.Equals("Enter National ID please") || newName_txt.text.Equals("رجاء قم بأدخال الاسم الاول") || surname_txt.text.Equals("رجاء قم بأدخال اسم العائلة") || email_txt.text.Equals("رجاء قم بأدخال البريدالالكترونى") || newPassword_txt.text.Equals("رجاء قم بأدخال كلمة المرور") || phone_txt.text.Equals("رجاء قم بأدخال رقم الهاتف") || street_txt.text.Equals("رجاء قم بأدخال عنوان السكن") || city_txt.text.Equals("رجاء قم بأدخال أسم المدينة") || newName_txt.text.Equals("Enter Your Name please") || surname_txt.text.Equals("Enter Your SurName please")|| email_txt.text.Equals("Enter Your Email please")||newPassword_txt.text.Equals("Enter Your Password please")||phone_txt.text.Equals("Enter Your Moblie Number please")||street_txt.text.Equals("Enter Your Street please")||city_txt.text.Equals("Enter Your City please"))
            {
                error_txt2.Visible = true;
            }
            else
            {
                //add in sql

                //emails are uniqe 
                //validation about the domain of email and if the email is valid or not 
                // need to reset the text boxes as usual 
                // in form login need x icon to close
                //the slide bar ib child form the animation need to chanage
                //
                try{
                    parent p = new parent();
                    p.nationalID = this.id_txt.text;
                    p.name = this.newName_txt.text;
                    p.surname = this.surname_txt.text;
                    p.street = street_txt.text;
                    p.city = city_txt.text;
                    p.email = email_txt.text;
                    p.phone = phone_txt.text;
                    p.password = newPassword_txt.text;               
                    db.parents.Add(p);
                    db.SaveChanges();
                    animator2.HideSync(add_pnl);
                    error_txt.Visible = false;
                    animator1.ShowSync(log_pnl);
                }
                catch (Exception ex) {

                    if (lang == "a")
                        MessageBox.Show("حدث خطأ في التسجيل حاول مرة اخري ");
                    else
                        MessageBox.Show(ex.ToString());
                    
                }
                

            }
        }

        private void add_pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            animator2.HideSync(add_pnl);
        }
    }
}
