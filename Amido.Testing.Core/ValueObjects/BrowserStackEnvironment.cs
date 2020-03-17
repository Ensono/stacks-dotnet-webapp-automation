using System.Collections.Specialized;

namespace Amido.Testing.Core.ValueObjects
{
    public class BrowserStackEnvironment
    {
        public NameValueCollection Value { get; }

        private BrowserStackEnvironment(NameValueCollection environment)
        {
            Value = environment;
        }

        public static BrowserStackEnvironment Create(NameValueCollection environment) => new BrowserStackEnvironment(environment);
    }
}
