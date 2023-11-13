namespace AppendixA.A._2;

/// <summary>
///     P.405, List.A-12. Violate the principle 2 in OOP
/// </summary>
public class AuthorData
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public List<string> Books { get; set; } = new();

    public string FullName => $"{FirstName} {LastName}";
    public bool IsProlific => Books.Count > 100;
}
