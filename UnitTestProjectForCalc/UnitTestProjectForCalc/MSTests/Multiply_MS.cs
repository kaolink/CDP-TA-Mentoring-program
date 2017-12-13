using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpCalculator;

namespace UnitTestProjectForCalc.MSTests
{
    [TestClass]
    public class Multiply_MS : TestClassMS
    {
        Calculator calc = new Calculator();

        [TestInitialize]
        public override void Precondition()
        {
            Console.WriteLine("Testing of Multiply has been started!");
        }

        [TestMethod]
        public void CheckMultiply()
        {
            object firstNumber = "1.95";
            object secondNumber = 5.67;

            double actResult = calc.Multiply(Double.Parse(firstNumber.ToString()), Double.Parse(secondNumber.ToString()));
            double expResult = Double.Parse(firstNumber.ToString()) * Double.Parse(secondNumber.ToString());

            Assert.AreEqual(expResult, actResult);
        }

        [TestCleanup]
        public override void Postcondition()
        {
            Console.WriteLine("Testing of Multiply has been finished!");
        }
    }
}
