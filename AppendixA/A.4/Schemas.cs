using Json.Schema;

namespace AppendixA.A._4;

public static class Schemas
{
    public static readonly JsonSchema AuthorRequestSchema = new JsonSchemaBuilder()
        .Type(SchemaValueType.Object)
        .Properties(
            (nameof(AuthorRequestModel.FirstName),
                new JsonSchemaBuilder().Type(SchemaValueType.String)),
            (nameof(AuthorRequestModel.LastName),
                new JsonSchemaBuilder().Type(SchemaValueType.String)),
            (nameof(AuthorRequestModel.Books), new JsonSchemaBuilder()
                .Type(SchemaValueType.Integer))
        )
        .Required(
            nameof(AuthorRequestModel.FirstName),
            nameof(AuthorRequestModel.LastName));
}
