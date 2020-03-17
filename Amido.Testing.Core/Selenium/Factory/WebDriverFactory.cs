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
            var caps = new DesiredCapabilities();
            caps.SetCapability("browserstack.user", browserStack.User.Value);
            caps.SetCapability("browserstack.key", browserStack.Key.Value);
            caps.SetCapability("browserstack.debug", true);

            foreach (var key in browserStack.Environment.Value.AllKeys)
            {
                caps.SetCapability(key, browserStack.Environment.Value[key]);
            }

            return new RemoteWebDriver(browserStack.Url.Value, caps);
        }
    }
}
