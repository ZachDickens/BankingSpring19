using System;
using System.Collections.Generic;
using System.Text;

namespace BankingSpring19
{
    public class CheckingAccount
    {
        public decimal Balance { get; set; }

        public void Deposit(decimal amount)
        {
            Balance = Balance + amount;
        }
    }
}
