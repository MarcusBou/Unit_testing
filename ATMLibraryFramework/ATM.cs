using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMLibraryFramework
{
    public static class ATM
    {
        static Card insertedCard;


        public static bool CheckPin(int sentPin)
        {
            if (insertedCard.Equals(sentPin))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
