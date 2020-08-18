using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace SeleniumWrapper
{
    public class LocatorHelper
    {
        public static IWebElement QuietlyFindElement(IWebDriver driver, By locator)
        {
            return QuietlyFindElement(driver, locator, 5);
        }

        public static IWebElement QuietlyFindElement(IWebDriver driver, By locator, int timeout)
        {            
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
            Func<IWebDriver, IWebElement> elementLocated = SeleniumExtras.WaitHelpers
                .ExpectedConditions
                .ElementIsVisible(locator);
            IWebElement element = null;
            try
            {
                element = wait.Until(elementLocated);
            }
            catch (Exception e)
            {
                Console.Out.Write("Error " + e.Message + " Couldn't locate "+locator.ToString());
            }
            return element;
        }

        public static IReadOnlyCollection<IWebElement> QuietlyFindElements(IWebDriver driver, By locator, int timeout)
        {
            IReadOnlyCollection<IWebElement> elements;

            try {
                elements = driver.FindElements(locator);
                //logger.log("Found " + elements.size() + " elements.");
                return elements;

            }
            catch (NoSuchElementException e)
                {
                Console.Out.Write("Error " + e.Message + " Couldn't locate " + locator.ToString());
                return null;
                }
        }
    }
}
