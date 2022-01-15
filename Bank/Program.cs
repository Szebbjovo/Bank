using Bank.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());





            //Application.Run(new UserDatalabel());

            //BankDataContext myContext = new BankDataContext();
            //myContext.Posts.Add(new Post(3, 3000.00,"kacsa","ur",DateTime.Now,DateTime.Now,"sziauram"));
            //myContext.SaveChanges();
        }
    }
}
