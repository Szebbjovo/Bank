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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //password recovering
        private void button3_Click(object sender, EventArgs e)
        {

            var result = MessageBox.Show("Minek neked penz ha egy jelszot nem vagy kepes megjegyezni ??!?!", "NEM ERDEKEL!",
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

        private void signIn_Click(object sender, EventArgs e)
        {

            BankDataContext context = new BankDataContext();


                var cont = context.Posts.Where(actual => actual.username == username.Text).FirstOrDefault();



            if (cont != null & cont.password == passwordTB.Text)
            {
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
