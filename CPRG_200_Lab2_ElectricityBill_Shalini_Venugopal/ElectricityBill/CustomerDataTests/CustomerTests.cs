/// <summary>
/// Code for creating validation of input entered by user 
/// Author: Sai Shalini Karaikatte Venugopal
/// Created Date: 07-JUL-2021
/// </summary>
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomerData.Tests
{
    /// <summary>
    /// Unit tests for calculate bill amount (GetBillMaount())
    /// </summary>
    [TestClass()]
    public class CustomerTests
    {
        /// <summary>
        /// Tests the bill amount when KWH used is positive
        /// </summary>   
        [TestMethod()]
        public void GetBillAmountPositiveUnits()
        {
            //arrange
            decimal units = 100;
            decimal bill = 19;
            decimal actualbill;
            //act            
            actualbill = Customer.GetBillAmount(units);
            //assert
            Assert.AreEqual(bill, actualbill);
        }
        /// <summary>
        /// Tests the bill amount when KWH used is negative
        /// </summary>
        [TestMethod()]
        public void GetBillAmountNegativeUnits()
        {
            //arrange
            decimal units = -100;
            decimal bill = 0;
            decimal actualbill;
            //act            
            actualbill = Customer.GetBillAmount(units);
            //assert
            Assert.AreEqual(bill, actualbill);
        }
        /// <summary>
        /// Tests the bill amount when KWH used is zero
        /// </summary>
        [TestMethod()]
        public void GetBillAmountZeroUnits()
        {
            //arrange
            decimal units = 0;
            decimal bill = 12;
            decimal actualbill;
            //act            
            actualbill = Customer.GetBillAmount(units);
            //assert
            Assert.AreEqual(bill, actualbill);
        }
    }
}