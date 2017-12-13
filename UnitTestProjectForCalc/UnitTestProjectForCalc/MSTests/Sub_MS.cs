using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpCalculator;

namespace UnitTestProjectForCalc.MSTests
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
        public void CheckSub()
        {
            object firstNumber = "1.95";
            object secondNumber = 5.67;

            double actResult = calc.Sub(Double.Parse(firstNumber.ToString()), Double.Parse(secondNumber.ToString()));
            double expResult = Double.Parse(firstNumber.ToString()) - Double.Parse(secondNumber.ToString());

            Assert.AreEqual(expResult, actResult);
        }
    }
}
