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

        Assert.Equal("alan-moore", _.Get(map, ["authors", "0"]));
        Assert.Equal("dave-gibbons", _.Get(map, ["authors", "1"]));

        Assert.Equal("book-item-1", _.Get(map, ["bookItems", "0", "id"]));
        Assert.Equal("nyc-central-lib", _.Get(map, ["bookItems", "0", "libId"]));
        Assert.True((bool) _.Get(map, ["bookItems", "0", "isLent"]));
        Assert.Equal("book-item-2", _.Get(map, ["bookItems", "1", "id"]));
        Assert.Equal("nyc-central-lib", _.Get(map, ["bookItems", "1", "libId"]));
        Assert.False((bool) _.Get(map, ["bookItems", "1", "isLent"]));
    }
}
