using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_App2
{
    public partial class Form1 : Form
    {
        private CustomerController controller = new CustomerController();
        private Account _currentAccount;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoveCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtEmail.Text.Trim();

                if (string.IsNullOrWhiteSpace(email))
                {
                    Message.Items.Add("Enter email to remove customer.");
                    return;
                }

                controller.RemoveCustomer(email);
                Message.Items.Add("Customer removed.");
            }
            catch (Exception ex)
            {
                Message.Items.Add(ex.Message);
            }
        }

        private void cmbAccountType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string fullName = txtFullName.Text.Trim();
                string email = txtEmail.Text.Trim();
                bool isStaff = chkStaff.Checked;

                if (string.IsNullOrWhiteSpace(fullName))
                {
                    Message.Items.Add("Please enter full name.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(email) || !email.Contains("@") || !email.Contains("."))
                {
                    Message.Items.Add("Email format is invalid.");
                    return;
                }

                controller.AddCustomer(fullName, email, isStaff);

                Message.Items.Add($"Customer Created: {fullName} = Email: {email} {(isStaff ? "Employee" : "Customer")}");
            }
            catch (Exception ex)
            {
                Message.Items.Add(ex.Message);
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCustomerNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateAccount_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                string fullName = txtFullName.Text.Trim();
                string email = txtEmail.Text.Trim();
                bool isStaff = chkStaff.Checked;

                if (string.IsNullOrWhiteSpace(fullName))
                {
                    Message.Items.Add("Please enter full name.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(email) || !email.Contains("@") || !email.Contains("."))
                {
                    Message.Items.Add("Email format is invalid.");
                    return;
                }

                controller.UpdateCustomer(email, fullName, isStaff);

                Message.Items.Add("Customer updated.");
            }
            catch (Exception ex)
            {
                Message.Items.Add(ex.Message);
            }
        }

        private void btnCreateAcc_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtAccountId.Text, out int accountId))
                {
                    Message.Items.Add("Please enter a valid AccountID.");
                    return;
                }

                string type = cmbAccountType.Text?.Trim();
                if (string.IsNullOrWhiteSpace(type))
                {
                    Message.Items.Add("Please select account type.");
                    return;
                }

                if (type == "Everyday")
                    _currentAccount = new EverydayAccount(accountId, 0);
                else if (type == "Investment")
                    _currentAccount = new InvestmentAccount(accountId, 0, 5, 10);
                else if (type == "Omni")
                    _currentAccount = new OmniAccount(accountId, 0, 5, 100, 10);
                else
                {
                    Message.Items.Add("Invalid account type. Select Everyday / Investment / Omni.");
                    return;
                }

                Message.Items.Add($"Account Created: {type}{accountId}; Balance: ${_currentAccount.Balance:F2}");
            }
            catch (Exception ex)
            {
                Message.Items.Add(ex.Message);
            }
        }

        private void lstOutput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Message.Items.Clear();   // clear all messages
            Message.Items.Add("Output cleared."); // show message
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

    
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (_currentAccount == null)
            {
                Message.Items.Add("Please create an account first.");
                return;
            }

            double amount;

            if (!double.TryParse(txtAmount.Text, out amount) || amount <= 0)
            {
                Message.Items.Add("Enter a valid withdraw amount.");
                return;
            }

            bool isStaff = chkStaff.Checked;

            string result = _currentAccount.Withdraw(amount, isStaff);

            Message.Items.Add(result);
            Message.Items.Add("Balance: $" + _currentAccount.Balance);

            txtAmount.Clear();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (_currentAccount == null)
            {
                Message.Items.Add("Please create an account first.");
                return;
            }

            double amount;

            if (!double.TryParse(txtAmount.Text, out amount) || amount <= 0)
            {
                Message.Items.Add("Enter a valid deposit amount.");
                return;
            }

            _currentAccount.Deposit(amount);

            Message.Items.Add("Deposit successful.");
            Message.Items.Add("Balance: $" + _currentAccount.Balance);

            txtAmount.Clear();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}