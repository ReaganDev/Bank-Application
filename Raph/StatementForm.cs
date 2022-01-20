using Raph.Core;
using Raph.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Raph
{
    public partial class StatementForm : Form
    {
       
       

        public StatementForm()
        {
            InitializeComponent();
        }



        private void StatementForm_Load(object sender, EventArgs e)
        {

        }

        private void displayPanel_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                var list = DashBoard.allTransact;

                dataGridTxtBox.DataSource = list.Select(s=> new { 
                    
                    AccountNumber = s.AcctNumber,
                    s.AccountType,
                    s.Amount,
                    s.DateOfTransaction
                
                }).ToList();
                
            }catch(Exception ex)
            {
                MessageBox.Show("Error Occurred, Cannot print at this time! try Later " + ex, "Error", MessageBoxButtons.OK);
            }
        }

        private void displayLbl_Click(object sender, EventArgs e)
        {

        }

        private void dataGridTxtBox_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
