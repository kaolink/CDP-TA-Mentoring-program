using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpCalculator;

namespace UnitTestProjectForCalc.MSTests
{
    [TestClass]
    public class Cos_MS : TestClassMS
    {
        Calculator calc = new Calculator();

        [TestCleanup]
        public override void Postcondition()
        {
            Console.WriteLine("Testing of Cos has been finished!");
        }

        [TestInitialize]
        public override void Precondition()
        {
            Console.WriteLine("Testing of Cos has been started!");
        }

        [TestMethod]
        public void CheckCos()
        {
            object angle = "15";

            double actResult = calc.Cos(Double.Parse(angle.ToString()));
            double expResult = Math.Cos(Double.Parse(angle.ToString()));

            Assert.AreEqual(expResult, actResult);
        }
    }
}
