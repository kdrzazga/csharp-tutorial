using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using Cookie = System.Net.Cookie;

namespace SeleniumWrapper
{
    public class Utils
    {
        public static void MaximizeWindow(IWebDriver driver)
        {
            driver.Manage().Window.Position = new Point(0, 0);
            var screenSize = Screen.PrimaryScreen.Bounds;
            var size = new Size(screenSize.Width, screenSize.Height);            
            driver.Manage().Window.Size = size;
        }

        public static CookieCollection GetCookies(Uri uri)
        {
            CookieContainer cookies = new CookieContainer();
            HttpClientHandler handler = new HttpClientHandler();
            handler.CookieContainer = cookies;

            HttpClient client = new HttpClient(handler);
            HttpResponseMessage response = client.GetAsync(uri.AbsoluteUri).Result;
            return cookies.GetCookies(uri);

        }
    }
}
