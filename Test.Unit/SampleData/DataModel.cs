using DataOrientedProgramming;

namespace Test.Unit.SampleData;

public static class DataModel
{
    public static readonly Map Watchmen = Map.Of(
        "isbn", "978-1779501127",
        "title", "Watchmen",
        "publicationYear", 1987,
        "authors", List.Of("alan-moore", "dave-gibbons"),
        "bookItems", List.Of(
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

    public static readonly Map Catalog = Map.Of(
        "booksByIsbn", Map.Of(
            "978-1779501127", Map.Of(
                "isbn", "978-1779501127",
                "title", "Watchmen",
                "publicationYear", 1987,
                "authorIds", List.Of("alan-moore", "dave-gibbons"),
                "bookItems", List.Of(
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
                "bookIsbns", List.Of("978-1779501127")
            ),
            "dave-gibbons", Map.Of(
                "name", "Dave Gibbons",
                "bookIsbns", List.Of("978-1779501127")
            )
        )
    );
}
