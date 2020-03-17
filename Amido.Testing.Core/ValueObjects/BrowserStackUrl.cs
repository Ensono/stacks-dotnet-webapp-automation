using System;

namespace Amido.Testing.Core.ValueObjects
{
    public class BrowserStackUrl
    {
        public Uri Value { get; }

        private BrowserStackUrl(string url)
        {
            if (string.IsNullOrWhiteSpace(url))
                throw new ArgumentNullException(nameof(url));

            if (!Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute))
                throw new ArgumentNullException(nameof(url));


            Value = new Uri(url);
        }

        public static BrowserStackUrl Create(string url) => new BrowserStackUrl(url);

        public static implicit operator string(BrowserStackUrl url) => url.Value.ToString();
    }
}
