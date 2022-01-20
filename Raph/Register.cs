using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Raph.Commons;
using Raph.Core;
using Raph.Core.Interface;

namespace Raph
{
    public partial class Register : Form
    {
        public static List<string> myList = new List<string>();
        private readonly IAuthenticationRepository _authenticationRepository;
        private readonly ICustomerRepository _customerRepository;
        private readonly IAccountRepository _accountRepository;
        private readonly ITransactionRepository _transactionRepository;

        public Register(IAuthenticationRepository authRepo, ICustomerRepository custRepo, IAccountRepository accountRepo,
            ITransactionRepository transactRepo)
        {
            InitializeComponent();
            _authenticationRepository = authRepo;
            _customerRepository = custRepo;
            _accountRepository = accountRepo;
            _transactionRepository = transactRepo;

        }

        public void ShowControl(Control control)
        {
            centerPanel.Controls.Clear();
            //control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();
            centerPanel.Controls.Add(control);

        }

        private void emailTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var firstName = firstNameTxtbox.Text;
                var lastName = LastNameTxtbox.Text;
                var email = emailTxtbox.Text;
                var phone = phoneTxt.Text;
                var password = pswTxtBox.Text;

                if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(email)
                    || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("All Field Must be Filled", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    if (!Utilities.ValidEmail(email))
                    {
                        MessageBox.Show("Invalid Mail Format, Enter Mail Again", " Error ", MessageBoxButtons.OK);
                    }
                    else
                    {

                        myList.Add(firstName); myList.Add(lastName); myList.Add(email);
                        myList.Add(phone); myList.Add(password);

                        RegisterControl regNext = new RegisterControl(_authenticationRepository, _customerRepository, _accountRepository, _transactionRepository);
                        ShowControl(regNext);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured, Try again After some time" + ex, "Error", MessageBoxButtons.OK);
            }

        }

        private void centerPanel_Paint(object sender, PaintEventArgs e)
        {
             
        }

        private void firstNameTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LastNameTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void phoneTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void pswTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
