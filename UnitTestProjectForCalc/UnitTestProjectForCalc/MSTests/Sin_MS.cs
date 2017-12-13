using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpCalculator;

namespace UnitTestProjectForCalc.MSTests
{
    [TestClass]
    public class Sin_MS:TestClassMS
    {
        Calculator calc = new Calculator();

        [TestCleanup]
        public override void Postcondition()
        {
            Console.WriteLine("Testing of Sin has been finished!");
        }

        [TestInitialize]
        public override void Precondition()
        {
            Console.WriteLine("Testing of Sin has been started!");
        }

        [TestMethod]
        public void CheckSin()
        {
            object angle = "-650";
            double actResult = calc.Sin(angle);
            double expResult = Math.Sin((Convert.ToDouble(angle)));

            Assert.AreEqual(expResult, actResult);
        }
    }
}
