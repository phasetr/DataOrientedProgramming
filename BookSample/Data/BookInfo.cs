using DataOrientedProgramming;

namespace BookSample.Data;

public static class BookInfo
{
    public static readonly Map Data = Map.Of(
        "title", "Watchmen",
        "isbn", "978-1779501127",
        "authorNames", CreateData.ToListDynamic("Alan Moore", "Dave Gibbons")
    );
}
