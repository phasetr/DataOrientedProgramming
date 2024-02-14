using System.Text.Json.Serialization;
using Json.Schema.Serialization;

namespace BookSample.AppendixA.A._4.OfficialSamples;

/// <summary>
///     [JSON Deserialization with JSON Schema
///     Validation](https://blog.json-everything.net/posts/deserialization-with-schemas/)
/// </summary>
[JsonSchema(typeof(ModelSchemas), nameof(ModelSchemas.MyModelSchema))]
public class MyModel
{
    public string Foo { get; set; } = string.Empty;
    public int Bar { get; set; }

    [JsonConverter(typeof(DateTimeJsonConverter))]
    public DateTime Baz { get; set; }
}
