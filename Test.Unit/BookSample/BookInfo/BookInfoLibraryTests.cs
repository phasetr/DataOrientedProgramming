using BookSample.BookInfo;
using BookSample.Data;
using DataOrientedProgramming;

namespace Test.Unit.BookSample.BookInfo;

public class BookInfoLibraryTests
{
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
        };
        var actual = BookInfoLibrary.BookInfo(Catalog.Data, book);
        var expected = new Dictionary<string, dynamic>
        {
            ["title"] = "Watchmen",
            ["isbn"] = "978-1779501127",
            ["authorNames"] = new[]
            {
                "Alan Moore"
            }
        };
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void SearchBooksByTitle_Success()
    {
        var actual = BookInfoLibrary.SearchBooksByTitle(Catalog.Data, "Wat");
        var expected = CreateData.ToListDynamic(
            CreateData.ToDictionaryDynamic(
                "title", "Watchmen",
                "isbn", "978-1779501127",
                "authorNames", CreateData.ToListDynamic("Alan Moore", "Dave Gibbons")));
        Assert.Equal(expected, actual);
    }
}
