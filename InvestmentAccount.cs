using System;

namespace Assignment3_Bank_App
{
    // Investment account type
    [Serializable]
    public class InvestmentAccount : Account
    {
        // Default constructor
        public InvestmentAccount() : base()
        {
            InterestRate = 5; // 5% interest
            OverdraftLimit = 0; // No overdraft
            FailedFee = 10; // Fee on failure
        }

        // Constructor with values
        public InvestmentAccount(int accountID, double initialBalance)
            : base(accountID, initialBalance)
        {
            InterestRate = 5;
            OverdraftLimit = 0;
            FailedFee = 10;
        }

        // Withdraw money
        public override string Withdraw(double amount, bool isStaff)
        {
            if (amount <= 0)
                return "Enter valid amount"; // Invalid input

            if (amount > Balance)
            {
                if (!isStaff)
                {
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
            double interest = Balance * (InterestRate / 100); // Calculate
            Balance += interest; // Add interest
            return "Interest added $" + interest + " New Balance $" + Balance;
        }
    }
}