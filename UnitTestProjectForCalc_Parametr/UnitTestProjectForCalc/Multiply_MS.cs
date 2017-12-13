using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpCalculator;

namespace UnitTestProjectForCalc
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
        [DataRow("5.43", "4.11")]   //String parameters
        [DataRow(5.43, 7.12)]       //Double parameters
        [DataRow(0, 5)]
        [DataRow(-0.1,0.58)]
        public void CheckMultiply(object firstNumber, object secondNumber)
        {

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
