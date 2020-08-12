using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTests3.Driver
{
    public class WebDriverFactory
    {
        public FirefoxDriver CreateFirefoxDriver()
        {
            return new FirefoxDriver("C:\\Users\\kdrzazga\\webdriver");
        }
    }
}
