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
    public partial class ATM : Form
    {
        int accountsIndex;      //stores the account number currently being interacted with
        Button[,] btn = new Button[3, 3];       //array of buttons represents the keypad, apart from the zero button
        Panel pinPanel = new Panel();           //groups the buttons into a controllable section
        string state = "account";               //holds the current state of the ATM

        public ATM()
        {
            InitializeComponent();
            setup();          
        }

        //Changes the state of the ATM, which controls what text is displayed on screen and what each button does
        void switchState(string x)
        {
            if (x == "account")
            {
                subLabel.Text = "Please enter your account number.";
            }
            else if (x == "pin")
            {
                subLabel.Text = "Please enter your pin number.";
            }
            else if (x == "options")
            {
                lblEnter.Visible = false;
                subLabel.Text = "Choose an option.";
                topLeftLabel.Text = "Withdraw";
                bottomLeftLabel.Text = "Balance";
                topRightLabel.Text = "";
                bottomRightLabel.Text = "Quit";
            }
            else if (x == "balance")
            {
                topLeftLabel.Text = "";
                bottomLeftLabel.Text = "";
                topRightLabel.Text = "";
                bottomRightLabel.Text = "Back";
                uint balance = Program.ac[accountsIndex].getBalance();
                subLabel.Text = "Balance: £" + Convert.ToString(balance);
            }
            else if (x == "withdraw")
            {
                subLabel.Text = "Withdraw:";
                topLeftLabel.Text = "£5";
                bottomLeftLabel.Text = "£20";
                topRightLabel.Text = "£10";
                bottomRightLabel.Text = "Back";
            }

            state = x;
            lblEnter.Text = "";
        }

        //Sets up the ATM with the layout it needs when first loaded up
        void setup()
        {
            Graphics g = this.CreateGraphics();
            Pen selPen = new Pen(Color.MediumBlue);
            g.DrawRectangle(selPen, 10, 10, 50, 50);
            g.Dispose();

            pinPanel.SetBounds(80, 200, 280, 274);
            pinPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            Controls.Add(pinPanel);
            int counter = 0;
            // Loops x amount of times until x is equal to the length in the array
            for (int y = 0; y < btn.GetLength(0); y++)
            {
                // Loops x amount of times until y is equal to the length in the array
                for (int x = 0; x < btn.GetLength(1); x++)     // Loop for y
                {
                    //Creates a new button
                    btn[x, y] = new Button();

                    //Sets the position and size of each button
                    btn[x, y].SetBounds(65 * x, 65 * y, 75, 75);

                    //Creates an event handler. This will be used later in the program for events for each button.
                    btn[x, y].Click += new EventHandler(pinEvent_Click);
                    counter++;
                    btn[x, y].Text = Convert.ToString(counter);

                    btn[x, y].Font = new Font("Microsoft Sans Serif", 20.25f);
                    pinPanel.Controls.Add(btn[x, y]);
                }
            }
        }

        //Used to display the screen to the user
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            using (Pen selPen = new Pen(Color.MediumBlue))
            {
                g.DrawRectangle(selPen, 65, 10, 300, 180);
            }

            SolidBrush solidBrush = new SolidBrush(Color.MediumBlue);
            g.FillRectangle(solidBrush, 65, 10, 300, 180);
        }

        //Toggles the visibility of the keypad. When off, only the screen is shown
        public void keypadVisible(bool x)
        {
            pinPanel.Visible=x;
            button0.Visible=x;
            enter.Visible = x;
            cancel.Visible = x;
            clear.Visible=x;

        }

        //Code for checking the account against stored account numbers. When the user's
        //input matches an account number, the function returns true
        public bool accountCheck()
        {
            int input = Convert.ToInt32(lblEnter.Text);

            for (int i=0; i<3; i++)
            {
                if (Program.ac[i].getAccNum() == input)
                {
                    accountsIndex = i;
                    return true;
                }
            }

            return false;
        }

        public bool pinNumberCheck()
        {
            int input = Convert.ToInt32(lblEnter.Text);

            for (int i = 0; i < 3; i++)
            {
                if (Program.ac[i].getPin() == input)
                {
                    return true;
                }
            }

            return false;
        }

        //If cancel button clicked at any time, ATM exits
        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        //The event handler for keys 1-9. Button 0 has the exact same code. Keys are
        //only active in account state or pin state
        void pinEvent_Click(object sender, EventArgs e)
        {
            if (state == "account")
            {
                if (lblEnter.Text.Length < 6)       //account number can't have more than 6 digits
                {
                    lblEnter.Text += (sender as Button).Text;
                }
            }
            else if (state == "pin")
            {
                if (lblEnter.Text.Length < 4)       //pin number can't have more than 4 digits
                {
                    lblEnter.Text += (sender as Button).Text;
                }
            }
        }

        //If enter button pressed, state either advances from account number entry to
        //pin number entry or from pin number entry to options screen
        private void enter_Click(object sender, EventArgs e)
        {
            if (state == "account")
            {
                if (!accountCheck())
                {
                    subLabel.Text = "This account number could not be found";
                }
                else
                {
                    switchState("pin");
                }
            }
            else if (state == "pin")
            {
                if (!pinNumberCheck())
                {
                    subLabel.Text = "Incorrect PIN";
                }
                else
                {
                    switchState("options");
                }
            }
        }

        //Whenever the clear button is pressed, program quits
        private void clear_Click(object sender, EventArgs e)
        {
            lblEnter.Text = ("");
        }

        //Same code as all other numbered keys
        private void button0_Click(object sender, EventArgs e)
        {
            if (state == "account")
            {
                if (lblEnter.Text.Length < 6)
                {
                    lblEnter.Text += (sender as Button).Text;
                }
            }
            else if (state == "pin")
            {
                if (lblEnter.Text.Length < 4)
                {
                    lblEnter.Text += (sender as Button).Text;
                }
            }
        }

        //Only active during options, balance or withdraw state
        //Represents option to either withdraw and then, in that state, withdraw £5
        private void topLeft_Click(object sender, EventArgs e)
        {
            if (state == "options")
            {
                switchState("withdraw");
            }
            else if (state == "withdraw")
            {
                if (Program.dataRace)
                {
                    subLabel.Text = "Withdrawing...";
                }

                if (!Program.ac[accountsIndex].withdraw(5))
                {
                    subLabel.Text = "Error. Insufficient funds.";
                }

                switchState("options");
            }
        }

        //Only active during options, balance or withdraw state
        //Represents option to either check balance or withdraw £20
        private void bottomLeft_Click(object sender, EventArgs e)
        {
            if (state == "options")
            {
                switchState("balance");
            }
            else if (state == "withdraw")
            {
                if (Program.dataRace)
                {
                    subLabel.Text = "Withdrawing...";
                }

                if (!Program.ac[accountsIndex].withdraw(20))
                {
                    subLabel.Text = "Error. Insufficient funds.";
                }

                switchState("options");
            }
        }

        //Only active during options, balance or withdraw state
        //Allows the user to go back to previous screen or quit
        private void bottomRight_Click(object sender, EventArgs e)
        {
            if (state == "options")
            {
                Close();
            }
            else if (state == "withdraw" || state == "balance")
            {
                switchState("options");
            }
        }

        //Only active during options, balance or withdraw state
        //Allows user to withdraw £10 in withdraw state
        private void topRight_Click(object sender, EventArgs e)
        {
            if (state == "withdraw")
            {
                if (Program.dataRace)
                {
                    subLabel.Text = "Withdrawing...";
                }

                if (!Program.ac[accountsIndex].withdraw(10))
                {
                    subLabel.Text = "Error. Insufficient funds.";
                }

                switchState("options");
            }
        }
    }
}