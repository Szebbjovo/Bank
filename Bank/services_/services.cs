using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//connection string: Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;

namespace Bank
{
    public class Post
    {
        public Post() { }
        public Post(string usernm, bool emploj, int idm, double egyenleg, string knev, string vnev, DateTime now1, DateTime now2, string paswrd)
        {
            this.ID = idm;

            this.employe = emploj;

            this.egyenleg = egyenleg;
            this.kNev = knev;
            this.kNev = vnev;
            this.szuletes = now1;
            this.regisztracioDatuma = now2;
            this.username = usernm;//vnev + "-" + knev;
            this.password = paswrd;
        }

        public int ID { get; set; }
        public double egyenleg { get; set; }

        public bool employe { get; set; }
        public string kNev { get; set; }
        public string vNev { get; set; }
        public DateTime szuletes { get; set; }
        public DateTime regisztracioDatuma { get; set; }

        public string username { get; set; }
        public string password { get; set; }

        //custom tostrint ,hogy sorban, nev szerint irjon cuccokat 
        public override string ToString()
        {
            return "ID:" + ID + "\nEgyenleg: " + egyenleg + "\nKeresztnev:" + kNev + "\nVezeteknev: " + vNev + "\nSzuletesi datum:\n" + szuletes + "\nUgyfelunk a kovetkezo datum ota\n" + regisztracioDatuma + "\nFelhasznalovene: " + username + "jelszava: " + password;
        }

    }

    public class BankDataContext : DbContext { 
        public DbSet<Post> Posts { get; set; }
    }
    



    // Kovetkezo funkciok //for upgrading
  /*
    public class Bankszamla {

        protected double egyenleg;

        public string kNev;
        public string vNev;
        public DateTime szuletes;
        public DateTime regisztracioDatuma;

        protected Bankszamla(double osszeg, string vn, string kn, DateTime szul) {

            this.egyenleg = osszeg;
            this.vNev = vn;
            this.kNev = kn;
            //amikor meghivodik akkor fut le , ergo erted
            this.regisztracioDatuma = DateTime.Now;
            this.szuletes = szul;
        }

        public void Betesz(double osszegestol) {
            this.egyenleg = (double)osszegestol;
        }

        public bool Kivesz(double osszeg)
        { 
            if (this.egyenleg < osszeg)
            {
                return false;
            }
            else if (this.egyenleg == osszeg)
            {
                //figyelmeztetem a felhsznalot,hogy az osszes penzet kiveszi
                const string message = "A felvett penzosszeg megegyezik a teljes szamlaja osszegevel!!";
                const string caption = "FIGYELEM!";
                var result = MessageBox.Show(message, caption,
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Question);
                return true;
            }
            else {
                return true;
            }
        }


        public double getEgyenleg() { 
            return this.egyenleg;
        }



    }
  */

    
}
