using System.Collections.Immutable;

namespace AppendixA.A._2;

/// <summary>
///     P.405, List.A-12. Follow the principle 2 in OOP
/// </summary>
public class FollowPrinciple2
{
    public static ImmutableDictionary<string, dynamic> CreateAuthorData(
        string firstName, string lastName, ImmutableList<string> books)
    {
        return new Dictionary<string, dynamic>
        {
            {"FirstName", firstName},
            {"LastName", lastName},
            {"Books", books}
        }.ToImmutableDictionary();
    }
}

public class NameCalculation
{
    public static string FullName(ImmutableDictionary<string, dynamic> authorData)
    {
        return $"{authorData["FirstName"]} {authorData["LastName"]}";
    }
}

/// <summary>
///     P.410, List.A-23. Unnecessary to convert types when accessing fields
/// </summary>
public class AuthorRating
{
    /// <summary>
    ///     The author is prolific if they have written more than 100 books.
    /// </summary>
    /// <param name="authorData">This dictionary has the `Books` key</param>
    /// <returns></returns>
    public static bool IsProlific(ImmutableDictionary<string, dynamic> authorData)
    {
        return authorData["Books"].Count > 100;
    }
}
