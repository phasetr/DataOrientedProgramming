using System.Collections.Immutable;
using System.Text.Json;
using DataOrientedProgramming;
using static BookSample.Functions.Catalog;

namespace BookSample.Functions;

public static class Library
{
    public static string SearchBooksByTitleJson(ImmutableDictionary<string, dynamic> libraryData, string query)
    {
        var results = SearchBooksByTitle(_.Get(libraryData, "catalog"), query);
        return JsonSerializer.Serialize(results);
    }
}
