using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Robot.Framework
{
    public class Driver
    {
        static Driver()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }
        protected static IWebDriver driver;
    }
}
