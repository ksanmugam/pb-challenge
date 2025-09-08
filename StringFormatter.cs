using System;
using System.Linq;

namespace PointsBet_Backend_Online_Code_Test
{
    public class StringFormatter
    {
        /// <summary>
        /// Converts an array of strings to a comma-separated list with each item wrapped in quotes.
        /// </summary>
        /// <param name="items">Array of strings to format</param>
        /// <param name="quote">Quote character to wrap around each item</param>
        /// <returns>Comma-separated string with quoted items</returns>
        /// <exception cref="ArgumentNullException">Thrown when items array is null</exception>
        /// <exception cref="ArgumentException">Thrown when items array is empty</exception>
        public static string ToCommaSeparatedString(string[] items, string quote = "\"")
        {
            // null check for the items array
            if (items == null)
                throw new ArgumentNullException(nameof(items), "Items array cannot be null");

            // empty array check to prevent runtime errors
            if (items.Length == 0)
                throw new ArgumentException("Items array cannot be empty", nameof(items));

            // handle null item by converting to empty strings
            var quotedItems = items.Select(item => $"{quote}{item ?? string.Empty}{quote}");
            return string.Join(", ", quotedItems);
        }

        class Program
        {
            static void Main(string[] args)
            {
                // Example input
                string[] items = { "apple", "banana", "cherry" };

                // Call your formatter
                string result = StringFormatter.ToCommaSeparatedString(items);

                // Print result
                Console.WriteLine(result);

                // With a different quote
                string singleQuoteResult = StringFormatter.ToCommaSeparatedString(items, "'");
                Console.WriteLine(singleQuoteResult);
            }
        }
    }
}
