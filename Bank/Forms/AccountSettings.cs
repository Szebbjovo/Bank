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
    public partial class AccountSettings : Form
    {
        public AccountSettings()
        {
            InitializeComponent();
        }

        //ACCOUNT DELETE
        private void button1_Click(object sender, EventArgs e)
        {
            BankDataContext context = new BankDataContext();
            //a helper static classeltudom kivel van dolgom es megkeresem :)))
            var cont = context.Posts.Where(actil => actil.username == usernameLoginHelper.usernameHp).FirstOrDefault();


            //linq-el torlom 
            var posts = from p in context.Posts
                        where p.ID == cont.ID
                        select p;
            foreach (var post in posts) {
                context.Posts.Remove(post);
            }
            context.SaveChanges();
            
        }
    }
}
