using System.Collections.Immutable;
using BookSample.Data;
using BookSample.Functions;
using DataOrientedProgramming;

namespace Test.Unit.BookSample.Authors;

public class AuthorLibraryTests
{
    [Fact]
    public void AuthorNamesTest()
    {
        var book = _.Get(CatalogData.Data, "booksByIsbn", "978-1779501127");
        var actual = (ImmutableList<string>) Catalog.AuthorNames(CatalogData.Data, book);
        Assert.Equal("Alan Moore", actual[0]);
        Assert.Equal("Dave Gibbons", actual[1]);
    }
}
