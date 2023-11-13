namespace AppendixA.A._1;

/// <summary>
///     P.393, List A-1. Violate the principle 1 in OOP
/// </summary>
public class Author
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public List<string> Books { get; set; } = new();

    public string FullName => $"{FirstName} {LastName}";
    public bool IsProlific => Books.Count > 100;
}
