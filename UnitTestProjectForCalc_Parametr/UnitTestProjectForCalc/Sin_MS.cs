using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpCalculator;

namespace UnitTestProjectForCalc
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
        [DataRow("0")]
        [DataRow(89.9)]
        [DataRow(90.1)]
        [DataRow(90)]
        [DataRow(-179.9)]
        [DataRow(-180)]
        [DataRow(-180.1)]
        [DataRow(360)]
        [DataRow(360.1)]

        public void CheckSin(object angle)
        {
            double actResult = calc.Sin(angle);
            double expResult = Math.Sin((Convert.ToDouble(angle)));

            Assert.AreEqual(expResult, actResult);
        }
    }
}
