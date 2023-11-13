using Json.Schema.Serialization;

namespace AppendixA.A._4.OfficialSamples;

/// <summary>
///     [JSON Deserialization with JSON Schema
///     Validation](https://blog.json-everything.net/posts/deserialization-with-schemas/)
/// </summary>
[JsonSchema(typeof(ModelSchemas), nameof(ModelSchemas.MyModelSchema))]
public class MyModel
{
    public string Foo { get; set; } = string.Empty;
    public int Bar { get; set; }
    public DateTime Baz { get; set; }
}
