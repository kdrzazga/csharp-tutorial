using OpenQA.Selenium;
using SeleniumWrapper;

namespace SeleniumTests3.PageObjects
{
    public class SeleniumEasyBasePage : BasePage
    {
        private readonly By msgCloseSelector = By.Id("at-cv-lightbox-close");

        private static IWebElement msgClose;

        public SeleniumEasyBasePage(IWebDriver driver, string url) : base(driver, url)
        {
        }

        public void AcceptCookies()
        {
            if (msgClose != null)
                msgClose.Click();
        }

        public override void FindElements()
        {
            msgClose = LocatorHelper.QuietlyFindElement(Driver, msgCloseSelector);
        }
    }
}
