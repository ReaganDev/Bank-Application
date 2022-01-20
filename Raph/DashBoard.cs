using Raph.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using Raph.Models;
using Raph.Core.Interface;
using Raph.Commons;

namespace Raph
{
    public partial class DashBoard : Form
    {

        public static List<Transaction> allTransact;

        private  readonly ICustomerRepository _customerRepository;
        private  readonly IAccountRepository _accountRepository;
        private  readonly ITransactionRepository _transactionRepository;
        private readonly IAuthenticationRepository _authenticationRepository;

        public DashBoard(IAuthenticationRepository authRepo,ICustomerRepository custRepo,IAccountRepository accountRepo,ITransactionRepository transactRepo)
        {
            InitializeComponent();
            _customerRepository = custRepo;
            _accountRepository = accountRepo;
            _transactionRepository = transactRepo;
            _authenticationRepository = authRepo;

        }



        public void ShowControl(Control control)
        {
            centerPanel.Controls.Clear();
            control.BringToFront();
            control.Focus();
            centerPanel.Controls.Add(control);
        }


        private void TabPage2_Click(object sender, EventArgs e)
        {

        }

        private void CreateTab_Click(object sender, EventArgs e)
        {

        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Crtlbl_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void displayPanel_Paint(object sender, PaintEventArgs e)
        {

            //extract user email
            try
            {
                var email = Home.loggedInUser;

                if (email == null)
                {
                    email = Register.myList[2];
                }

                // get customer name by email
                var customer = _customerRepository.GetCustomerByEmail(email);

                //get customer account details by accountId
                var customerAccount = _accountRepository.GetCustomerAccounts(customer.CustomerId);

                welcomeLbl.Text = " Welcome to Bank Of America : " + Utilities.FirstCharacterToUpper(customer.FirstName) + " " + customer.LastName;

                for (int i = 0; i < customerAccount.Count; i++)
                {
                    holderLbl.Text += customerAccount[i].AccType + ":\t\t " + customerAccount[i].AcctNumber + "\n\n";
                }

            }catch(Exception ex)
            {
                MessageBox.Show("Error Occurr ed, Try again After some time" + ex, "Error", MessageBoxButtons.OK);
            }
            
           
            

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void depositBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var userAccount = depoAcctTxt.Text;
                decimal userAmount = Convert.ToInt32(amtTxtBox.Text);
                string remark = NarrativeTxtBox.Text;
                if (string.IsNullOrEmpty(amtTxtBox.Text))
                {
                    MessageBox.Show("All Field Must be Filled", "Error", MessageBoxButtons.OK);
                    return;
                }

                //check if account exist
                if (!_accountRepository.NumExist(userAccount))
                {
                    MessageBox.Show("No such Account", "Error", MessageBoxButtons.OK);
                    amtTxtBox.Clear();
                }
                else
                {
                    var accountType = _accountRepository.AccountType(userAccount);

                    _accountRepository.Deposit(userAccount, accountType, userAmount, remark);

                    MessageBox.Show(" Transaction Successful", "Success", MessageBoxButtons.OK);
                    depoAcctTxt.Clear();
                    amtTxtBox.Clear();
                    NarrativeTxtBox.Clear();

                    DashBoard newdashboard = new DashBoard(_authenticationRepository,_customerRepository, _accountRepository, _transactionRepository);
                    this.Close();
                    newdashboard.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occurred, Try again After some time" + ex, "Error", MessageBoxButtons.OK); 
            }
        }

        private void accountBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void withdrawBtn_Click(object sender, EventArgs e)
        {
            var acctNum = AcctNumTxtBox.Text;
            decimal amount = Convert.ToInt32(AtxtBox.Text);
            var remark = NarTxtBox.Text;
            try
            {

                if (!_accountRepository.NumExist(acctNum))
                {
                    MessageBox.Show("No such Account ", " Error", MessageBoxButtons.OK);
                    AtxtBox.Clear();
                }
                else
                {
                    var accountType = _accountRepository.AccountType(acctNum);


                    _accountRepository.Withdraw(acctNum, accountType, amount, remark);
                    var bal = _accountRepository.GetBalance(acctNum);

                    MessageBox.Show("Transaction Successful. Your Balance is : " + bal, "Success", MessageBoxButtons.OK);
                    AcctNumTxtBox.Clear();
                    AtxtBox.Clear();
                    NarTxtBox.Clear();

                    DashBoard newdash = new DashBoard(_authenticationRepository,_customerRepository, _accountRepository, _transactionRepository);
                    this.Hide();
                    newdash.Show();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Occurred, Try again After some time" + ex, "Error", MessageBoxButtons.OK);
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void chkBtn_Click(object sender, EventArgs e)
        {
            var checkAcct = ChkTxtBox.Text;

            try
            {
                if (!_accountRepository.NumExist(checkAcct))
                {
                    MessageBox.Show("No such Account ", " Error", MessageBoxButtons.OK);
                    AtxtBox.Clear();
                }
                else
                {
                    var balance = _accountRepository.GetBalance(checkAcct);

                    MessageBox.Show("Your Balance is : " + balance, " balance", MessageBoxButtons.OK);
                    ChkTxtBox.Clear();

                    DashBoard newdashboard = new DashBoard(_authenticationRepository, _customerRepository, _accountRepository, _transactionRepository);
                    this.Close();
                    newdashboard.Show();

                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error Occurred, Try again After some time" + ex, "Error", MessageBoxButtons.OK);
            }

        }

       
        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void printSmtBtn_Click(object sender, EventArgs e)
        {
            var printAcct = smtActTxt.Text;
            try
            {
                if (!_accountRepository.NumExist(printAcct))
                {
                    MessageBox.Show("No such Account ", " Error", MessageBoxButtons.OK);
                    smtActTxt.Clear();
                }
                else
                {
                    allTransact = _transactionRepository.GetAllTransaction(printAcct);
                    StatementForm statementForm = new StatementForm();
                    this.Hide();
                    statementForm.Show();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Occurred, Try again After some time" + ex, "Error", MessageBoxButtons.OK);
            }

        }

        private void CreateAccountBtn_Click(object sender, EventArgs e)
        {
            CreateNewAccount create = new CreateNewAccount(_authenticationRepository,_customerRepository, _accountRepository, _transactionRepository);
            create.Show();
        }

        private void holderLbl_Click(object sender, EventArgs e)
        {

        }

        private void fndTab_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void AcctTypeCmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CmbAmtTxtBox_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void sndTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FtlblRmk_Click(object sender, EventArgs e)
        {

        }

        private void ftBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var Sender = sndTxtBox.Text;
                var reciever = rcvAcctTxtBox.Text;
                decimal amount = Convert.ToInt32(FtAmtTxtBox.Text);
                var remark = FtRmkTxtBox.Text;

                if (string.IsNullOrEmpty(Sender) || string.IsNullOrEmpty(reciever) || string.IsNullOrEmpty(remark) || string.IsNullOrEmpty(FtAmtTxtBox.Text))
                {
                    MessageBox.Show("Fill All Column Correctly", "Error", MessageBoxButtons.OK);
                    return;
                }


                _accountRepository.FundTransfer(Sender, reciever, amount, remark);

                var balance = _accountRepository.GetBalance(Sender);
                MessageBox.Show("Your Balance is : " + balance, " balance", MessageBoxButtons.OK);
                DashBoard newdash = new DashBoard(_authenticationRepository, _customerRepository, _accountRepository, _transactionRepository);
                this.Hide();
                newdash.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Try again later" + ex, " Error", MessageBoxButtons.OK);
            }
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            Home home = new Home(_authenticationRepository, _customerRepository, _accountRepository, _transactionRepository);
            this.Hide();
            home.Show();
        }

        private void welcomeLbl_Click(object sender, EventArgs e)
        {

        }
    }
}

