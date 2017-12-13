using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpCalculator;

namespace UnitTestProjectForCalc.MSTests
{
    [TestClass]
    public class Sqrt_MS : TestClassMS
    {
        Calculator calc = new Calculator();

        [TestCleanup]
        public override void Postcondition()
        {
            Console.WriteLine("Testing of Sqrt has been finished!");
        }

        [TestInitialize]
        public override void Precondition()
        {
            Console.WriteLine("Testing of Sqrt has been started!");
        }

        [TestMethod]
        public void CheckSqrt()
        {
            object number = "-0.5";
            double actResult = calc.Sqrt(Double.Parse(number.ToString()));
            double expResult = Math.Sqrt(Double.Parse(number.ToString()));

            Assert.AreEqual(expResult, actResult);
        }
    }
}
