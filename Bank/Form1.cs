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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            var result = MessageBox.Show("Minek neked penz ha egy jelszot nem vagy kepes megjegyezni ??!?!", "NEM ERDEKEL!",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Question);
        }
    }
}
