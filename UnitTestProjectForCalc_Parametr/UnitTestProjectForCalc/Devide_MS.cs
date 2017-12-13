using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpCalculator;

namespace UnitTestProjectForCalc
{
    [TestClass]
    public class Devide_MS:TestClassMS
    {

        Calculator calc = new Calculator();

        [TestCleanup]
        public override void Postcondition()
        {
            Console.WriteLine("Testing of Devide has been finished!");
        }

        [TestInitialize]
        public override void Precondition()
        {
            Console.WriteLine("Testing of Devide has been started!");
        }

        [TestMethod]
        [DataRow("5.43", "-4.11")]   //String parameters    
        [DataRow(5, 8)]            //Double parameters
        [DataRow(6,0)]
        [DataRow(0,0)]
        [DataRow(1, 0.12)]
        public void CheckDev(object firstNumber, object secondNumber)
        {

            double actResult = calc.Divide(Double.Parse(firstNumber.ToString()), Double.Parse(secondNumber.ToString()));
            double expResult = Double.Parse(firstNumber.ToString())/Double.Parse(secondNumber.ToString());

            Assert.AreEqual(expResult, actResult);
        }
    }
}
