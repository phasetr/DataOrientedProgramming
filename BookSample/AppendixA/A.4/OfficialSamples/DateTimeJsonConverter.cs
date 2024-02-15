using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BookSample.AppendixA.A._4.OfficialSamples;

public class DateTimeJsonConverter : JsonConverter<DateTime>
{
    private const string DateTimeFormat = "yyyy-MM-dd HH:mm:ss";

    public override DateTime Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        return reader.GetString()! == null
            ? DateTime.MinValue
            : DateTime.ParseExact(reader.GetString()!, DateTimeFormat, CultureInfo.InvariantCulture);
    }

    public override void Write(
        Utf8JsonWriter writer,
        DateTime dateTimeValue,
        JsonSerializerOptions options)
    {
        writer.WriteStringValue(dateTimeValue.ToString(DateTimeFormat, CultureInfo.InvariantCulture));
    }
}
