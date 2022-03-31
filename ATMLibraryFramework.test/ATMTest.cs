using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ATMLibraryFramework;
using Autofac.Extras.Moq;

namespace ATMLibraryFramework.test
{
    public class ATMTest
    {
        [Theory]
        [InlineData(0, 5012, true)]
        [InlineData(1, 5120, true)]
        [InlineData(2, 9802, true)]
        public void CheckPin_ShouldWork(int index, int givenpin, bool expected)
        {
            // Arrange
            ATM atm = new ATM();
            Card card = GetListOfCards()[index];

            // Act
            atm.InsertedCard = card;
            bool actual = atm.CheckPin(givenpin);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, 1, false)]
        [InlineData(1, 4625, false)]
        [InlineData(2, 0, false)]
        public void CheckPin_ShouldntWork(int index, int givenpin, bool expected)
        {
            // Arrange
            ATM atm = new ATM();
            Card card = GetListOfCards()[index];

            // Act
            atm.InsertedCard = card;
            bool actual = atm.CheckPin(givenpin);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ValidateCard_ShouldWork()
        {
            // Arrange
            bool expected = true;
            ATM atm = new ATM();
            atm.InsertedCard = GetListOfCards()[0];

            // Act
            bool actual = atm.ValidateCard();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ValidateCard_ShouldntWork()
        {
            // Arrange
            bool expected = false;
            ATM atm = new ATM();

            // Act
            bool actual = atm.ValidateCard();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1000, "1000 kr.")]
        [InlineData(500, "500 kr.")]
        [InlineData(22, "22 kr.")]
        public void Withdraw_ShouldWithdrawFromAttachedAccount(int amount, string expected)
        {
            // Arrange
            ATM atm = new ATM();
            atm.InsertedCard = GetListOfCards()[0];

            // Act
            string actual = atm.Withdraw(amount);


            // Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(9660, "Not a valid withdrawal amount")]
        [InlineData(5001, "Not a valid withdrawal amount")]
        [InlineData(23314, "Not a valid withdrawal amount")]
        public void Withdraw_ShouldntWithdrawFromAttachedAccount(int amount, string expected)
        {
            // Arrange
            ATM atm = new ATM();
            atm.InsertedCard = GetListOfCards()[0];

            // Act
            string actual = atm.Withdraw(amount);


            // Assert
            Assert.Equal(expected, actual);

        }



        public List<Card> GetListOfCards()
        {
            return new List<Card>
            {
                new Card("1111 2222 3333 4444", "Marcusse", 5012, new Account(5000)),
                new Card("1111 4444 3333 5555", "Kalle", 5120, new Account(5000)),
                new Card("3333 2222 1111 4444", "Nelson", 9802, new Account(5000)),
                new Card("9999 2222 8888 4444", "Danielle", 1166, new Account(5000)),
                new Card("1111 3333 3333 4434", "Evan", 3333, new Account(5000))
            };

        }
    }
}
