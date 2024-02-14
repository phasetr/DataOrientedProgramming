using DataOrientedProgramming;
using Test.Unit.SampleData;

namespace Test.Unit.DataOrientedProgramming;

public class LoDashTests
{
    [Fact]
    public void LoDash_Watchmen()
    {
        var watchmen = DataModel.Watchmen;

        Assert.Equal("Interesting", _.Get(watchmen, "reviews", "reader1"));
        Assert.Equal("5 of 5!", _.Get(watchmen, "reviews", "me"));

        Assert.Equal("978-1779501127", _.Get(watchmen, "isbn"));
        Assert.Equal("Watchmen", _.Get(watchmen, "title"));
        Assert.Equal(1987, _.Get(watchmen, "publicationYear"));

        Assert.Equal("alan-moore", _.Get(watchmen, ["authors", "0"]));
        Assert.Equal("dave-gibbons", _.Get(watchmen, ["authors", "1"]));

        Assert.Equal("book-item-1", _.Get(watchmen, ["bookItems", "0", "id"]));
        Assert.Equal("nyc-central-lib", _.Get(watchmen, ["bookItems", "0", "libId"]));
        Assert.True((bool) _.Get(watchmen, ["bookItems", "0", "isLent"]));
        Assert.Equal("book-item-2", _.Get(watchmen, ["bookItems", "1", "id"]));
        Assert.Equal("nyc-central-lib", _.Get(watchmen, ["bookItems", "1", "libId"]));
        Assert.False((bool) _.Get(watchmen, ["bookItems", "1", "isLent"]));
    }

    [Fact]
    public void LoDash_Catalog()
    {
        var catalog = DataModel.Catalog;
        var book = (Dictionary<string, dynamic>)_.Get(catalog, "booksByIsbn", "978-1779501127");
        Assert.NotNull(book);
        Assert.Equal("978-1779501127", _.Get(book, "isbn"));
    }
}
