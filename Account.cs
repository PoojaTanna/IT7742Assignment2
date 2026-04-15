using System;
using System.Xml.Serialization;

namespace Assignment3_Bank_App
{
    // Base account class
    [Serializable]
    [XmlInclude(typeof(EverydayAccount))]
    [XmlInclude(typeof(InvestmentAccount))]
    [XmlInclude(typeof(OmniAccount))]
    public abstract class Account
    {
        public int AccountID { get; set; } // ID
        public double Balance { get; set; } // Balance
        public double InterestRate { get; set; } // Interest %
        public double OverdraftLimit { get; set; } // Overdraft
        public double FailedFee { get; set; } // Fee

        // Default constructor
        protected Account()
        {
        }

        // Constructor with values
        protected Account(int accountID, double balance, double interestRate = 0, double overdraftLimit = 0, double failedFee = 0)
        {
            AccountID = accountID;
            Balance = balance;
            InterestRate = interestRate;
            OverdraftLimit = overdraftLimit;
            FailedFee = failedFee;
        }

        // Add money
        public virtual void Deposit(double amount)
        {
            Balance += amount; // Increase balance
        }

        // Withdraw money
        public abstract string Withdraw(double amount, bool isStaff);

        // Calculate interest
        public abstract string CalculateInterest();

        // Transfer money
        public virtual string TransferTo(Account targetAccount, double amount, bool isStaff)
        {
            string result = this.Withdraw(amount, isStaff); // Try withdraw

            if (result.Contains("Not enough") || result.Contains("failed"))
            {
                return "Transfer failed"; // If failed
            }

            targetAccount.Deposit(amount); // Add to target
            return "Transfer successful";
        }
    }
}