using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpCalculator;

namespace UnitTestProjectForCalc.MSTests
{
    [TestClass]
    public class Divide_MS:TestClassMS
    {

        Calculator calc = new Calculator();

        [TestCleanup]
        public override void Postcondition()
        {
            Console.WriteLine("Testing of Divide has been finished!");
        }

        [TestInitialize]
        public override void Precondition()
        {
            Console.WriteLine("Testing of Divide has been started!");
        }

        [TestMethod]
        public void CheckDiv()
        {
            object firstNumber = "5.17";
            object secondNumber = 8.19;

            double actResult = calc.Divide(Double.Parse(firstNumber.ToString()), Double.Parse(secondNumber.ToString()));
            double expResult = Double.Parse(firstNumber.ToString())/Double.Parse(secondNumber.ToString());

            Assert.AreEqual(expResult, actResult);
        }
    }
}
