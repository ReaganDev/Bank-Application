using Raph.Core;
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
    public partial class RegisterControl : UserControl
    {
        private readonly IAuthenticationRepository _authenticationRepository;
        private readonly ICustomerRepository _customerRepository;
        private readonly IAccountRepository _accountRepository;
        public static bool loggedInUser;
        private ITransactionRepository _transactionRepository;

        public string acctType { get; private set; }

        public  RegisterControl(IAuthenticationRepository authRepo, ICustomerRepository custRepo, IAccountRepository accountRepo,
            ITransactionRepository transactRepo)
        {
            InitializeComponent();
            _authenticationRepository = authRepo;
            _customerRepository = custRepo;
            _accountRepository = accountRepo;
            _transactionRepository = transactRepo;

        }
      
       
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            acctType = "Savings";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            acctType = "Current";
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var list = Register.myList;

                if (acctType == null)
                {
                    MessageBox.Show("Please select an account Type", "Error", MessageBoxButtons.OK);
                    return;
                }

                if (string.IsNullOrEmpty(amountTxtBox.Text))
                {
                    MessageBox.Show("All Field Must be Filled", "Error", MessageBoxButtons.OK);

                }
                else
                {


                    decimal amount = Convert.ToInt32(amountTxtBox.Text);



                    if (amount <= 0)
                    {
                        MessageBox.Show("Cannot create with a Zero or negative Balance", "Error", MessageBoxButtons.OK);

                    }
                    else
                    {



                        var user = new Customer(list[0], list[1], list[2], list[3], list[4]);

                        Account account = new Account(user.CustomerId, acctType, amount);

                        //Add transaction to account
                        account.TransactHistory.Add(new Transaction(account.AcctNumber, account.AccType, account.Balance, "Initial Deposit"));

                        //Add account to  user 
                        user.Accounts.Add(account);


                        loggedInUser = _authenticationRepository.Register(user);

                        DashBoard dashBoard = new DashBoard( _authenticationRepository,_customerRepository, _accountRepository, _transactionRepository);
                        this.Hide();
                        dashBoard.Show();
                    }


                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Occured, Try again After some time" + ex, "Error", MessageBoxButtons.OK);
            }



        }

        private void amountTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegisterControl_Load(object sender, EventArgs e)
        {

        }
    }
}
