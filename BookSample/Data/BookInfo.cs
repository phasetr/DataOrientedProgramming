using DataOrientedProgramming;

namespace BookSample.Data;

public static class BookInfo
{
    public static readonly Dictionary<string, dynamic> Data = CreateData.ToDictionaryDynamic(
        "title", "Watchmen",
        "isbn", "978-1779501127",
        "authorNames", CreateData.ToListDynamic("Alan Moore", "Dave Gibbons")
    );
}
