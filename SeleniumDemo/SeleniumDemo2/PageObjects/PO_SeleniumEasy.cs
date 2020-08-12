using OpenQA.Selenium;
using SeleniumWrapper;
using System.Collections.Generic;

namespace SeleniumDemo2.PageObjects
{
    public class PO_SeleniumEasy : BasePage
    {
        private readonly By treeMenuSelector = By.Id("treemenu");
        private readonly By menuItemSelector = By.TagName("li");
        private readonly By siteNameBannerSelector = By.Id("site-name");

        private static IWebElement treeMenu;
        private static IWebElement siteNameBanner;
        private static List<IWebElement> examplesList;
        
        public PO_SeleniumEasy(IWebDriver driver) : base(driver, "https://www.seleniumeasy.com/test/")
        {            
        }

        public override void Load()
        {
            base.Load();
            Log.Info("Loading page " + this.Url);
        }

        public override void FindElements()
        {
            treeMenu = LocatorHelper.QuietlyFindElements(this.Driver, treeMenuSelector, 5);
            siteNameBanner = LocatorHelper.QuietlyFindElements(this.Driver, siteNameBannerSelector, 5);
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
