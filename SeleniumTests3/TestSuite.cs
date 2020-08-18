using System.Collections;
using System;
using SeleniumTests3.Driver;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumTests3.PageObjects;

namespace SeleniumTests3
{
    [TestFixture]
    public class TestClass
    {

        private PO_SeleniumEasy seleniumEasyPage;
        private PO_BasicFirstFormDemo basicFirstFormDemo;
        private IWebDriver driver;

        [OneTimeSetUp]
        public void GlobalSetup()
        {
            this.driver = new WebDriverFactory().CreateFirefoxDriver();
            this.seleniumEasyPage = new PO_SeleniumEasy(this.driver);
            this.basicFirstFormDemo = new PO_BasicFirstFormDemo(this.driver);
        }

        [SetUp]
        public void SetUp()
        {
            
        }

        [Test]
        public void TestSeleniumEasy()
        {
            Console.Out.WriteLine("Opening Browser");
            this.seleniumEasyPage.Load();
            this.seleniumEasyPage.FindElements();
            this.seleniumEasyPage.ClickSiteNameBanner();
        }

        [Test]
        public void TestBasicFirstFormDemo()
        {
            Console.Out.WriteLine("Opening Browser");
            this.basicFirstFormDemo.Load();
            this.basicFirstFormDemo.FindElements();

            string userText = "Time and tide wait for no man." +
                "The guilty think all talk is of themselves." +
                "The life so short, the crafts so long to learn." +
                "And gladly wolde he lerne, and gladly teche." +
                "People can die of mere imagination." +
                "He was as fresh as is the month of May.";

            this.basicFirstFormDemo.EnterUserText(userText);
            this.basicFirstFormDemo.ClickShowMessage();

            var text = this.basicFirstFormDemo.GetDisplayText();

            Assert.IsTrue(text
                .EndsWith(userText));
        }

        [TearDown]
        public void TearDown()
        {
            Console.Out.WriteLine("Closing Browser");
            //this.driver.Close();
        }
    }
}
