/// <summary>
/// Code for getting user input from form and display all calculated values
/// Author: Sai Shalini Karaikatte Venugopal
/// Created Date: 07-JUL-2021
/// </summary>
using CustomerData;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BillGenerator
{
    public partial class BillDetails : Form
    {
        List<Customer> customers = new List<Customer>(); // Declaring list to display
                                                         // customer details
        decimal totalAmountBilled = 0;//Initializing bill amount to 0 for statistics
        decimal avgAmountBilled = 0;//Initializing bill amount to 0 for statistics
        decimal totalUnitsUsed = 0;//Initializing total units used to 0 for statistics
        public BillDetails()
        {
            InitializeComponent();
        }

        private void BillDetails_Load(object sender, EventArgs e)
        {                  
            
        }
        /// <summary>
        /// Clears all values other than statistics
        /// </summary>
        private void btnClear_Click(object sender, EventArgs e)
        {
            AddNew();
            lblAccountIdDisp.Text = "";            
            lblAmountBilledDisp.Text = "";
        }
        /// <summary>
        /// Clears customer input values
        /// </summary>
        private void AddNew()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtUnitsUsed.Text = "";
        }
        /// <summary>
        /// Closes the form
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
        /// <summary>
        /// Method to validate input, display calculated bill amount, 
        /// calculates statistics values and display them, and
        /// add the customers to a list on the form
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (Validator.IsPresent(txtFirstName, lblFirstName.Text) &&
                Validator.IsPresent(txtLastName , lblLastName.Text) &&
                Validator.IsPresent(txtUnitsUsed , lblKwhUsed.Text) &&
                Validator.IsNonNegativeDecimal(txtUnitsUsed, lblKwhUsed.Text)
                )// if valid data
            {
                string firstName = txtFirstName.Text;
                string lastName = txtLastName.Text;
                decimal unitsUsed = Convert.ToDecimal(txtUnitsUsed.Text);
                decimal amountBilled = Customer.GetBillAmount(unitsUsed);
                totalAmountBilled += amountBilled;
                totalUnitsUsed += unitsUsed;
                Customer customer = new Customer(firstName, lastName, unitsUsed, amountBilled);
                customers.Add(customer);
                lblAccountIdDisp.Text = customer.AccountId.ToString();
                lblAmountBilledDisp.Text = amountBilled.ToString("c");
                DisplayCustomers();
                lblAverageBillDisplay.Text = DisplayAvgAmount(totalAmountBilled).ToString("c");
                lblTotalKwhDisplay.Text = totalUnitsUsed.ToString();
                lblCustomerCountDisplay.Text = customers.Count.ToString();
                AddNew();
            }
        }
        /// <summary>
        /// Displays customer information on list
        /// </summary>
        private void DisplayCustomers()
        {
            lstCustomerDetails.Items.Clear();
            foreach (Customer c in customers)
                lstCustomerDetails.Items.Add(c);            
        }
        /// <summary>
        /// Method to calculate Average bill amount
        /// <param name="totalAmount">total amount calculated</param>
        /// <returns>average bill amount</returns>
        /// </summary>
        private decimal DisplayAvgAmount(decimal totalAmount)
        {
            avgAmountBilled = totalAmount / customers.Count;
            return avgAmountBilled;               
        }
      
    }
}
