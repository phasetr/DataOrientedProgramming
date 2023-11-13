using System.Text.Json;
using AppendixA.A._4.OfficialSamples;
using Json.Schema;
using Json.Schema.Serialization;

namespace Test.Unit.AppendixA.A._4.OfficialSamples;

public class MyModelTests
{
    [Fact]
    public void OfficialSample_Test1()
    {
        // https://blog.json-everything.net/posts/deserialization-with-schemas/
        const string jsonText = @"{
  ""Foo"": ""foo"",
  ""Bar"": -42
}";
        var converter = new ValidatingJsonConverter();
        var options = new JsonSerializerOptions {Converters = {converter}};

        var exception = Record.Exception(() =>
            JsonSerializer.Deserialize<MyModel>(jsonText, options));
        Assert.NotNull(exception);
        Assert.Equal(typeof(JsonException), exception.GetType());
        Assert.Equal("JSON does not meet schema requirements", exception.Message);
    }

    [Fact]
    public void OfficialSample_Test2()
    {
        // https://blog.json-everything.net/posts/deserialization-with-schemas/
        const string jsonText = @"{
  ""Foo"": ""foo"",
  ""Bar"": -42
}";
        var converter = new ValidatingJsonConverter {OutputFormat = OutputFormat.List};
        var options = new JsonSerializerOptions {Converters = {converter}};

        var exception = Record.Exception(() =>
            JsonSerializer.Deserialize<MyModel>(jsonText, options));
        Assert.NotNull(exception);
        Assert.Equal(typeof(JsonException), exception.GetType());
        Assert.Equal("JSON does not meet schema requirements", exception.Message);
    }

    [Fact]
    public void OfficialSample_Test3()
    {
        // https://blog.json-everything.net/posts/deserialization-with-schemas/
        const string jsonText = @"{
  ""Foo"": ""foo is long enough"",
  ""Bar"": -42,
  ""Baz"": ""May 1, 2023""
}";
        var converter = new ValidatingJsonConverter
        {
            OutputFormat = OutputFormat.List,
            RequireFormatValidation = true
        };
        var options = new JsonSerializerOptions {Converters = {converter}};

        var exception = Record.Exception(() =>
            JsonSerializer.Deserialize<MyModel>(jsonText, options));
        Assert.NotNull(exception);
        Assert.Equal(typeof(JsonException), exception.GetType());
        Assert.Equal("JSON does not meet schema requirements", exception.Message);
    }
    
    [Fact]
    public void OfficialSample_Test4()
    {
        // https://blog.json-everything.net/posts/deserialization-with-schemas/
        const string jsonText = @"{
  ""Foo"": ""foo is long enough"",
  ""Bar"": -42,
  ""Baz"": ""2023-05-01T02:09:48.54Z""
}";
        var converter = new ValidatingJsonConverter
        {
            OutputFormat = OutputFormat.List,
            RequireFormatValidation = true
        };
        var options = new JsonSerializerOptions {Converters = {converter}};

        var exception = Record.Exception(() =>
            JsonSerializer.Deserialize<MyModel>(jsonText, options));
        Assert.NotNull(exception);
        Assert.Equal(typeof(JsonException), exception.GetType());
        Assert.Equal("JSON does not meet schema requirements", exception.Message);
    }    
}
