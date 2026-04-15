using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Bank_App
{
    // Customer class
    [Serializable]
    public class Customer
    {
        // Customer details
        public int CustomerNumber { get; set; } // ID
        public string CustomerName { get; set; } // Name
        public string Email { get; set; } // Email
        public bool IsEmployee { get; set; } // Staff check
        public List<Account> Accounts { get; set; } // Account list

        // Default constructor
        public Customer()
        {
            Accounts = new List<Account>(); // Empty list
        }

        // Constructor with values
        public Customer(int number, string name, string email, bool isEmployee)
        {
            CustomerNumber = number;
            CustomerName = name;
            Email = email;
            IsEmployee = isEmployee;
            Accounts = new List<Account>(); // Empty list
        }

        // Add account
        public void AddAccount(Account account)
        {
            Accounts.Add(account); // Add to list
        }

        // Show name and ID
        public override string ToString()
        {
            return CustomerName + " (" + CustomerNumber + ")";
        }
    }
}