using BookSample.Data;
using BookSample.Functions;

namespace Test.Unit.BookSample.Functions;

public class UserManagementTests
{
    [Fact]
    public void IsLibrarian_Success()
    {
        var actual = UserManagement.IsLibrarian(UserManagementData.Data, "franck@gmail.com");
        Assert.True(actual);
    }

    [Fact]
    public void IsLibrarian_Failure()
    {
        var actual = UserManagement.IsLibrarian(UserManagementData.Data, "nouser@gmail.com");
        Assert.False(actual);
    }
}
