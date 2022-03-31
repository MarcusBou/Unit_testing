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
        [InlineData(-10, 0)]
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

        [Theory]
        [InlineData(1000, 5000, 1000)]
        [InlineData(9999, 10000, 9999)]
        public void WithdrawFromAccount_ShouldBePossible (double amount, double accBalance, double expected)
        {
            // Arrange
            Account account = new Account(accBalance);
            // Act
            double actual = account.WithdrawFromAccount(amount);
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
