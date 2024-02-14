using Json.Schema;

namespace BookSample.BookInfo;

public static class BookInfoSchema
{
    public static readonly JsonSchema MyModelSchema =
        new JsonSchemaBuilder()
            .Type(SchemaValueType.Object)
            .Properties(
                ("title", new JsonSchemaBuilder()
                    .Type(SchemaValueType.String)
                    .MaxLength(50)
                ),
                ("isbn", new JsonSchemaBuilder()
                    .Type(SchemaValueType.String)
                    .MaxLength(50)
                ),
                ("authorNames", new JsonSchemaBuilder()
                    .Type(SchemaValueType.Array)
                    .Items(new JsonSchemaBuilder()
                        .Type(SchemaValueType.String)
                    )
                )
            )
            .Required("title", "isbn", "authorNames");
}
