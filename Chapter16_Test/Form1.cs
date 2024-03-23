using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter16_Test
{
    public partial class Form1 : Form
    {
        private Loan currentLoan;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            double amount;

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter a name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtAmount.Text, out amount) || amount < 0)
            {
                MessageBox.Show("Please enter a valid positive amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string loanType = radButtonShort.Checked ? "Short-Term" : "Long-Term";
            double interestRate = loanType == "Short-Term" ? 0.10 : 0.05;

            currentLoan = new Loan(name, amount, interestRate, loanType);

            lblNameOutput.Text = currentLoan.Name;
            lblAmountOutput.Text = $"{loanType} loan of {currentLoan.Amount:C}";
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (currentLoan == null)
            {
                MessageBox.Show("Please create a loan first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double monthlyPayment;
            double interestRate;

            if (currentLoan.Type == "Short-Term")
            {
                monthlyPayment = 450;
                interestRate = 0.10;
            }
            else
            {
                monthlyPayment = 200;
                interestRate = 0.05;
            }

            currentLoan.MakePayment();

            double balanceBeforeInterest = currentLoan.Amount;

            currentLoan.ApplyInterest();

            lblBeforeInterest.Text = $"Before Interest: {balanceBeforeInterest:C}";
            lblAfterInterest.Text = $"After Payment: {currentLoan.Amount:C}";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtAmount.Clear();

            radButtonShort.Checked = false;
            radButtonLong.Checked = false;

            lblNameOutput.Text = "";
            lblAmountOutput.Text = "";
            lblBeforeInterest.Text = "";
            lblAfterInterest.Text = "";

            currentLoan = null;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }

    public class Loan
        {
            public string Name { get; }
            public string Type { get; }
            public double Amount { get; private set; }
            public double InterestRate { get; }

            public double AmountBeforeInterest { get; private set; }

        public Loan(string name, double amount, double interestRate, string type)
        {
            Name = name;
            Amount = amount;
            InterestRate = interestRate;
            AmountBeforeInterest = amount;
            Type = type;
        }

        public void MakePayment()
            {
                if (Type == "Short-Term")
                    Amount -= 450;
                else
                    Amount -= 200;

                if (Amount < 0)
                    Amount = 0;
            }

            public void ApplyInterest()
            {
                Amount *= (1 + InterestRate);
            }
        }
    }
