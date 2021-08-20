using System;
using System.Windows.Forms;


namespace BillGenerator
{
    /// <summary>
    /// a repository of validation methods
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// validates if textbox has something in it
        /// </summary>
        /// <param name="tb">text box to validate</param>
        /// <param name="name">name for error message</param>
        /// <returns>true if valid, and false if not</returns>
        public static bool IsPresent(TextBox tb, string name)
        {
            bool isValid = true; // "innocent until proven guilty"
            if (tb.Text == "") // bad
            {
                isValid = false;
                MessageBox.Show(name + " is required", "Input error");
                tb.Focus();
            }        
            return isValid;
        }     
        
        /// <summary>
        /// validates if textbox contains non-negative decimal
        /// </summary>
        /// <param name="tb">text box to validate</param>
        /// <param name="name">name for error message</param>
        /// <returns>true if valid, and false if not</returns>
        public static bool IsNonNegativeDecimal(TextBox tb, string name)
        {
            bool isValid = true; // "innocent until proven guilty"
            decimal value;
            if (!Decimal.TryParse(tb.Text, out value)) //not an int
            {
                isValid = false;
                MessageBox.Show(name + " has to be a number", "Input error");
                tb.SelectAll();
                tb.Focus();
            }
            else if (value < 0)// cannot be negative
            {
                isValid = false;
                MessageBox.Show(name + " has to be positive or zero", "Input error");
                tb.SelectAll();
                tb.Focus();
            }
            return isValid;
        }
    } // class
}// namespace
