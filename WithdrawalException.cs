using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_App2
{
    // Custom exception for failed withdrawals
    public class WithdrawalException : Exception
    {
        public int AccountId { get; }
        public double CurrentBalance { get; }
        public double AttemptedAmount { get; }

        public WithdrawalException(string message, int accountId, double currentBalance, double attemptedAmount)
            : base(message)
        {
            AccountId = accountId;
            CurrentBalance = currentBalance;
            AttemptedAmount = attemptedAmount;
        }
    }
}
