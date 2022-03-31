using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMLibraryFramework
{
    public class ATM
    {
        private Card insertedCard;
        public Card InsertedCard { get { return insertedCard; }  set { insertedCard = value; } }

        /// <summary>
        /// Checks pincode for card
        /// </summary>
        /// <param name="sentPin"></param>
        /// <returns></returns>
        public bool CheckPin(int sentPin)
        {
            if (insertedCard.Pin.Equals(sentPin))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Validate Card for correct info
        /// </summary>
        /// <returns></returns>
        public bool ValidateCard()
        {
            if (insertedCard != null)
            {
                if (!insertedCard.OwnerName.Equals(null)
                    && !insertedCard.CardNumber.Equals(null)
                    && !insertedCard.LinkedAccount.Equals(null))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public string Withdraw(double amount)
        {
            if (InsertedCard.LinkedAccount.CheckIfWithdrawable(amount))
            {
                return $"{amount} kr.";
            }
            return $"Not a valid withdrawal amount";
        }
    }
}
