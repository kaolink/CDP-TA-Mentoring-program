using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace UnitTestProjectForCalc.NUnitTests
{
    [TestFixture]
    abstract public class NUTestClass
    {
        [OneTimeSetUp]
        abstract public void BeforeSuite();

        [OneTimeTearDown]
        abstract public void AfterSuite();
    }
}