using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ATM
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void raceConditionChange_CheckedChanged(object sender, EventArgs e)
        {
            Program.switchDataRace();
        }

        private void newATM_Click(object sender, EventArgs e)
        {
            Thread newATM_t = new Thread(createATM);
            newATM_t.Start();
        }

        private void createATM()
        {
            Application.Run(new ATM());
        }
    }
}
