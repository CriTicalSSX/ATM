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
            if (Program.dataRace)
            {
                Program.dataRace = false;
            }
            else
            {
                Program.dataRace = true;
            }
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

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ATM  written in C# by Chris Macleman and Sam Glendenning. 2018");
        }
    }
}
