using System;
using OpenQA.Selenium;

namespace SeleniumWrapper
{
    public class BasePage : WebDrivable
    {

        public IWebDriver Driver { get; set; }

        public BasePage(IWebDriver driver)
        {
            this.Driver = driver;
        }

        void WebDrivable.FindElements()
        {
            throw new NotImplementedException();
        }
    }
}
