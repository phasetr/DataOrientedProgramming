using BookSample.Authors;
using BookSample.Data;
using DataOrientedProgramming;

namespace Test.Unit.BookSample.Authors;

public class AuthorLibraryTests
{
    [Fact]
    public void AuthorNamesTest()
    {
        var book = _.Get(Catalog.Data, "booksByIsbn", "978-1779501127");
        var actual = (List<string>) AuthorLibrary.AuthorNames(Catalog.Data, book);
        Assert.Equal("Alan Moore", actual[0]);
        Assert.Equal("Dave Gibbons", actual[1]);
    }
}
