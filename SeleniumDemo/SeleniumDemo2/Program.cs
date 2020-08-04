using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;

namespace SeleniumDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver("C:\\Users\\kdrzazga\\webdriver");
            driver.Manage().Window.Maximize();

            //Go to Google
            driver.Navigate().GoToUrl("http://www.google.com");
        }
    }
}
