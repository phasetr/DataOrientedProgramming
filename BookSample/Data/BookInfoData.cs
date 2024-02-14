using System.Collections.Immutable;
using DataOrientedProgramming;

namespace BookSample.Data;

public static class BookInfoData
{
    public static readonly ImmutableDictionary<string, dynamic> Data = CreateData.ToDictionaryDynamic(
        "title", "Watchmen",
        "isbn", "978-1779501127",
        "authorNames", CreateData.ToListDynamic("Alan Moore", "Dave Gibbons")
    );
}
