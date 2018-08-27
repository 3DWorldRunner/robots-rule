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
    public class TestBase : WebDriver
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
            Driver.Navigate().GoToUrl("https://www.google.com");
        }

        [TearDown]
        public void TestTearDown()
        {
            Driver.Quit();
            Driver = null;
        }

        [OneTimeTearDown]
        public void FinalTearDown()
        {

        }
    }
}
