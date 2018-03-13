using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    class Program
    {
        public static Account[] ac = new Account[3];
        public static bool dataRace = false;

        static void setupAccounts()
        {
            ac[0] = new Account(111111, 1111, 300);
            ac[1] = new Account(222222, 2222, 750);
            ac[2] = new Account(333333, 3333, 3000);
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            setupAccounts();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }
    }
}
