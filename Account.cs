using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_App2
{
    // Base class for all types of bank accounts
    public abstract class Account
    {
        // Unique ID number of the account
        public int AccountID { get; private set; }

        // Current money in the account
        public double Balance { get; protected set; }

        // Interest percentage (if the account uses interest)
        public double InterestRate { get; protected set; }

        // Maximum overdraft allowed (for accounts that support overdraft)
        public double OverdraftLimit { get; protected set; }

        // Fee charged when a transaction fails (varies by account type)
        public double FailedFee { get; protected set; }

        // Constructor
        protected Account(int accountID, double balance, double interestRate = 0, double overdraftLimit = 0, double failedFee = 0)
        {
            AccountID = accountID;
            Balance = balance;
            InterestRate = interestRate;
            OverdraftLimit = overdraftLimit;
            FailedFee = failedFee;
        }

        // Deposit method: adds money to the account
        public virtual void Deposit(double amount)
        {
            Balance += amount;
        }

        // Must be implemented by child classes
        public abstract string Withdraw(double amount, bool isStaff);

        public abstract string CalculateInterest();

        public abstract string GetAccountInfo();
    }
}
