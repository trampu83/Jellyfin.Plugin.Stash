using System;
using System.Globalization;
using Newtonsoft.Json;

namespace Stash.Helpers
{
    // Stash stores fuzzy dates (yyyy, yyyy-MM, yyyy-MM-dd); partial dates map to the first day of the period.
    public class FuzzyDateConverter : JsonConverter<DateTime?>
    {
        private static readonly string[] PartialFormats = { "yyyy", "yyyy-MM" };

        public override DateTime? ReadJson(JsonReader reader, Type objectType, DateTime? existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            switch (reader.Value)
            {
                case DateTime date:
                    return date;
                case string text when DateTime.TryParseExact(text, PartialFormats, CultureInfo.InvariantCulture, DateTimeStyles.None, out var partial):
                    return partial;
                case string text when DateTime.TryParse(text, CultureInfo.InvariantCulture, DateTimeStyles.None, out var full):
                    return full;
                default:
                    return null;
            }
        }

        public override void WriteJson(JsonWriter writer, DateTime? value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }
    }
}
