namespace HeinHtetNaing_ADI.Common.Utils
{
    internal static class GuidUtil
    {
        // Generates a new long as a unique identifier
        public static long GenerateNewLongGuid()
        {
            // Example: We can use DateTime ticks combined with a random number for uniqueness
            long timestamp = DateTime.UtcNow.Ticks;
            long randomValue = new Random().Next(1, 1000000); // Random value to help ensure uniqueness

            return timestamp + randomValue;
        }

        // Converts a long value to a string for SQL storage
        public static string LongGuidToSqlFormat(long longGuid)
        {
            return longGuid.ToString();
        }

        // Verifies if a string can be parsed as a valid long value
        public static bool IsValidLongGuid(string longGuidString)
        {
            return long.TryParse(longGuidString, out _); // Returns true if it's a valid long, false otherwise
        }
    }
}
