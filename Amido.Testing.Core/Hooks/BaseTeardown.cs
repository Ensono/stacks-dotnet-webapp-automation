using Amido.Testing.Core.Selenium;

namespace Amido.Testing.Core.Hooks
{
    public abstract class BaseTeardown
    {
        protected readonly SeleniumWrapper SeleniumWrapper;

        protected BaseTeardown(SeleniumWrapper seleniumWrapper)
        {
            SeleniumWrapper = seleniumWrapper;
        }

        public virtual void AfterUiScenario()
        {
            SeleniumWrapper.CleanUp();
            SeleniumWrapper.TearDown();
        }
    }
}
