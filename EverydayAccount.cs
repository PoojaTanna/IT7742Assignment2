using System;

namespace Assignment3_Bank_App
{
    // Everyday account type
    [Serializable]
    public class EverydayAccount : Account
    {
        // Default constructor
        public EverydayAccount() : base()
        {
            InterestRate = 0; // No interest
            OverdraftLimit = 0; // No overdraft
            FailedFee = 0; // No fee
        }

        // Constructor with values
        public EverydayAccount(int accountID, double initialBalance)
            : base(accountID, initialBalance)
        {
            InterestRate = 0;
            OverdraftLimit = 0;
            FailedFee = 0;
        }

        // Withdraw money
        public override string Withdraw(double amount, bool isStaff)
        {
            if (amount <= 0)
                return "Enter valid amount"; // Invalid input

            if (amount > Balance)
                return "Not enough balance"; // Not enough money

            Balance -= amount; // Deduct amount
            return "Withdraw successful";
        }

        // No interest
        public override string CalculateInterest()
        {
            return "No interest for Everyday Account";
        }
    }
}