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
        uint balance;           //unsigned because only ever positive in this case

        //Constructor assigns passed-in values to account number, pin and balance
        public Account(int x, int y, uint z)
        {
            accountNum = x;
            pin = y;
            balance = z;
        }


        //Accessor function, retrieves the account number
        public int getAccNum()
        {
            return accountNum;
        }

        //Accessor function, retrieves the pin number
        public int getPin()
        {
            return pin;
        }




        //Accessor function, retrieves the current balance of the account
        public uint getBalance()
        {
            return balance;
        }

        //Withdraws money from the account based on the parameter.
        //Uses the sleep function to pause the thread while the other ATM instance
        //retrieves the current balance of the account. Then both threads take the 
        //value of x away from the same figure and consequently write the same value
        //to balance
        public bool withdraw(uint x)
        {
            if (balance >= x)
            {
                uint balanceBeforeChange = balance;

                if (Program.dataRace)
                {
                    System.Threading.Thread.Sleep(4000);        //sleep for 4 seconds
                }

                balance = balanceBeforeChange - x;
                return true;
            }              

            return false;
        }
        public void setAccount(int x, int y, uint z)
        {
            accountNum = x;
            pin = y;
            balance = z;
        }
    }

}
