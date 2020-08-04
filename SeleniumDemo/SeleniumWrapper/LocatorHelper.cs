using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;


namespace SeleniumWrapper
{
    class LocatorHelper
    {

        public static IWebElement QuietlyFindElements(IWebDriver driver, By locator, int timeout)
        {
            IWebElement element = null;
            ExpectedConditions elementLocated;
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
            /*elementLocated = ExpectedConditions.ElementExists(locator);
            wait.Until(elementLocated);
            /*TODO*/
            return element;
        }

    }
}
