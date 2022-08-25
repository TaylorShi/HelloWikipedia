using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Wikipedia.Helper
{
    internal class UrlHelper
    {
        /// <summary>
        /// 合法的URI字符，依据RFC3986: https://tools.ietf.org/html/rfc3986#section-2.3
        /// </summary>
        private const string _validUrlCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._~";

        private static readonly HashSet<byte> _validUrlLookup = new HashSet<byte>(BuildLookup(_validUrlCharacters));

        private static IEnumerable<byte> BuildLookup(string charList)
        {
            foreach (char c in charList)
            {
                string escaped = Uri.EscapeUriString(c.ToString(CultureInfo.InvariantCulture));
                if (escaped.Length == 1 && escaped[0] == c)
                    yield return (byte)c;
            }
        }

        public static string CreateQueryString(IEnumerable<KeyValuePair<string, string>> parameters, bool encode = true, bool outputEqualOnEmpty = false)
        {
            StringBuilder sb = new StringBuilder();

            foreach (KeyValuePair<string, string> item in parameters)
            {
                if (sb.Length > 0)
                    sb.Append('&');

                string encodedKey = encode ? UrlEncode(item.Key) : item.Key;

                if (string.IsNullOrEmpty(item.Value))
                {
                    sb.Append(encodedKey);

                    if (outputEqualOnEmpty)
                        sb.Append('=');
                }
                else
                    sb.Append(encodedKey).Append('=').Append(encode ? UrlEncode(item.Value) : item.Value);
            }

            return sb.ToString();
        }

        public static string UrlEncode(string data)
        {
            StringBuilder sb = new StringBuilder();

            foreach (byte symbol in Encoding.UTF8.GetBytes(data))
            {
                if (_validUrlLookup.Contains(symbol))
                    sb.Append((char)symbol);
                else
                    sb.Append('%').AppendFormat(CultureInfo.InvariantCulture, "{0:X2}", symbol);
            }

            return sb.ToString();
        }
    }
}
