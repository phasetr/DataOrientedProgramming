using Json.Schema.Serialization;

namespace AppendixA.A._4;

[JsonSchema(typeof(Schemas), nameof(Schemas.AuthorRequestSchema))]
public class AuthorRequestModel
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public int Books { get; set; }
}
