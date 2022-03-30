using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMLibrary
{
    public class Card
    {
        private string cardNumber;
        private string ownerName;
        private int pin;
        private Account linkedAccount;

        public Card(string cardnumb, string ownname, int pin, Account account)
        {
            this.cardNumber = cardnumb;
            this.ownerName = ownname;
            this.pin = pin;
            this.linkedAccount = account;
        }
    }
}
