using System.Collections.Specialized;
using Amido.Testing.Core.ValueObjects;

namespace Amido.Testing.Core.Selenium.Factory
{
    public class BrowserStack
    {
        public BrowserStack(string user, string key, NameValueCollection environment, string url)
        {
            User = BrowserStackUser.Create(user);
            Key = BrowserStackKey.Create(key);
            Environment = BrowserStackEnvironment.Create(environment);
            Url = BrowserStackUrl.Create(url);
        }

        public BrowserStackUser User { get; }

        public BrowserStackKey Key { get; }

        public BrowserStackEnvironment Environment { get; }

        public BrowserStackUrl Url { get; }


        public static NameValueCollection Browser_IE_Defaults => new NameValueCollection
        {
            {"browser","IE"},
            {"browser_version","11.0"},
            {"os","Windows"},
            {"os_version", "10"},
            {"resolution","1024x768"}
        };



        public static NameValueCollection Browser_Firefox_Defaults => new NameValueCollection
        {
            {"browser","Firefox"},
            {"browser_version","53.0"},
            {"os","Windows"},
            {"os_version", "10"},
            {"resolution","1024x768"}
        };

        public static NameValueCollection Browser_EDGE_Defaults => new NameValueCollection
        {
            {"browser","Edge"},
            {"browser_version","14.0"},
            {"os","Windows"},
            {"os_version","10"},
            {"resolution","1024x768"}
        };

        public static NameValueCollection Browser_Chrome_Defaults => new NameValueCollection
        {
            {"browser","chrome"},
            {"browser_version","61.0"},
            {"os","Windows"},
            {"os_version","10"},
            {"resolution","1024x768"}
        };
    }
}
