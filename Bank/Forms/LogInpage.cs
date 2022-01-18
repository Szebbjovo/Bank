using Bank.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //password recovering
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Minek neked penz ha egy jelszot nem vagy kepes megjegyezni ??!?!", "NEM ERDEKEL!",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Question);
        }

        //registration button
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Cim form2 = new Cim();
                form2.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        
        //Beleptetes, megkeresi a usernev alapjan ,de eloszor megnezi , ha nem vagy admin
        private void signIn_Click(object sender, EventArgs e)
        {
            if (username.Text == "ADMIN" & passwordTB.Text == "ferko")
            {
                AccountsManager_employeOnly admin = new AccountsManager_employeOnly();
                admin.ShowDialog();
            }

            else
            {
                BankDataContext context = new BankDataContext();

                //kiszedjuk a nont ba azt a sort amit fogunk hasznalni (a megadott user nev alapjan keresunk)
                var cont = context.Posts.Where(actual => actual.username == username.Text).FirstOrDefault();//first order azt jelenti ,hogy az elsot azon a neven
                try
                {
                    usernameLoginHelper.usernameHp = cont.username;
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.ToString());
                }


                if (cont != null & cont.password == passwordTB.Text)
                {
                    //not nessesary try catch but u know... it is what it is
                    try
                    {
                        UserDatalabel form3 = new UserDatalabel();
                        form3.ShowDialog();
                        string segitseg = cont.username;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

    }
    //tudom ... tudom . . . Lehetett volna rosszabb is amugy
    static class usernameLoginHelper
    {
        //this help us , to find out the actual user who is logined
        public static string usernameHp;
    }
}
