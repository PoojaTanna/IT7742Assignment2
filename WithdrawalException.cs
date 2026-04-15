using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Bank_App
{
    // Custom exception for withdrawal
    public class WithdrawalException : Exception
    {
        public int AccountId { get; } // Account ID
        public double CurrentBalance { get; } // Current balance
        public double AttemptedAmount { get; } // Amount tried

        // Constructor
        public WithdrawalException(string message, int accountId, double currentBalance, double attemptedAmount)
            : base(message)
        {
            AccountId = accountId;
            CurrentBalance = currentBalance;
            AttemptedAmount = attemptedAmount;
        }
    }
}