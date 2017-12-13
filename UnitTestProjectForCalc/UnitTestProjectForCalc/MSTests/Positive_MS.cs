using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpCalculator;

namespace UnitTestProjectForCalc.MSTests
{
    [TestClass]
    public class Positive_MS:TestClassMS
    {
        Calculator calc = new Calculator();

        [TestCleanup]
        public override void Postcondition()
        {
            Console.WriteLine("Testing of Positive has been finished!");
        }

        [TestInitialize]
        public override void Precondition()
        {
            Console.WriteLine("Testing of Positive has been started!");
        }

        [TestMethod]
        public void CheckisPositive()
        {
            object number = -50;
            bool expResult = false;                                  //Arrange
            if (Double.Parse(number.ToString()) > 0)
            {
                expResult = true;
            }
            else
            {
                expResult = false;
            }

            bool actResult = calc.isPositive(number);              //Action

            Assert.AreEqual(expResult, actResult);                 //Assert 
        }
    }
}
