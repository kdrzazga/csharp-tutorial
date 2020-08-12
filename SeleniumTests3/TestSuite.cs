// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System;
using SeleniumTests3.Driver;
using NUnit.Framework;
using SeleniumDemo2.PageObjects;
using OpenQA.Selenium;

namespace SeleniumTests3
{
    [TestFixture]
    public class TestClass
    {

        private PO_SeleniumEasy seleniumEasyPage;
        private IWebDriver driver;

        [OneTimeSetUp]
        public void GlobalSetup()
        {
            this.driver = new WebDriverFactory().CreateFirefoxDriver();
            this.seleniumEasyPage = new PO_SeleniumEasy(this.driver);
        }

        [SetUp]
        public void SetUp()
        {
            Console.Out.WriteLine("Opening Browser");
            this.seleniumEasyPage.Load();
        }

        [Test]
        public void TestSeleniumEasy()
        {
            
            Assert.That(42, Is.EqualTo(42), "Some useful error message");
        }

        [TearDown]
        public void TearDown()
        {
            Console.Out.WriteLine("Closing Browser");
            this.driver.Close();
        }
    }
}
