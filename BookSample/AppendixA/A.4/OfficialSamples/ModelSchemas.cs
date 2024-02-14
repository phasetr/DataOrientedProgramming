using Json.Schema;

namespace BookSample.AppendixA.A._4.OfficialSamples;

/// <summary>
///     [JSON Deserialization with JSON Schema
///     Validation](https://blog.json-everything.net/posts/deserialization-with-schemas/)
/// </summary>
public static class ModelSchemas
{
    public static readonly JsonSchema MyModelSchema =
        new JsonSchemaBuilder()
            .Type(SchemaValueType.Object)
            .Properties(
                (nameof(MyModel.Foo), new JsonSchemaBuilder()
                    .Type(SchemaValueType.String)
                    .MinLength(10)
                    .MaxLength(50)
                ),
                (nameof(MyModel.Bar), new JsonSchemaBuilder()
                    .Type(SchemaValueType.Integer)
                    .Minimum(0)
                ),
                (nameof(MyModel.Baz), new JsonSchemaBuilder()
                    .Type(SchemaValueType.String)
                    .Format(Formats.DateTime)
                )
            )
            .Required(nameof(MyModel.Baz));
}
