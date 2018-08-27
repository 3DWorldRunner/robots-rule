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
            System.Threading.Thread.Sleep(1000);
            Stopwatch timer = new Stopwatch();
            timer.Start();

            var cookie = driver.FindElement(By.Id("bigCookie"));
            while (timer.Elapsed < TimeSpan.FromMinutes(5))
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
            System.Threading.Thread.Sleep(1000);
            var score = driver.FindElement(By.Id("cookies")).Text;
            Console.WriteLine(score);
        }

        [Test]
        public void WinBetterAtClicking()
        {
            driver.Navigate().GoToUrl("http://orteil.dashnet.org/cookieclicker/");
            System.Threading.Thread.Sleep(1000);
            Stopwatch timer = new Stopwatch();
            timer.Start();

            var cookie = driver.FindElement(By.Id("bigCookie"));
            while (timer.Elapsed < TimeSpan.FromMinutes(5))
            {
                try
                {
                    var upgrades = driver.FindElements(By.CssSelector(".enabled[id^=\"upgrade\"]"));
                    if (upgrades.Any())
                    {
                        upgrades.Last().Click();
                    }
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
            System.Threading.Thread.Sleep(1000);
            var score = driver.FindElement(By.Id("cookies")).Text;
            Console.WriteLine(score);
        }

    }
}
