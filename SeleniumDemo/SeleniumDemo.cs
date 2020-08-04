using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDemo
{
    class SeleniumDemo
    {
        IWebDriver driver;
        const string chromePath = "C:\\Program Files (x86)\\Google\\Chrome\\Application";

        [SetUp]
        public void StartBrowser()
        {
            driver = new ChromeDriver(chromePath);
        }

        [Test]
        public void Test()
        {
            driver.Url = "http://www.google.co.in";
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }

    }
}
