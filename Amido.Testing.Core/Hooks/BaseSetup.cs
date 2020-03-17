using Amido.Testing.Core.Selenium;
using Amido.Testing.Core.Selenium.Factory;

namespace Amido.Testing.Core.Hooks
{
    public abstract class BaseSetup
    {
        protected BrowserStack remote = null;
        protected readonly SeleniumWrapper SeleniumWrapper;

        protected BaseSetup(SeleniumWrapper seleniumWrapper)
        {
            SeleniumWrapper = seleniumWrapper;
        }
        
        public virtual void BeforeScenario()
        {
            SeleniumWrapper.Setup(remote);
        }
    }
}
