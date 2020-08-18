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
        protected readonly ILog Log = LogManager.GetLogger(typeof(BasePage));

        public BasePage(IWebDriver driver, string url)
        {
            this.Driver = driver;
            this.Url = url;
        }

        public virtual void Load()
        {
            this.Driver.Navigate().GoToUrl(this.Url);
        }

        public void SetupCookie(String cookie, String value)
        {
            var cookies = Utils.GetCookies(new Uri(this.Url));
            Console.Out.WriteLine(cookies);
            var tomorrowExpiry = DateTime.Now.AddDays(1.0);
            var ck = new Cookie("COOKIE", "node1", "https://www.seleniumeasy.com", "/", tomorrowExpiry);
            this.Driver.Manage().Cookies.AddCookie(ck);
        }

        public abstract void FindElements();
    }
}
