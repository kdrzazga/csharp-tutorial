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
        const string chromePath = "C:\\Users\\kdrzazga\\webdriver\\chromedriver.exe";

        [SetUp]
        public void StartBrowser()
        {
            driver = new ChromeDriver(chromePath);
        }

        [Test]
        public void Test()
        {
            driver.Url = "http://www.google.com";
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
        }

    }
}
