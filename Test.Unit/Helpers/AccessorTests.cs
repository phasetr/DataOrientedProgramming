using Helpers;

namespace Test.Unit.Helpers;

public class AccessorTests
{
    [Fact]
    public void Get_Succeeded()
    {
        var data = new Dictionary<string, dynamic>
        {
            {"key1", "value1"},
            {"key2", new Dictionary<string, dynamic>
                {
                    {"key21", "value21"},
                    {"key22", new Dictionary<string, dynamic>
                            {{"key31", "value31"}}
                    }
                }
            },
            {"key3", "value3"}
        };
        Assert.NotNull(data);
        var result = Accessor.Get(data, ["key2", "key22", "key31"]);
        Assert.Equal("value31", result);
    }
}
