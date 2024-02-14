using DataOrientedProgramming;

namespace BookSample.Data;

public static class Catalog
{
    public static readonly Map Data = Map.Of(
        "booksByIsbn", Map.Of(
            "978-1779501127", Map.Of(
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
                )
            )
        ),
        "authorsById", Map.Of(
            "alan-moore", Map.Of(
                "name", "Alan Moore",
                "bookIsbns", CreateData.ToListDynamic("978-1779501127")
            ),
            "dave-gibbons", Map.Of(
                "name", "Dave Gibbons",
                "bookIsbns", CreateData.ToListDynamic("978-1779501127")
            )
        )
    );
}
