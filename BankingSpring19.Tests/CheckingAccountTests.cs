using System;
using Xunit;

namespace BankingSpring19.Tests
{
    public class CheckingAccountTests
    {
        [Fact]
        public void Balance_Starts_At_Zero()
        {
            CheckingAccount account = new CheckingAccount();

            Assert.Equal(0M, account.Balance);
        }

        [Fact]
        public void Deposit_Increases_Balance()
        {
            // Arrange
            CheckingAccount account = new CheckingAccount();

            // Act
            account.Deposit(200M);

            // Assert
            Assert.Equal(200M, account.Balance);
        }
    }
}
