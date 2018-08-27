using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Robot.Framework
{
    public class WebDriver
    {
        public IWebDriver Driver
        {
            get
            {
                if (_driver == null)
                {
                    _driver = new ChromeDriver();
                    _driver.Manage().Window.Maximize();
                }

                return _driver;
            }
            set => _driver = value;
        }
        private static IWebDriver _driver;
    }
}
