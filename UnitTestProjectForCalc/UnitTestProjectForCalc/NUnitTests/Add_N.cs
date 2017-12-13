using System;
using CSharpCalculator;
using NUnit.Framework;

namespace UnitTestProjectForCalc.NUnitTests
{
    [TestFixture]
    [Parallelizable(ParallelScope.None)]
    public class Add_N:NUTestClass
    {
            Calculator calc = new Calculator();

            [Test]
            [TestCase("5.43", "4.11")]   
            [TestCase(5.43, 7.12)]
            [Description("Check that method returns a result from add of two input values")]
        public void CheckAdd(object firstNumber, object secondNumber)
        {
            double actResult = calc.Add(Double.Parse(firstNumber.ToString()), Double.Parse(secondNumber.ToString()));
            double expResult = Double.Parse(firstNumber.ToString()) + Double.Parse(secondNumber.ToString());

            Assert.AreEqual(expResult, actResult,$"{firstNumber}+{secondNumber}={expResult}, but was {actResult}");
        }

        [OneTimeSetUp]
        public override void BeforeSuite()
        {
            Console.WriteLine("Testing of Add has been started!");
        }

        [OneTimeTearDown]
        public override void AfterSuite()
        {
            Console.WriteLine("Testing of Add has been finished!");
        }
    }
    }
