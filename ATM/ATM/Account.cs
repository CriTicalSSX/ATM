using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class Account
    {
        int accountNum, pin;
        uint balance;

        public Account(int x, int y, uint z)
        {
            accountNum = x;
            pin = y;
            balance = z;
        }

        public int getAccNum()
        {
            return accountNum;
        }

        public int getPin()
        {
            return pin;
        }

        public uint getBalance()
        {
            return balance;
        }

        public bool withdraw(uint x)
        {
            if (balance >= x)
            {
                uint balanceBeforeChange = balance;

                if (Program.dataRace)
                {
                    System.Threading.Thread.Sleep(4000);
                }

                balance = balanceBeforeChange - x;
                return true;
            }              

            return false;
        }
    }
}
