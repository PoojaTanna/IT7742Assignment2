using System;

namespace Bank_App2
{
    public class Customer
    {
        public string CustomerName { get; private set; }
        public string Email { get; private set; }
        public bool IsEmployee { get; private set; }

        public Customer(string name, string email, bool isEmployee)
        {
            CustomerName = name;
            Email = email;
            IsEmployee = isEmployee;
        }

        public void Update(string name, string email, bool isEmployee)
        {
            CustomerName = name;
            Email = email;
            IsEmployee = isEmployee;
        }

        public override string ToString()
        {
            return $"Customer_Name: {CustomerName} = Email: {Email} {(IsEmployee ? "Employee" : "Customer")}";
        }
    }
}