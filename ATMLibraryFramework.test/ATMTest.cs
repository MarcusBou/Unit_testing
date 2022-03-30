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
        [InlineData(5012, true)]
        public void CheckPin_ShouldWork(int givenpin, bool expected)
        {
            // Arrange
            using (var mock = AutoMock.GetLoose())
            {
                mock.Mock<Card>().Setup();
            }
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
