using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Raph.Commons;
using Raph.Core;
using Raph.Core.Interface;

namespace Raph
{
    public partial class Home : Form
    {
        private readonly IAuthenticationRepository _authenticationRepository;
        private readonly ICustomerRepository _customerRepository;
        private readonly IAccountRepository _accountRepository;
        private readonly ITransactionRepository _transactionRepository;
        public static  string loggedInUser;
        
        public Home(IAuthenticationRepository authRepo, ICustomerRepository custRepo, 
            IAccountRepository accountRepo, ITransactionRepository transactRepo)
        {
            InitializeComponent();

            _authenticationRepository = authRepo;
            _customerRepository = custRepo;
            _accountRepository = accountRepo;
            _transactionRepository = transactRepo;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {

            var email = emailTxtBox.Text;
            var password = pswTxtBox.Text;

            if (String.IsNullOrEmpty(email) || String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Empty E-mail or Password Field", "Error", MessageBoxButtons.OK);
                
            }

            if (!Utilities.ValidEmail(email))
            {
                MessageBox.Show("Invalid E-mail", "Error", MessageBoxButtons.OK);
                emailTxtBox.Clear();
                pswTxtBox.Clear();
            }
            else
            {
                if(_authenticationRepository.IsValidCredential(email,password) == true)
                {
                    loggedInUser = email;
                    DashBoard dashboard = new DashBoard(_authenticationRepository,_customerRepository, _accountRepository, _transactionRepository);
                    this.Hide();
                    dashboard.Show();
                }
                else
                {

                   var res = MessageBox.Show("Go to Registration Page to Register", "Register", MessageBoxButtons.OKCancel);

                    if(res == DialogResult.OK)
                    {
                        Register newReg = new Register(_authenticationRepository, _customerRepository, _accountRepository, _transactionRepository);
                        this.Hide();
                        newReg.Show();
                    }
                    else
                    {
                        emailTxtBox.Clear();
                        pswTxtBox.Clear();
                    }
                   
                }

            }





        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            Register newReg = new Register(_authenticationRepository, _customerRepository, _accountRepository, _transactionRepository);
            this.Hide();
            newReg.Show();
        }

        private void emailTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pswTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CenterPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
