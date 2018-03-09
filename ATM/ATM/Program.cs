using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    class Program
    {
        public static bool dataRace = false;
        Account[] accounts = new Account[3];

        void accountSetup()
        {
            accounts[0] = new Account(111111, 1111, 300);
            accounts[1] = new Account(222222, 2222, 750);
            accounts[2] = new Account(333333, 3333, 3000);
        }

        public static void switchDataRace()
        {
            if (dataRace)
            {
                dataRace = false;
            }
            else
            {
                dataRace = true;
            }
        }

        bool isDataRace()
        {
            return dataRace;
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }
    }
}
