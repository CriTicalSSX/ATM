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
        int accountsIndex;
        Button[,] btn = new Button[3, 3];
        Panel pinPanel = new Panel();
        string state = "account";

        public ATM()
        {
            InitializeComponent();
            setup();          
        }

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
                bottomRightLabel.Text = "Quit";
                uint balance = Program.accounts[accountsIndex].getBalance();
                subLabel.Text = "Balance: £" + Convert.ToString(balance);
            }
            else if (x == "withdraw")
            {
                subLabel.Text = "Withdraw:";
                topLeftLabel.Text = "£5";
                bottomLeftLabel.Text = "£20";
                topRightLabel.Text = "£10";
                bottomRightLabel.Text = "Quit";
            }

            state = x;
            lblEnter.Text = "";
        }

        void setup()
        {
            Graphics g = this.CreateGraphics();
            Pen selPen = new Pen(Color.MediumBlue);
            g.DrawRectangle(selPen, 10, 10, 50, 50);
            g.Dispose();

           // keypad = new Button[] { button0, button1, button2, button3, button4, button5, button6, button7, button8, button9, enter, clear, cancel };
        }

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

        public void keypadVisible(bool x)
        {
            /* for (int i = 0; i < 13; i++)
             {
                 keypad[i].Visible = x;
             }*/

            pinPanel.Visible=x;
            button0.Visible=x;
            enter.Visible = x;
            cancel.Visible = x;
            clear.Visible=x;

        }

        //logic for checking the account against stored account numbers 
        public void accountCheck()
        {
            int input = Convert.ToInt32(lblEnter.Text);

            for (int i=0; i<3; i++)
            {
                if (Program.accounts[i].getAccNum() == input)
                {
                    accountsIndex = i;
                    switchState("pin");
                    return;
                }
            }
        }

        public void pinNumberCheck()
        {
            int input = Convert.ToInt32(lblEnter.Text);

            for (int i = 0; i < 3; i++)
            {
                if (Program.accounts[i].getPin() == input)
                {
                    switchState("options");
                    return;
                }
            }
        }

        private void test_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Hiding...");
            keypadVisible(false);
            MessageBox.Show("Showing...");
            keypadVisible(true);
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ATM_Load(object sender, EventArgs e)
        {
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
                     
                    btn[x, y].Font = new Font("Microsoft Sans Serif", 20.25f );
                    pinPanel.Controls.Add(btn[x, y]);

                    
                }

                

            }

        }
        void pinEvent_Click(object sender, EventArgs e)
        {           
            if (lblEnter.Text.Length < 6)
            {
                string number = (sender as Button).Text;
                lblEnter.Text += (number);
            }     
        }

        private void enter_Click(object sender, EventArgs e)
        {
            if (state == "account")
            {
                accountCheck();
            }
            else if (state == "pin")
            {
                pinNumberCheck();
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            lblEnter.Text = ("");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (lblEnter.Text.Length < 6)
            {
                lblEnter.Text += (sender as Button).Text;
            }
        }

        private void topLeft_Click(object sender, EventArgs e)
        {
            if (state == "options")
            {
                switchState("withdraw");
            }
            else if (state == "withdraw")
            {
                //£10 or whatever
            }
        }

        private void bottomLeft_Click(object sender, EventArgs e)
        {
            if (state == "options")
            {
                switchState("balance");
            }
            else if (state == "withdraw")
            {
                //£20 or whatever
            }
        }

        private void botomRight_Click(object sender, EventArgs e)
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
    }



}

