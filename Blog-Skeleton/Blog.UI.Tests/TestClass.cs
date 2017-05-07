using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Blog.UI.Tests
{
    [TestFixture]
    public class UITests
    {
        [Test]
        public void CheckSiteLoad()
        {
            IWebDriver driver = Host.Instance.Application.Browser;
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

            driver.Navigate().GoToUrl(@"http://localhost:60639/Article/List");
            Thread.Sleep(2000);
            var logo = driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/a"));
            //wait.Until(w => w.
            Assert.AreEqual("SOFTUNI BLOG", logo.Text);
        }
    }
}
