using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class Cim : Form
    { 
        public Cim()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void VezetekNev_TextChanged(object sender, EventArgs e)
        {

        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void RegisterSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                BankDataContext myContext = new BankDataContext();
                myContext.Posts.Add(new Post(
                    usernamming.Text,
                    false,
                    2,
                    0,
                    VezetekNev.Text,
                    KeresztNev.Text,
                    BirthDayPicker.Value,
                    DateTime.Now, passwordField.Text
                        ));
                myContext.SaveChanges();

                MessageBox.Show("Sikkeresen Regisztralt kedves "+KeresztNev.Text);
            }
            catch (Exception ex) {
                MessageBox.Show("Nem sikkerult regisztralni \n HIBA: "+ex.Message);
            }
        }

    }
}
