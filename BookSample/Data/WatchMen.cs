using DataOrientedProgramming;

namespace BookSample.Data;

public static class WatchMen
{
    public static readonly Map Data = Map.Of(
        "isbn", "978-1779501127",
        "title", "Watchmen",
        "publicationYear", 1987,
        "authorIds", CreateData.ToListDynamic("alan-moore", "dave-gibbons"),
        "bookItems", CreateData.ToListDynamic(
            Map.Of(
                "id", "book-item-1",
                "libId", "nyc-central-lib",
                "isLent", true
            ),
            Map.Of(
                "id", "book-item-2",
                "libId", "nyc-central-lib",
                "isLent", false
            )
        ),
        "reviews", Map.Of(
            "reader1", "Interesting",
            "me", "5 of 5!"
        )
    );
}
