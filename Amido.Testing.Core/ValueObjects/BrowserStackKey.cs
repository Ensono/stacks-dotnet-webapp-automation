using System;

namespace Amido.Testing.Core.ValueObjects
{
    public class BrowserStackKey
    {
        public string Value { get; }

        private BrowserStackKey(string key)
        {
            if (string.IsNullOrWhiteSpace(key))
                throw new ArgumentNullException(nameof(key));

            Value = key;
        }

        public static BrowserStackKey Create(string key) => new BrowserStackKey(key);

        public static implicit operator string(BrowserStackKey key) => key.Value;
    }
}
