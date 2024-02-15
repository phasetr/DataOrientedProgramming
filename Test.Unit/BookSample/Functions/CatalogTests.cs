using System.Collections.Immutable;
using BookSample.Data;
using BookSample.Functions;
using DataOrientedProgramming;

namespace Test.Unit.BookSample.Functions;

public class CatalogTests
{
    [Fact]
    public void AuthorNamesTest()
    {
        var book = _.Get(CatalogData.Data, "booksByIsbn", "978-1779501127");
        var actual = (ImmutableList<string>) Catalog.AuthorNames(CatalogData.Data, book);
        Assert.Equal("Alan Moore", actual[0]);
        Assert.Equal("Dave Gibbons", actual[1]);
    }

    [Fact]
    public void BookInfoTest()
    {
        var book = new Dictionary<string, dynamic>
        {
            ["title"] = "Watchmen",
            ["isbn"] = "978-1779501127",
            ["authorIds"] = new List<dynamic>
            {
                "alan-moore"
            }
        }.ToImmutableDictionary();
        var actual = Catalog.BookInfo(CatalogData.Data, book);
        var expected = new Dictionary<string, dynamic>
        {
            ["title"] = "Watchmen",
            ["isbn"] = "978-1779501127",
            ["authorNames"] = new List<string> {"Alan Moore"}.ToImmutableList()
        }.ToImmutableDictionary();
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void SearchBooksByTitle_Success()
    {
        var actual = Catalog.SearchBooksByTitle(CatalogData.Data, "Wat");
        var expected = CreateData.ToListDynamic(
            CreateData.ToDictionaryDynamic(
                "title", "Watchmen",
                "isbn", "978-1779501127",
                "authorNames", CreateData.ToListDynamic("Alan Moore", "Dave Gibbons")));
        Assert.Equal(expected, actual);
    }
}
