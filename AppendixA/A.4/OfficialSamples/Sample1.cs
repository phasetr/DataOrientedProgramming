using System.Text.Json.Serialization;

namespace AppendixA.A._4.OfficialSamples;

public class Sample1
{
    [JsonConverter(typeof(DateTimeJsonConverter))]
    public DateTime CreatedAt { get; set; }

    [JsonConverter(typeof(DateTimeJsonConverter))]
    public DateTime UpdatedAt { get; set; }
}
