using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_App2
{
    // EverydayAccount:
    // - No interest
    // - No overdraft
    // - No failed transaction fee
    public class EverydayAccount : Account
    {
        public EverydayAccount(int id, double balance)
            : base(id, balance, 0, 0, 0)
        {
        }

        public override string Withdraw(double amount, bool isStaff)
        {
            if (amount <= 0)
            {
                throw new WithdrawalException(
                    $"Everyday{AccountID}; Withdrawal Failed - Invalid amount; Amount: ${amount:F2};",
                    AccountID,
                    Balance,
                    amount
                );
            }

            if (Balance < amount)
            {
                throw new WithdrawalException(
                    $"Everyday{AccountID}; Withdrawal Failed - Insufficient Funds; Balance: ${Balance:F2};",
                    AccountID,
                    Balance,
                    amount
                );
            }

            Balance -= amount;

            return $"Everyday{AccountID}; Withdraw: ${amount:F2}; New Balance: ${Balance:F2};";
        }

        public override string CalculateInterest()
        {
            return $"Everyday{AccountID}; No Interest Applied; Balance: ${Balance:F2};";
        }

        public override string GetAccountInfo()
        {
            return $"Everyday{AccountID}; Current Balance: ${Balance:F2};";
        }
    }
}
