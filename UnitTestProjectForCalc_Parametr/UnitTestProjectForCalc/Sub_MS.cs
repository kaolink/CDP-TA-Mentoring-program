using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpCalculator;

namespace UnitTestProjectForCalc
{
    [TestClass]
    public class Sub_MS: TestClassMS
    {
        Calculator calc = new Calculator();

        [TestCleanup]
        public override void Postcondition()
        {
            Console.WriteLine("Testing of Sub has been finished!");
        }

        [TestInitialize]
        public override void Precondition()
        {
            Console.WriteLine("Testing of Sub has been started!");
        }

        [TestMethod]
        [DataRow("1854", "-254")]   //String parameters
        [DataRow(1, 5)]       //Double parameters
        public void CheckSub(object firstNumber, object secondNumber)
        {

            double actResult = calc.Sub(Double.Parse(firstNumber.ToString()), Double.Parse(secondNumber.ToString()));
            double expResult = Double.Parse(firstNumber.ToString()) - Double.Parse(secondNumber.ToString());

            Assert.AreEqual(expResult, actResult);
        }
    }
}
