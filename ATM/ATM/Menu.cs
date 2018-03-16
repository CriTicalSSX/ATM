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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }

        //Checkbox used to toggle the data race scenario
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

        //Creates a new thread that has an instance of an ATM object passed to it
        private void newATM_Click(object sender, EventArgs e)
        {
            Thread newATM_t = new Thread(createATM);
            newATM_t.Start();
        }

        //Creates a new instance of an ATM
        private void createATM()
        {
            Application.Run(new ATM());            
        }

        //Part of the toolstrip, when pressed closes the application
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Part of the toolstrip, when pressed gives information about the program and its authors
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ATM  written in C# by Chris Macleman and Sam Glendenning. 2018");
        }

        //Closes the entire program when the user presses the 'X' button on the menu form
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
