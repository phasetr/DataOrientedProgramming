using DataOrientedProgramming;

namespace BookSample.Data;

public static class Catalog
{
    public static readonly Dictionary<string, dynamic> Data = CreateData.ToDictionaryDynamic(
        "booksByIsbn", CreateData.ToDictionaryDynamic(
            "978-1779501127", CreateData.ToDictionaryDynamic(
                "isbn", "978-1779501127",
                "title", "Watchmen",
                "publicationYear", 1987,
                "authorIds", CreateData.ToListDynamic("alan-moore", "dave-gibbons"),
                "bookItems", CreateData.ToListDynamic(
                    CreateData.ToDictionaryDynamic(
                        "id", "book-item-1",
                        "libId", "nyc-central-lib",
                        "isLent", true
                    ),
                    CreateData.ToDictionaryDynamic(
                        "id", "book-item-2",
                        "libId", "nyc-central-lib",
                        "isLent", false
                    )
                )
            )
        ),
        "authorsById", CreateData.ToDictionaryDynamic(
            "alan-moore", CreateData.ToDictionaryDynamic(
                "name", "Alan Moore",
                "bookIsbns", CreateData.ToListDynamic("978-1779501127")
            ),
            "dave-gibbons", CreateData.ToDictionaryDynamic(
                "name", "Dave Gibbons",
                "bookIsbns", CreateData.ToListDynamic("978-1779501127")
            )
        )
    );
}
