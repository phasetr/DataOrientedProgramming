using System.Collections.Immutable;
using DataOrientedProgramming;

namespace BookSample.Data;

public static class UserManagementData
{
    public static readonly ImmutableDictionary<string, dynamic> Data = CreateData.ToDictionaryDynamic(
        "librariansByEmail", CreateData.ToDictionaryDynamic(
            "franck@gmail.com", CreateData.ToDictionaryDynamic(
                "email", "franck@gmail.com",
                // Base64 encoded "mypassword"
                "encryptedPassword", "bXlwYXNzd29yZA==")),
        "membersByEmail", CreateData.ToDictionaryDynamic(
            "samantha@gmail.com", CreateData.ToDictionaryDynamic(
                "email", "samantha@gmail.com",
                // Base64 encoded "secret"
                "encryptedPassword", "c2VjcmV0"),
            "isBlocked", false,
            "bookLendings", CreateData.ToListDynamic(CreateData.ToDictionaryDynamic(
                "bookItemId", "book-item-1",
                "bookIsbn", "978-1779501127",
                "lendingDate", "2020-04-23")))
    );
}
