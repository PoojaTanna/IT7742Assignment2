using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_App2
{
    // InvestmentAccount:
    // - Has interest
    // - No overdraft
    // - Charges failed transaction fee
    public class InvestmentAccount : Account
    {
        public InvestmentAccount(int id, double balance, double interestRate, double failedFee)
            : base(id, balance, interestRate, 0, failedFee)
        {
        }

        public override string Withdraw(double amount, bool isStaff)
        {
            if (amount <= 0)
            {
                throw new WithdrawalException(
                    $"Investment{AccountID}; Withdrawal Failed - Invalid amount; Amount: ${amount:F2};",
                    AccountID,
                    Balance,
                    amount
                );
            }

            if (Balance >= amount)
            {
                Balance -= amount;
                return $"Investment{AccountID}; Withdrawal: ${amount:F2}; New Balance: ${Balance:F2};";
            }

            // Failed withdrawal → apply fee
            double fee = isStaff ? FailedFee / 2 : FailedFee;
            Balance -= fee;

            throw new WithdrawalException(
                $"Investment{AccountID}; Withdrawal Failed - Insufficient Funds; Fee Applied: ${fee:F2}; New Balance: ${Balance:F2};",
                AccountID,
                Balance,
                amount
            );
        }

        public override string CalculateInterest()
        {
            double interest = Balance * (InterestRate / 100);
            Balance += interest;

            return $"Investment{AccountID}; Interest Added: ${interest:F2}; New Balance: ${Balance:F2};";
        }

        public override string GetAccountInfo()
        {
            return $"Investment{AccountID}; Interest Rate: {InterestRate}%; Balance: ${Balance:F2}; Failed Fee: ${FailedFee:F2};";
        }
    }
}
