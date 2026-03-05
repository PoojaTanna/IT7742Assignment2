using System;
using System.Collections.Generic;
using System.Linq;

namespace Bank_App2
{
    public class CustomerController
    {
        private readonly List<Customer> _customers = new List<Customer>();

        public IReadOnlyList<Customer> GetAllCustomers()
        {
            return _customers.AsReadOnly();
        }

        // Add customer
        public void AddCustomer(string name, string email, bool isEmployee)
        {
            Validate(name, email);

            // Email should be unique
            if (_customers.Any(c => c.Email.Equals(email, StringComparison.OrdinalIgnoreCase)))
                throw new InvalidOperationException("Customer with this email already exists.");

            _customers.Add(new Customer(name, email, isEmployee));
        }

        // Update customer by email
        public void UpdateCustomer(string email, string name, bool isEmployee)
        {
            Validate(name, email);

            var customer = _customers.FirstOrDefault(c =>
                c.Email.Equals(email, StringComparison.OrdinalIgnoreCase));

            if (customer == null)
                throw new InvalidOperationException("Customer not found.");

            customer.Update(name, email, isEmployee);
        }

        // Remove customer by email
        public void RemoveCustomer(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                throw new ArgumentException("Email is required.");

            var customer = _customers.FirstOrDefault(c =>
                c.Email.Equals(email, StringComparison.OrdinalIgnoreCase));

            if (customer == null)
                throw new InvalidOperationException("Customer not found.");

            _customers.Remove(customer);
        }

        private static void Validate(string name, string email)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name is required.");

            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@") || !email.Contains("."))
                throw new ArgumentException("Email format is invalid.");
        }
    }
}