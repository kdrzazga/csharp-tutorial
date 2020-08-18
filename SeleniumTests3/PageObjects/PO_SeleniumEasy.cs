using OpenQA.Selenium;
using SeleniumWrapper;
using System.Collections.Generic;

namespace SeleniumTests3.PageObjects
{
    public class PO_SeleniumEasy : SeleniumEasyBasePage
    {
        private readonly By treeMenuSelector = By.Id("treemenu");
        private readonly By menuItemSelector = By.TagName("li");
        private readonly By siteNameBannerSelector = By.Id("site-name");

        private static IWebElement treeMenu;
        private static IWebElement siteNameBanner;
        private static IReadOnlyCollection<IWebElement> examplesList;
        
        public PO_SeleniumEasy(IWebDriver driver) 
            : base(driver, "https://www.seleniumeasy.com/test/")
        {            
        }

        public override void Load()
        {
            base.Load();
            Log.Info("Loading page " + this.Url);
            base.SetupCookie("ala", "ma kota");
        }

        public override void FindElements()
        {
            base.FindElements();
            base.AcceptCookies();
            treeMenu = LocatorHelper.QuietlyFindElement(this.Driver, treeMenuSelector, 5);
            siteNameBanner = LocatorHelper.QuietlyFindElement(this.Driver, siteNameBannerSelector, 5);
            examplesList = LocatorHelper.QuietlyFindElements(this.Driver, menuItemSelector, 5);
        }

        public void ClickSiteNameBanner()
        {
            if (siteNameBanner != null)
                siteNameBanner.Click();
            else
                Log.Error("Cannot click Banner with Site Name");
        }
    }
}
