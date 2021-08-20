//Code for creating Lunch Order
//Author: Sai Shalini Karaikatte Venugopal
//Created Date: 28-JUN-2021
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lunch_Order
{
    public partial class frmLunch : Form
    {
        const decimal HAMBURGER = 6.95m;//decalaring Constant for price of Hamburger
        const decimal PIZZA = 5.95m;//decalaring Constant for price of Pizza
        const decimal SALAD = 4.95m;//decalaring Constant for price of Salad
        const decimal BURGERADD = 0.75m;//decalaring Constant for add-ons for Hamburger
        const decimal PIZZAADD = 0.50m;//decalaring Constant for add-ons for Pizza
        const decimal SALADADD = 0.25m;//decalaring Constant for add-ons for Salad
        const decimal TAX = 0.05m;//decalaring Constant for tax calculation at 5%
        decimal subtotal;//decalaring Variable for storing calculated subtotal 

        public frmLunch()
        {
            InitializeComponent();
        }
        /*setting values for group box and checkboxes text attribute
       on selection of Hamburger in main course*/
        private void radHamBurger_CheckedChanged(object sender, EventArgs e)
        {
            ClearExtras();//function to clear values when radio button selection is changed
            grpAddOn.Text = "Add-on items ($0.75 each)";
            chkExtras1.Text = "Lettuce,tomato, and onions";
            chkExtras2.Text = "Ketchup, mustard and mayo";
            chkExtras3.Text = "French  Fries";
        }
         
        /*setting values for group box and checkboxes text attribute
       on selection of Pizza in main course*/
        private void radPizza_CheckedChanged(object sender, EventArgs e)
        {
            ClearExtras();//function to clear values when radio button selection is changed
            grpAddOn.Text = "Add-on items ($0.50 each)";
            chkExtras1.Text = "Pepperoni";
            chkExtras2.Text = "Sausage";
            chkExtras3.Text = "Olives";
                 
        }
        /*setting values for group box and checkboxes text attribute
       on selection of Pizza in main course*/
        private void radSalad_CheckedChanged(object sender, EventArgs e)
        {
            ClearExtras();//function to clear values when radio button selection is changed
            grpAddOn.Text = "Add-on items ($0.25 each)";
            chkExtras1.Text = "Croutons";
            chkExtras2.Text = "Bacon Bits";
            chkExtras3.Text = "Bread Sticks";
        }
        //Calculating and dispalying subtotal, tax and total on click of button 'Place Order'
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            /*if Hamburger is selected in main-course calculate subtotal and
            pass it to method CalcTotal which has out parameters tax and total*/
            if (radHamBurger.Checked)
            {
                subtotal = HAMBURGER;//price of hamburger
                if (chkExtras1.Checked)
                    subtotal += BURGERADD;//price with one add-on selected
                if (chkExtras2.Checked)
                    subtotal += BURGERADD;//price with two add-ons selected
                if (chkExtras3.Checked)
                subtotal += BURGERADD;//price with three add-ons selected
                CalcTotal(subtotal,out decimal tax,out decimal total);//call method to calculate tax and total by passing subtotal
                lblDisplaySubtotal.Text = subtotal.ToString("c");//displaying subtotal 
                lblDisplayTax.Text = tax.ToString("c");//displaying tax received from CalcTotal method
                lblDisplayTotal.Text = total.ToString("c");//displaying total received from CalcTotal method
            }
            /*if Pizza is selected in main-course calculate subtotal and
            pass it to method CalcTotal which has out parameters tax and total*/
            else if (radPizza.Checked)
            {
                subtotal = PIZZA;//price of pizza
                if (chkExtras1.Checked)
                    subtotal += PIZZAADD;//price with one add-on selected
                if (chkExtras2.Checked)
                    subtotal += PIZZAADD;//price with two add-ons selected
                if (chkExtras3.Checked)
                    subtotal += PIZZAADD;//price with three add-ons selected
                CalcTotal(subtotal, out decimal tax, out decimal total);//call method to calculate tax and total by passing subtotal
                lblDisplaySubtotal.Text = subtotal.ToString("c");//displaying subtotal 
                lblDisplayTax.Text = tax.ToString("c");//displaying tax received from CalcTotal method
                lblDisplayTotal.Text = total.ToString("c");//displaying total received from CalcTotal method
            }
            /*if Salad is selected in main-course calculate subtotal and
            pass it to method CalcTotal which has out parameters tax and total*/
            else if (radSalad.Checked)
            {
                subtotal = SALAD;
                if (chkExtras1.Checked)
                    subtotal += SALADADD;//price with one add-on selected
                if (chkExtras2.Checked)
                    subtotal += SALADADD;//price with two add-ons selected
                if (chkExtras3.Checked)
                    subtotal += SALADADD;//price with three add-ons selected
                CalcTotal(subtotal, out decimal tax, out decimal total);//call method to calculate tax and total by passing subtotal
                lblDisplaySubtotal.Text = subtotal.ToString("c");//displaying subtotal 
                lblDisplayTax.Text = tax.ToString("c");//displaying tax received from CalcTotal method
                lblDisplayTotal.Text = total.ToString("c");//displaying received from CalcTotal method
            }
            
        }
        //method CalcTotal which receives subtotal and passes two out parameters tax and total
        private void CalcTotal(decimal subtotal, out decimal tax, out decimal total)
        {
            tax = subtotal * TAX;//calculate tax at 5%
            total = subtotal + tax;//calculate total
        }
        //method to clear the checkboxes and displayed prices when radio button selection is changed
        private void ClearExtras()
        {
            chkExtras1.Checked = false;//Clear add-on1
            chkExtras2.Checked = false;//Clear add-on2
            chkExtras3.Checked = false;//Clear add-on3
            lblDisplaySubtotal.Text = "";//Clear Subtotal diaplay
            lblDisplayTotal.Text = "";//Clear Total display
            lblDisplayTax.Text = "";//Clear Tax display
        }
        //method to reset to original values on click of reset button
        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearExtras();//call to function clear extras
            radHamBurger.Checked = true;//Defaulting radio button selection to Hamburger
        }
        //method to exit application on click of exit button
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
