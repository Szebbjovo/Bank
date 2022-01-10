using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    internal class services
    {
    }

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





    class FolyoSzamla {

        private double hitelKeret;

        public FolyoSzamla(double egyenleg,double hitelKeret)
        {
             
        } 
    }
}
