using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Assignment3_Bank_App
{
    // Main form of application
    public partial class Form1 : Form
    {
        // Store current selected customer
        Customer currentCustomer;

        // Store current selected account
        Account currentAccount;

        // List to store all customers and accounts
        List<Customer> customerData = new List<Customer>();

        // Constructor
        public Form1()
        {
            InitializeComponent();

            // Attach events
            this.Load += Form1_Load;
            this.FormClosing += Form1_FormClosing;
        }

        // Runs when form loads
        private void Form1_Load(object sender, EventArgs e)
        {
            // Load saved data from file
            customerData = DataPersistence.LoadData();

            // Show customer panel by default
            panelCustomer.Visible = true;
            panelAccount.Visible = false;
            panelTransfer.Visible = false;

            // Select customer radio button
            rbtnCustomer.Checked = true;

            // Add all account IDs to combo boxes
            foreach (var cust in customerData)
            {
                foreach (var acc in cust.Accounts)
                {
                    cmbFromAcc.Items.Add(acc.AccountID);
                    cmbToAcc.Items.Add(acc.AccountID);
                }
            }
        }

        // Runs when form is closing
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Save all data to file
            DataPersistence.SaveData(customerData);
        }

        // Show customer panel
        private void rbtnCustomer_CheckedChanged(object sender, EventArgs e)
        {
            panelCustomer.Visible = true;
            panelAccount.Visible = false;
            panelTransfer.Visible = false;
        }

        // Show account panel
        private void rbtnAccount_CheckedChanged(object sender, EventArgs e)
        {
            panelCustomer.Visible = false;
            panelAccount.Visible = true;
            panelTransfer.Visible = false;
        }

        // Show transfer panel
        private void rbtnTransfer_CheckedChanged(object sender, EventArgs e)
        {
            panelCustomer.Visible = false;
            panelAccount.Visible = false;
            panelTransfer.Visible = true;
        }

        // Add new customer
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            int number;
            string name = txtCusName.Text;
            string email = txtCusEmail.Text;
            bool isEmployee = chkStaff.Checked;

            // Check if number is empty
            if (txtCusNumber.Text == "")
            {
                MessageBox.Show("Enter customer number");
            }
            // Check email
            else if (email == "")
            {
                MessageBox.Show("Enter email");
            }
            // Convert number
            else if (int.TryParse(txtCusNumber.Text, out number))
            {
                // Create customer object
                Customer c = new Customer(number, name, email, isEmployee);

                // Add to list
                customerData.Add(c);

                // Set current customer
                currentCustomer = c;

                // Show output
                lstOutput.Items.Add("Customer added: " + name);
            }
            else
            {
                MessageBox.Show("Enter valid number");
            }
        }

        // Update customer details
        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            int number;
            string name = txtCusName.Text;
            string email = txtCusEmail.Text;
            bool isEmployee = chkStaff.Checked;

            // Convert number
            if (int.TryParse(txtCusNumber.Text, out number))
            {
                // Find customer
                var customer = customerData.FirstOrDefault(c => c.CustomerNumber == number);

                if (customer != null)
                {
                    // Update details
                    customer.CustomerName = name;
                    customer.Email = email;
                    customer.IsEmployee = isEmployee;

                    lstOutput.Items.Add("Customer updated");
                }
                else
                {
                    MessageBox.Show("Customer not found");
                }
            }
            else
            {
                MessageBox.Show("Enter valid number");
            }
        }

        // Create new account
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            int accId;
            int customerNumber;

            // Validate inputs
            if (!int.TryParse(txtCusNumber.Text, out customerNumber))
            {
                MessageBox.Show("Enter valid customer number");
                return;
            }

            if (!int.TryParse(txtAccID.Text, out accId))
            {
                MessageBox.Show("Enter valid account ID");
                return;
            }

            // Find customer
            var customer = customerData.FirstOrDefault(c => c.CustomerNumber == customerNumber);

            if (customer == null)
            {
                MessageBox.Show("Customer not found");
                return;
            }

            // Check duplicate account
            bool exists = customerData.Any(c => c.Accounts.Any(a => a.AccountID == accId));
            if (exists)
            {
                MessageBox.Show("Account ID already exists");
                return;
            }

            // Create account based on type
            if (cmbAccType.Text == "Everyday")
                currentAccount = new EverydayAccount(accId, 0);
            else if (cmbAccType.Text == "Investment")
                currentAccount = new InvestmentAccount(accId, 0);
            else
                currentAccount = new OmniAccount(accId, 0);

            // Add account to customer
            customer.Accounts.Add(currentAccount);

            // Add to combo boxes
            cmbFromAcc.Items.Add(accId);
            cmbToAcc.Items.Add(accId);

            lstOutput.Items.Add("Account created");
        }

        // Deposit money
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            int accId;
            double amount;

            if (!int.TryParse(txtAccID.Text, out accId))
            {
                MessageBox.Show("Enter valid account ID");
            }
            else if (!double.TryParse(txtAmount.Text, out amount))
            {
                MessageBox.Show("Enter valid amount");
            }
            else
            {
                // Find account
                foreach (var cust in customerData)
                {
                    foreach (var acc in cust.Accounts)
                    {
                        if (acc.AccountID == accId)
                        {
                            acc.Deposit(amount); // Add money
                            lstOutput.Items.Add("Deposited $" + amount);
                            return;
                        }
                    }
                }

                MessageBox.Show("Account not found");
            }
        }

        // Withdraw money
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            int accId;
            double amount;

            if (!int.TryParse(txtAccID.Text, out accId))
            {
                MessageBox.Show("Enter valid account ID");
            }
            else if (!double.TryParse(txtAmount.Text, out amount))
            {
                MessageBox.Show("Enter valid amount");
            }
            else
            {
                // Find account
                foreach (var cust in customerData)
                {
                    foreach (var acc in cust.Accounts)
                    {
                        if (acc.AccountID == accId)
                        {
                            // Withdraw
                            string result = acc.Withdraw(amount, cust.IsEmployee);
                            lstOutput.Items.Add(result);
                            lstOutput.Items.Add("Balance: $" + acc.Balance);
                            return;
                        }
                    }
                }

                MessageBox.Show("Account not found");
            }
        }

        // Calculate interest
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int accId;

            if (!int.TryParse(txtAccID.Text, out accId))
            {
                MessageBox.Show("Enter valid account ID");
            }
            else
            {
                foreach (var cust in customerData)
                {
                    foreach (var acc in cust.Accounts)
                    {
                        if (acc.AccountID == accId)
                        {
                            string result = acc.CalculateInterest();
                            lstOutput.Items.Add(result);
                            return;
                        }
                    }
                }

                MessageBox.Show("Account not found");
            }
        }

        // Transfer money
        private void btnTransfer_Click(object sender, EventArgs e)
        {
            try
            {
                int fromId = int.Parse(cmbFromAcc.Text);
                int toId = int.Parse(cmbToAcc.Text);
                double amount = double.Parse(txtTransferAmount.Text);

                // Prevent same account transfer
                if (fromId == toId)
                {
                    lstOutput.Items.Add("Cannot transfer to same account");
                    return;
                }

                Account fromAcc = null;
                Account toAcc = null;
                bool isStaff = false;

                // Find accounts
                foreach (var cust in customerData)
                {
                    foreach (var acc in cust.Accounts)
                    {
                        if (acc.AccountID == fromId)
                        {
                            fromAcc = acc;
                            isStaff = cust.IsEmployee;
                        }

                        if (acc.AccountID == toId)
                        {
                            toAcc = acc;
                        }
                    }
                }

                if (fromAcc == null || toAcc == null)
                {
                    lstOutput.Items.Add("Account not found");
                    return;
                }

                // Perform transfer
                string result = fromAcc.TransferTo(toAcc, amount, isStaff);

                lstOutput.Items.Add(result);
            }
            catch
            {
                lstOutput.Items.Add("Invalid transfer details");
            }
        }
    }
}