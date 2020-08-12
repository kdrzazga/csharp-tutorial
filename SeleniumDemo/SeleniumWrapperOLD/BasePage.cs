using System;
using log4net;
using log4net.Config;
using OpenQA.Selenium;

namespace SeleniumWrapper
{
    public abstract class BasePage : IWebDrivable
    {

        public IWebDriver Driver { get; set; }
        protected readonly string Url;
        protected static readonly ILog Log = LogManager.GetLogger(typeof(BasePage));

        public BasePage(IWebDriver driver, string url)
        {
            this.Driver = driver;
            this.Url = url;
        }

        public virtual void Load()
        {
            this.Driver.Navigate().GoToUrl(this.Url);
        }

        public abstract void FindElements();
    }
}
