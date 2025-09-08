using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace PointsBet_Backend_Online_Code_Test
{
    public class StringFormatter
    {
        private const int MaxItemLength = 1024;

        /// <summary>
        /// Joins a collection of strings into a comma-separated string wrapping each item in the given quote.
        /// Skips invalid items (null, empty, whitespace, non-alphanumeric character, or exceeding <see cref="MaxItemLength"/> characters).
        /// </summary>
        /// <param name="items">Strings to include.</param>
        /// <param name="quote">Quote character to wrap each item.</param>
        /// <returns>Comma-separated quoted string of valid items.</returns>
        /// <exception cref="ArgumentNullException">Thrown when items or quote is null.</exception>
        /// <exception cref="ArgumentException">Thrown when items is empty or quote is whitespace.</exception>
        public static string ToCommaSeparatedString(IEnumerable<string> items, string quote = "\"")
        {
            ArgumentNullException.ThrowIfNull(items);
            ArgumentException.ThrowIfNullOrWhiteSpace(quote, nameof(quote));

            if (quote.Length != 1 || char.IsLetterOrDigit(quote[0]))
                throw new ArgumentException("Quote must be a single non-alphanumeric character.", nameof(quote));

            var sb = new StringBuilder(256);
            bool isFirst = true;

            foreach (var item in items)
            {
                if (!IsValidItem(item)) continue;

                var trimmed = item.Trim();

                if (!isFirst)
                    sb.Append(',');
                else
                    isFirst = false;

                sb.Append(quote).Append(trimmed).Append(quote);
            }

            return sb.ToString();
        }

        /// <summary>
        /// Checks if a string is non-empty, within length and has atleast one letter or number.
        /// </summary>
        private static bool IsValidItem(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return false;

            var trimmed = value.Trim();
            if (trimmed.Length > MaxItemLength) return false;

            return trimmed.Any(char.IsLetterOrDigit);
        }
    }
}
