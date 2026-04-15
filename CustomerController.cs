using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Bank_App
{
    // Manage customers
    public class CustomerController
    {
        private List<Customer> customers = new List<Customer>(); // Customer list

        // Add new customer
        public void AddCustomer(int customerNumber, string name, string email, bool isEmployee)
        {
            Customer customer = new Customer(customerNumber, name, email, isEmployee);
            customers.Add(customer); // Add to list
        }

        // Remove customer
        public bool RemoveCustomer(int customerNumber)
        {
            Customer customerToRemove = customers.Find(c => c.CustomerNumber == customerNumber); // Find customer

            if (customerToRemove != null)
            {
                customers.Remove(customerToRemove); // Remove
                return true;
            }
            else
            {
                return false; // Not found
            }
        }

        // Update customer details
        public bool UpdateCustomer(int customerNumber, string newName, string newEmail, bool newIsEmployee)
        {
            Customer customerToUpdate = customers.Find(c => c.CustomerNumber == customerNumber); // Find customer

            if (customerToUpdate != null)
            {
                customerToUpdate.CustomerName = newName;
                customerToUpdate.Email = newEmail;
                customerToUpdate.IsEmployee = newIsEmployee;
                return true;
            }
            else
            {
                return false; // Not found
            }
        }

        // Get customer info
        public string GetCustomerInfo(int customerNumber)
        {
            Customer customer = customers.Find(c => c.CustomerNumber == customerNumber); // Find customer

            if (customer != null)
            {
                return customer.ToString(); // Return info
            }
            else
            {
                return "Customer not found";
            }
        }
    }
}