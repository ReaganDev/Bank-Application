using Raph.Core.Interface;
using Raph.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Raph
{
    public partial class CreateNewAccount : Form
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IAccountRepository _accountRepository;
        private readonly ITransactionRepository _transactionRepository;
        private readonly IAuthenticationRepository _authenticationRepository;

        public string AcctType { get; private set; }
        public CreateNewAccount(IAuthenticationRepository authRepo,ICustomerRepository custRepo, IAccountRepository accountRepo, ITransactionRepository transactRepo)
        {
            InitializeComponent();
            _customerRepository = custRepo;
            _accountRepository = accountRepo;
            _transactionRepository = transactRepo;
            _authenticationRepository = authRepo;

        }

        private void CenterPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SavingsRbtn_CheckedChanged(object sender, EventArgs e)
        {
            AcctType = "Savings";
        }

        private void CurrentButton2_CheckedChanged(object sender, EventArgs e)
        {
            AcctType = "Current";
        }

        private void NewAcctBtn_Click(object sender, EventArgs e)
        {
            try
            {   
               

                var email = Home.loggedInUser;
                decimal amount = Convert.ToInt32(amtTxtBox.Text);

                if (AcctType == null)
                {
                    MessageBox.Show("Please select an account Type", "Error", MessageBoxButtons.OK);
                    return;
                }

                if (string.IsNullOrEmpty(amtTxtBox.Text))
                {
                    MessageBox.Show("All Field Must be Filled", "Error", MessageBoxButtons.OK);
                    return;
                }

                if (email == null)
                {
                    email = Register.myList[2];
                }

                // get customer name by email
                var customer = _customerRepository.GetCustomerByEmail(email);

                Account account = new Account(customer.CustomerId, AcctType, amount);

                //Add transaction to account
                account.TransactHistory.Add(new Transaction(account.AcctNumber, account.AccType, account.Balance, "Initial Deposit"));

                //Add account to  user 
                customer.Accounts.Add(account);


                _accountRepository.AddAccount(account);

                MessageBox.Show("Account Created Successfully", "Error", MessageBoxButtons.OK);



                DashBoard dashBoard = new DashBoard(_authenticationRepository,_customerRepository, _accountRepository, _transactionRepository);
                this.Hide();
                dashBoard.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Create Account At this Moment" + ex , "Eror", MessageBoxButtons.OK);
            }
        }

     
    }
}
