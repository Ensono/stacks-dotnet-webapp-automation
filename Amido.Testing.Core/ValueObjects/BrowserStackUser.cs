using System;

namespace Amido.Testing.Core.ValueObjects
{
    public class BrowserStackUser
    {
        public string Value { get; }

        private BrowserStackUser(string user)
        {
            if (string.IsNullOrWhiteSpace(user))
                throw new ArgumentNullException(nameof(user));

            Value = user;
        }

        public static BrowserStackUser Create(string user) => new BrowserStackUser(user);

        public static implicit operator string(BrowserStackUser user) => user.Value;
    }
}