using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using Robot.Framework;

namespace Robot.Tests
{
    [TestFixture]
    public class SuperClicker : TestBase
    {

        [Test]
        public void WinAtClicking()
        {
            driver.Navigate().GoToUrl("http://orteil.dashnet.org/cookieclicker/");
            System.Threading.Thread.Sleep(5000);
            Stopwatch timer = new Stopwatch();
            timer.Start();

            var cookie = driver.FindElement(By.Id("bigCookie"));
            while (timer.Elapsed < TimeSpan.FromDays(5))
            {
                try
                {
                    var products = driver.FindElements(By.CssSelector(".enabled[id^=\"product\"]"));
                    if (products.Any())
                    {
                        products.Last().Click();
                    }
                    else
                    {
                        cookie.Click();
                    }
                }
                catch (NoSuchElementException)
                {
                    cookie.Click();
                }
            }
            System.Threading.Thread.Sleep(5000);
            var score = driver.FindElement(By.Id("cookies")).Text;
            Console.WriteLine(score);
        }

        [Test]
        public void WinBetterAtTyping()
        {
            driver.Navigate().GoToUrl("https://www.typingtest.com/test.html?minutes=1&textfile=oz.txt");
            System.Threading.Thread.Sleep(5000);
            var typeHere = driver.FindElement(By.Id("test-edit-area"));
            var typeThese = driver.FindElements(By.CssSelector(".test-text-area-font > span"));
            var typeThis = new StringBuilder();
            foreach (var type in typeThese)
            {
                typeThis.Append(type.Text + " ");
            }
            Stopwatch timer = new Stopwatch();
            timer.Start();
            while (timer.Elapsed < TimeSpan.FromMinutes(1))
            {
                typeHere.SendKeys(typeThis.ToString());
            }
            System.Threading.Thread.Sleep(5000);
            var score = driver.FindElement(By.ClassName("amount")).Text;
            Console.WriteLine(score);
        }

    }
}
