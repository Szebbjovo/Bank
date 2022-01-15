using Bank.services_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank.Forms
{
    public partial class UserDatalabel : Form
    {
        public UserDatalabel()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


 
    private void ShowData_Click(object sender, EventArgs e)
          {
                BankDataContext context = new BankDataContext();
            //ennel mokolosabban nem lehet megoldani lol
            var cont4 = context.Posts.Where(actil => actil.username == usernameLoginHelper.usernameHp).FirstOrDefault();



               UserDatakerlekmenj.Text = cont4.ToString();
            }


        private void AddMonnnny_Click(object sender, EventArgs e)
        {
            //a betetel szamlalo es confirm gomb elrejtese es mutatasa
            monniadas.Visible = true;
            confirmAddation.Visible = true;

            BankDataContext context = new BankDataContext();
            //ennel mokolosabban nem lehet megoldani lol
            var cont1 = context.Posts.Where(actil => actil.username == usernameLoginHelper.usernameHp).FirstOrDefault();

            try
            {
                _ = cont1.egyenleg + (double)monniadas.Value;//HEEEEELP
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message);
            }
        }

        private void MonneytakeOut_Click(object sender, EventArgs e)
        {
            //a kivetel szamlalo es confirm gomb elrejtese es mutatasa
            monnikivetel.Visible = true;
            takeaOutconfirm.Visible = true;


            BankDataContext context = new BankDataContext();
            //ennel mokolosabban nem lehet megoldani lol
            var cont1 = context.Posts.Where(actil => actil.username == usernameLoginHelper.usernameHp).FirstOrDefault();

            try
            {
                _ = cont1.egyenleg - (double)monniadas.Value;//HEEEEEEEEELP
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



            //kene kicsi biztonsag ide, egy bool al 
        }
    }

    public static class userselect { 
        //public static var helperToSelectUser;
    }

}
