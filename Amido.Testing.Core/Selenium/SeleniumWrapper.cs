using System;
using Amido.Testing.Core.Selenium.Factory;
using OpenQA.Selenium;

namespace Amido.Testing.Core.Selenium
{
    public class SeleniumWrapper
    {
        private IWebDriver webDriver;

        public void Setup(BrowserStack browserStack = null)
        {
            webDriver = WebDriverFactory.GetWebDriver(browserStack);
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public IWebDriver Instance()
        {
            return webDriver;
        }

        public void Navigate(string url)
        {
            webDriver.Navigate().GoToUrl(url);
        }

        public void CleanUp()
        {
            webDriver.Manage().Cookies.DeleteAllCookies();
        }

        public void TearDown()
        {
            webDriver.Close();
            webDriver.Quit();
        }
    }
}
