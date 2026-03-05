using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_App2
{
    // OmniAccount:
    // - Has interest
    // - Has overdraft
    // - Charges failed transaction fee
    public class OmniAccount : Account
    {
        public OmniAccount(int id, double balance, double interestRate, double overdraftLimit, double failedFee)
            : base(id, balance, interestRate, overdraftLimit, failedFee)
        {
        }

        public override string Withdraw(double amount, bool isStaff)
        {
            if (amount <= 0)
            {
                throw new WithdrawalException(
                    $"Omni{AccountID}; Withdrawal Failed - Invalid amount; Amount: ${amount:F2};",
                    AccountID,
                    Balance,
                    amount
                );
            }

            // allowed if balance + overdraft covers the amount
            if (Balance + OverdraftLimit >= amount)
            {
                Balance -= amount;
                return $"Omni{AccountID}; Withdrawal: ${amount:F2}; New Balance: ${Balance:F2};";
            }

            // Failed withdrawal → apply fee
            double fee = isStaff ? FailedFee / 2 : FailedFee;
            Balance -= fee;

            throw new WithdrawalException(
                $"Omni{AccountID}; Withdrawal Failed - Overdraft exceeded; Fee Applied: ${fee:F2}; New Balance: ${Balance:F2};",
                AccountID,
                Balance,
                amount
            );
        }

        public override string CalculateInterest()
        {
            // Interest only if balance > 1000
            if (Balance > 1000)
            {
                double interest = Balance * (InterestRate / 100);
                Balance += interest;
                return $"Omni{AccountID}; Interest Added: ${interest:F2}; New Balance: ${Balance:F2};";
            }

            return $"Omni{AccountID}; Balance below $1000. No Interest Applied; Balance: ${Balance:F2};";
        }

        public override string GetAccountInfo()
        {
            return $"Omni{AccountID}; Interest Rate: {InterestRate}%; Overdraft Limit: ${OverdraftLimit:F2}; Failed Fee: ${FailedFee:F2}; Balance: ${Balance:F2};";
        }
    }
}
