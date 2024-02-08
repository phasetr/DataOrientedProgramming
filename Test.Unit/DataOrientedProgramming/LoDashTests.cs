using DataOrientedProgramming;
using Test.Unit.SampleData;

namespace Test.Unit.DataOrientedProgramming;

public class LoDashTests
{
    [Fact]
    public void LoDash_Example1()
    {
        var map = DataModel.Watchmen;

        Assert.Equal("Interesting", _.Get(map, "reviews", "reader1"));
        Assert.Equal("5 of 5!", _.Get(map, "reviews", "me"));

        Assert.Equal("978-1779501127", _.Get(map, "isbn"));
        Assert.Equal("Watchmen", _.Get(map, "title"));
        Assert.Equal(1987, _.Get(map, "publicationYear"));

        var authors = _.Get(map, "authors");
        // TODO リストも`Get`で処理したい
        Assert.Equal("alan-moore", authors[0]);
        Assert.Equal("dave-gibbons", authors[1]);

        var bookItems = _.Get(map, "bookItems");
        // TODO リストも`Get`で処理したい
        var bookItem1 = bookItems[0] as Map;
        Assert.NotNull(bookItem1);
        Assert.Equal("book-item-1", _.Get(bookItem1, "id"));
        Assert.Equal("nyc-central-lib", _.Get(bookItem1, "libId"));
        Assert.True((bool)_.Get(bookItem1, "isLent"));
        var bookItem2 = bookItems[1] as Map;
        Assert.NotNull(bookItem2);
        Assert.Equal("book-item-2", _.Get(bookItem2, "id"));
        Assert.Equal("nyc-central-lib", _.Get(bookItem2, "libId"));
        Assert.False((bool)_.Get(bookItem2, "isLent"));
    }
}
