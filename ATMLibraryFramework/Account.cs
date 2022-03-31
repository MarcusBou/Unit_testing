using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMLibraryFramework
{
    public class Account
    {
        private double amount;
        public Account(double amount)
        {
            this.amount = amount;  
        }

        public bool CheckIfWithdrawable(double amount)
        {
            if (amount <= this.amount)
            {
                return true;
            }
            return false;
        }
    }
}
