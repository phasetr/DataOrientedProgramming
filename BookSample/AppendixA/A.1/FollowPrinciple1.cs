using System.Collections.Immutable;

namespace BookSample.AppendixA.A._1;

/// <summary>
///     P.395, List.A-3. Follow the principle 1 in OOP
/// </summary>
public class AuthorData
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public ImmutableList<string> Books { get; set; } = ImmutableList<string>.Empty;
}

public class NameCalculation
{
    public static string FullName(AuthorData authorData)
    {
        return $"{authorData.FirstName} {authorData.LastName}";
    }
}

public class AuthorRating
{
    public static bool IsProlific(AuthorData authorData)
    {
        return authorData.Books.Count > 100;
    }
}
