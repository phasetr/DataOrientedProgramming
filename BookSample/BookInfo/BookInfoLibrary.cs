using BookSample.Authors;
using DataOrientedProgramming;

namespace BookSample.BookInfo;

public static class BookInfoLibrary
{
    public static Map BookInfo(Map catalogData, Map book)
    {
        return new Map
        {
            {"title", (string) _.Get(book, "title")},
            {"isbn", (string) _.Get(book, "isbn")},
            {"authorNames", AuthorLibrary.AuthorNames(catalogData, book)}
        };
    }

    public static List<dynamic> SearchBooksByTitle(Map catalogData, string query)
    {
        Dictionary<string, dynamic> allBooks =
            _.Get(catalogData, "booksByIsbn");
        var matchingBooks = allBooks.Values
            .OfType<Map>()
            .Where(kvp => ((string) _.Get(kvp, "title")).Contains(query));
        return matchingBooks
            .Select(book => BookInfo(catalogData, book))
            .ToList<dynamic>() ?? [];
    }
}
