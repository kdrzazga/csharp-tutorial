using OpenQA.Selenium;
using SeleniumWrapper;

namespace SeleniumTests3.PageObjects
{
    public class PO_BasicFirstFormDemo : SeleniumEasyBasePage
    {

        private readonly By userMsgTextboxSelector = By.Id("user-message");
        private readonly By showMsgButtonSelector = By.XPath("//button[contains(text(), 'Show Message')]");
        private readonly By displaySpanSelector = By.Id("display");

        private static IWebElement userMsgTextbox;
        private static IWebElement showMsgButton;
        private static IWebElement displaySpan;

        public PO_BasicFirstFormDemo(IWebDriver driver) 
            : base(driver, "https://www.seleniumeasy.com/test/basic-first-form-demo.html")
        {            
        }

        public override void FindElements()
        {
            base.FindElements();
            base.AcceptCookies();
            userMsgTextbox = LocatorHelper.QuietlyFindElement(this.Driver, userMsgTextboxSelector,15);
            showMsgButton = LocatorHelper.QuietlyFindElement(this.Driver, showMsgButtonSelector, 15);
            displaySpan = LocatorHelper.QuietlyFindElement(this.Driver, displaySpanSelector, 15);
        }

        public void EnterUserText(string text)
        {
            userMsgTextbox.SendKeys(text);
        }

        public string GetDisplayText()
        {
            return displaySpan != null
                ? displaySpan.Text
                : "";
        }

        public void ClickShowMessage()
        {
            showMsgButton.Click();
        }
    }
}
