using System.Collections.Immutable;
using DataOrientedProgramming;

namespace BookSample.Functions;

public static class Catalog
{
    /// <summary>
    ///     リスト3-14で定義。
    /// </summary>
    /// <param name="catalogData"></param>
    /// <param name="book"></param>
    /// <returns></returns>
    public static ImmutableList<string> AuthorNames(ImmutableDictionary<string, dynamic> catalogData,
        ImmutableDictionary<string, dynamic> book)
    {
        var temp =  _.Get(book, "authorIds");
        if (temp == null) return ImmutableList<string>.Empty;
        var authorIds = (IEnumerable<dynamic>) temp;
        return authorIds
            .Select(authorId => (string) _.Get(catalogData, "authorsById", authorId, "name"))
            .ToImmutableList() ?? [];
    }

    public static ImmutableDictionary<string, dynamic> BookInfo(
        ImmutableDictionary<string, dynamic> catalogData,
        ImmutableDictionary<string, dynamic> book)
    {
        return new Dictionary<string, dynamic>
        {
            {"title", _.Get(book, "title")},
            {"isbn", _.Get(book, "isbn")},
            {"authorNames", AuthorNames(catalogData, book)}
        }.ToImmutableDictionary();
    }

    public static ImmutableList<dynamic> SearchBooksByTitle(ImmutableDictionary<string, dynamic> catalogData,
        string query)
    {
        ImmutableDictionary<string, dynamic> allBooks =
            _.Get(catalogData, "booksByIsbn");
        var matchingBooks = allBooks.Values
            .OfType<ImmutableDictionary<string, dynamic>>()
            .Where(kvp => ((string) _.Get(kvp, "title")).Contains(query));
        return matchingBooks
            .Select(book => BookInfo(catalogData, book))
            .ToImmutableList<dynamic>() ?? [];
    }
}
