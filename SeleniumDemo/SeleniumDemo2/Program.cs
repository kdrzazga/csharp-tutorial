using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using SeleniumWrapper;
using SeleniumDemo2.PageObjects;
using NUnit.Framework;

namespace SeleniumDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            var driver = new FirefoxDriver("C:\\Users\\kdrzazga\\webdriver");
            Utils.MaximizeWindow(driver);

            var seleniumEasyPage = new PO_SeleniumEasy(driver);
            seleniumEasyPage.Load();

            Assert.That(driver.Title.Contains("Selenium Easy"));
            Assert.That(driver.Title.Contains("Selenium Webdriver Online"));

            seleniumEasyPage.ClickSiteNameBanner();
            Assert.That(driver.Title.Contains("Selenium Easy"));
            Assert.That(driver.Title.Contains("Learn Selenium"));

            driver.Quit();
        }
    }
}
