using System.Text;

namespace PointsBet_Backend_Online_Code_Test
{

    /// <summary>
    /// Provides utility methods for formatting strings.
    /// </summary>
    public class StringFormatter
    {
        /// <summary>
        /// Converts an array of strings into a single comma-separated string,
        /// with each item wrapped in the specified quotes.
        /// </summary>
        public static string ToCommaSeparatedList(string[] items, string quote)
        {
            // Validate input parameters
            if (items == null || items.Length == 0 || string.IsNullOrWhiteSpace(quote)) 
                return string.Empty;
            // Use String.Join with LINQ for cleaner and more efficient code
            return string.Join(", ", items.Select(item => $"{quote}{item}{quote}"));
        }
    }
}
    