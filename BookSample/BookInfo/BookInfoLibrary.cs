using BookSample.Authors;
using DataOrientedProgramming;

namespace BookSample.BookInfo;

public static class BookInfoLibrary
{
    public static Dictionary<string, dynamic> BookInfo(
        Dictionary<string, dynamic> catalogData,
        Dictionary<string, dynamic> book)
    {
        return new Dictionary<string, dynamic>
        {
            {"title", _.Get(book, "title")},
            {"isbn", _.Get(book, "isbn")},
            {"authorNames", AuthorLibrary.AuthorNames(catalogData, book)}
        };
    }

    public static List<dynamic> SearchBooksByTitle(Dictionary<string, dynamic> catalogData, string query)
    {
        Dictionary<string, dynamic> allBooks =
            _.Get(catalogData, "booksByIsbn");
        var matchingBooks = allBooks.Values
            .OfType<Dictionary<string, dynamic>>()
            .Where(kvp => ((string) _.Get(kvp, "title")).Contains(query));
        return matchingBooks
            .Select(book => BookInfo(catalogData, book))
            .ToList<dynamic>() ?? [];
    }
}
