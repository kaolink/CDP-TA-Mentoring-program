using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpCalculator;

namespace UnitTestProjectForCalc
{
    [TestClass]
    public class Negative_MS : TestClassMS
    {
        Calculator calc = new Calculator();

        [TestCleanup]
        public override void Postcondition()
        {
            Console.WriteLine("Testing of Negative has been finished!");
        }

        [TestInitialize]
        public override void Precondition()
        {
            Console.WriteLine("Testing of Negative has been started!");
        }

          [TestMethod]
          [DataTestMethod]
          [DataRow("0.1")]
          [DataRow(0)]
          [DataRow(-0.1)]
        public void CheckisNegative(object number)
        {
            bool expResult = false;                                  //Arrange
            if (Double.Parse(number.ToString()) < 0)
            {
                expResult = true;
            }
            else
            {
                expResult = false;
            }

            bool actResult = calc.isNegative(Double.Parse(number.ToString()));              //Action

            Assert.AreEqual(expResult, actResult);                 //Assert 
        }
    }
}
