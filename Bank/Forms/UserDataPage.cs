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
               var cont = context.Posts.Where(actil  => actil.username == segitseg);

               UserDatakerlekmenj.Text = cont;
            }
        }
}
