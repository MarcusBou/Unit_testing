using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ATMLibraryFramework.test
{
    public class AccountTest
    {
        [Fact]
        public void CheckIfWithdrawable_ShouldWorkWithAmountInsideBalanceBarrier()
        {
            // Arrange
            bool expected = true;
            double amount = 100;
            Account account = new Account(5000);
            // Act
            bool actual = account.CheckIfWithdrawable(amount);
            // Assert
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData(double.MaxValue, double.MinValue)]
        [InlineData(1000, 500)]
        [InlineData(0, -10)]
        public void CheckIfWithdrawable_ShouldntWorkWithAmountOutsideBalanceBarrier(double amount, double accBalance)
        {
            // Arrange
            bool expected = false;
            Account account = new Account(accBalance);
            // Act
            bool actual = account.CheckIfWithdrawable(amount);
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
