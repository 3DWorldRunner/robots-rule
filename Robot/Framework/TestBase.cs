using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Robot.Framework
{
    public class TestBase : Driver
    {
        public TestBase()
        {
        }

        [OneTimeSetUp]
        public void FirstSetup()
        {

        }

        [SetUp]
        public void TestSetup()
        {
            driver.Navigate().GoToUrl("https://www.google.com");
        }

        [TearDown]
        public void TestTearDown()
        {
            driver.Quit();
        }

        [OneTimeTearDown]
        public void FinalTearDown()
        {

        }
    }
}
