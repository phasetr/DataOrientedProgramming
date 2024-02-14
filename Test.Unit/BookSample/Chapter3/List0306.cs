using BookSample.Data;
using DataOrientedProgramming;

namespace Test.Unit.BookSample.Chapter3;

public class List0306
{
    [Fact]
    public void Test()
    {
        Assert.Equal("Watchmen", _.Get(Catalog.Data, ["booksByIsbn", "978-1779501127", "title"]));
    }
}
