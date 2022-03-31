using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMLibraryFramework
{
    public class Card
    {
        private string cardNumber;
        private string ownerName;
        private int pin;
        private Account linkedAccount;

        public string CardNumber { get { return cardNumber; } }
        public string OwnerName { get { return ownerName; } }
        public int Pin { get { return pin; }  }
        public Account LinkedAccount { get { return linkedAccount; } }

        public Card(string cardnumb, string ownname, int pin, Account account)
        {
            this.cardNumber = cardnumb;
            this.ownerName = ownname;
            this.pin = pin;
            this.linkedAccount = account;
        }
    }
}
