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

            BankDataContext myContext = new BankDataContext();
            myContext.Posts.Add(new Post(1, 10000,"Admin","Ferko",DateTime.Now,DateTime.Now));
        }
    }
}
