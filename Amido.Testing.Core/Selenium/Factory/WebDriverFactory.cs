// Refactored .NET capability handling
// Documentation: https://help.crossbrowsertesting.com/faqs/testing/why-do-i-get-the-message-use-of-desiredcapabilities-has-been-deprecated-in-c/

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace Amido.Testing.Core.Selenium.Factory
{
    public class WebDriverFactory
    {
        public static IWebDriver GetWebDriver(BrowserStack browserStack = null)
        {
            return browserStack != null ? RemoteWebDriver(browserStack) : new ChromeDriver();
        }

        private static IWebDriver RemoteWebDriver(BrowserStack browserStack)
        {
            var caps = new RemoteSessionSettings();

            caps.AddMetadataSetting("browserstack.user", browserStack.User.Value);
            caps.AddMetadataSetting("browserstack.key", browserStack.Key.Value);
            caps.AddMetadataSetting("browserstack.debug", true);

            foreach (var key in browserStack.Environment.Value.AllKeys)
            {
                caps.AddMetadataSetting(key, browserStack.Environment.Value[key]);
            }

            return new RemoteWebDriver(browserStack.Url.Value, caps);
        }
    }
}
