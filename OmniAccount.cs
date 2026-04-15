using System;

namespace Assignment3_Bank_App
{
    // Omni account type
    [Serializable]
    public class OmniAccount : Account
    {
        // Default constructor
        public OmniAccount() : base()
        {
            InterestRate = 4; // 4% interest
            OverdraftLimit = 100; // Overdraft allowed
            FailedFee = 10; // Fee on failure
        }

        // Constructor with values
        public OmniAccount(int accountID, double initialBalance)
            : base(accountID, initialBalance)
        {
            InterestRate = 4;
            OverdraftLimit = 100;
            FailedFee = 10;
        }

        // Withdraw money
        public override string Withdraw(double amount, bool isStaff)
        {
            if (amount <= 0)
                return "Enter valid amount"; // Invalid input

            if (amount > Balance + OverdraftLimit)
            {
                if (!isStaff)
                {
                    if (Balance >= FailedFee)
                        Balance -= FailedFee; // Deduct fee

                    return "Not enough balance. Fee $" + FailedFee;
                }

                return "Not enough balance"; // Staff no fee
            }

            Balance -= amount; // Deduct amount
            return "Withdraw successful";
        }

        // Calculate interest
        public override string CalculateInterest()
        {
            if (Balance > 1000)
            {
                double interest = (Balance - 1000) * (InterestRate / 100); // Interest on extra amount
                Balance += interest; // Add interest
                return "Interest added $" + interest + " New Balance $" + Balance;
            }

            return "No interest added as balance is below $1000.";
        }
    }
}