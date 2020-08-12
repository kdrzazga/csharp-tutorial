using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;


namespace SeleniumWrapper
{
    public class LocatorHelper
    {

        public static IWebElement QuietlyFindElements(IWebDriver driver, By locator, int timeout)
        {            
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
            Func<IWebDriver, IWebElement> elementLocated = SeleniumExtras.WaitHelpers
                .ExpectedConditions
                .ElementIsVisible(locator);
            IWebElement element = wait.Until(elementLocated);
            return element;
        }

    }
}
