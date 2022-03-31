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
            if (amount <= this.amount && amount > 0 && this.amount > 0)
            {
                return true;
            }
            return false;
        }

        public double WithdrawFromAccount(double amount)
        {
            this.amount -= amount;
            return amount;
        }
    }
}
