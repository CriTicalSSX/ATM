using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Account
    {
        int accNum, pin;
        uint balance;

        public Account(int x, int y, uint z)
        {
            accNum = x;
            pin = y;
            balance = z;
        }

        public int getAccNum()
        {
            return accNum;
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
                balance -= x;
                return true;
            }

            return false;
        }
    }
}
