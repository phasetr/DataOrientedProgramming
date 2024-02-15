using DataOrientedProgramming;

namespace Test.Unit.DataOrientedProgramming;

public class LoDashTests
{
    [Fact]
    public void Get_Dict_Success()
    {
        var d = CreateData.ToDictionaryDynamic("a", 1, "b", 2);
        var result = _.Get(d, "a");
        Assert.Equal(1, result);
    }

    [Fact]
    public void Get_Dict_Failure()
    {
        var d = CreateData.ToDictionaryDynamic("a", 1, "b", 2);
        var result = _.Get(d, "notExist");
        Assert.Null(result);
    }

    [Fact]
    public void Get_List_Success()
    {
        var l = CreateData.ToListDynamic(1, 2, 3);
        var result = _.Get(l, "1");
        Assert.Equal(2, result);
    }

    [Fact]
    public void Get_List_Failure()
    {
        var l = CreateData.ToListDynamic(1, 2, 3);
        var result = _.Get(l, "3");
        Assert.IsType<IndexOutOfRangeException>(result);
    }

    [Fact]
    public void Get_ComplexMap_Success()
    {
        var m = CreateData.ToDictionaryDynamic(
            "a", CreateData.ToDictionaryDynamic("b",
                CreateData.ToListDynamic(1, 2, 3)));
        var result = _.Get(m, "a", "b", "1");
        Assert.Equal(2, result);
    }

    [Fact]
    public void Get_ComplexMap_Failure()
    {
        var m = CreateData.ToDictionaryDynamic(
            "a", CreateData.ToDictionaryDynamic("b",
                CreateData.ToListDynamic(1, 2, 3)));
        var result = _.Get(m, "a", "b", "3");
        Assert.IsType<IndexOutOfRangeException>(result);
    }

    [Fact]
    public void Has_Success()
    {
        var d = CreateData.ToDictionaryDynamic(
            "a", 1,
            "b", 2);
        var result = _.Has(d, "a");
        Assert.True(result);
    }

    [Fact]
    public void Has_Failure()
    {
        var d = CreateData.ToDictionaryDynamic(
            "a", 1,
            "b", 2);
        var result = _.Has(d, "c");
        Assert.False(result);
    }
}
