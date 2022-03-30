using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ATMLibraryFramework;

namespace ATMLibraryFramework.test
{
    public class ATMTest
    {
        [Theory]
        [InlineData("1111222233334444", "Balletdanseren", 1094, 1094, true)]
        [InlineData("1111555522224444", "Kalle", 1243, 1243, true)]
        [InlineData("1111222233334444", "Christan", 1111, 1111, true)]
        public void CheckPin_ShouldWork(string cardnumber, string cardHolder, int actualpin, int givenpin, bool expected)
        {
            // Arrange
            Card card = new Card(cardnumber, cardHolder, actualpin, new Account(5000));

            // Act
            bool actual = ATM.CheckPin(givenpin);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckPin_ShouldntWork()
        {
            // Arrange

            // Act

            // Assert

        }

    }
}
