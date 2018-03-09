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
        Button[] keypad;

        public ATM()
        {
            InitializeComponent();
            setup();
        }

        void setup()
        {
            Graphics g = this.CreateGraphics();
            Pen selPen = new Pen(Color.MediumBlue);
            g.DrawRectangle(selPen, 10, 10, 50, 50);
            g.Dispose();

            keypad = new Button[] { button0, button1, button2, button3, button4, button5, button6, button7, button8, button9, enter, clear, cancel };
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
            for (int i=0; i<13; i++)
            {
                keypad[i].Visible = x;
            }
        }

        private void test_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Hiding...");
            keypadVisible(false);
            MessageBox.Show("Showing...");
            keypadVisible(true);
        }
    }
}
