using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpCalculator;

namespace UnitTestProjectForCalc
{
    [TestClass]
    public class Sqrt : TestClassMS
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
        [DataRow("-0.2")]
        [DataRow(1.1)]
        [DataRow(0.1)]
        [DataRow(0)]
        [DataRow(25)]
        public void CheckSqrt(object number)
        {
            double actResult = calc.Sqrt(Double.Parse(number.ToString()));
            double expResult = Math.Sqrt(Double.Parse(number.ToString()));

            Assert.AreEqual(expResult, actResult);
        }
    }
}
