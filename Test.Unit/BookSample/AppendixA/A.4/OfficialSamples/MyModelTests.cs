using System.Text.Json;
using BookSample.AppendixA.A._4.OfficialSamples;
using Json.Schema;
using Json.Schema.Serialization;

namespace Test.Unit.BookSample.AppendixA.A._4.OfficialSamples;

public class MyModelTests
{
    [Fact]
    public void OfficialSample_Failed1()
    {
        // https://blog.json-everything.net/posts/deserialization-with-schemas/
        const string jsonText =
            """
            {
              "Foo": "foo",
              "Bar": -42
            }
            """;
        var converter = new ValidatingJsonConverter();
        var options = new JsonSerializerOptions {Converters = {converter}};

        var exception = Record.Exception(() =>
            JsonSerializer.Deserialize<MyModel>(jsonText, options));
        Assert.NotNull(exception);
        Assert.Equal(typeof(JsonException), exception.GetType());
        Assert.Equal("JSON does not meet schema requirements", exception.Message);
    }

    [Fact]
    public void OfficialSample_Failed2()
    {
        // https://blog.json-everything.net/posts/deserialization-with-schemas/
        const string jsonText =
            """
            {
              "Foo": "foo",
              "Bar": -42
            }
            """;
        var converter = new ValidatingJsonConverter {OutputFormat = OutputFormat.List};
        var options = new JsonSerializerOptions {Converters = {converter}};

        var exception = Record.Exception(() =>
            JsonSerializer.Deserialize<MyModel>(jsonText, options));
        Assert.NotNull(exception);
        Assert.Equal(typeof(JsonException), exception.GetType());
        Assert.Equal("JSON does not meet schema requirements", exception.Message);
    }

    [Fact]
    public void OfficialSample_Failed3()
    {
        // https://blog.json-everything.net/posts/deserialization-with-schemas/
        const string jsonText =
            """
            {
              "Foo": "foo is long enough",
              "Bar": -42,
              "Baz": "May 1, 2023"
            }
            """;
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
    public void OfficialSample_Failed4()
    {
        // https://blog.json-everything.net/posts/deserialization-with-schemas/
        const string jsonText =
            """
            {
              "Foo": "foo is long enough",
              "Bar": -42,
              "Baz": "2023-05-01T02:09:48.54Z"
            }
            """;
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
    public void OfficialSample_CanAccessData()
    {
        // https://blog.json-everything.net/posts/deserialization-with-schemas/
        // cf. https://github.com/dotnet/runtime/issues/85545
        // 日付は`RFC 3339`形式でなければならない
        /*
        const string jsonText = @"{
""Foo"": ""foo is long enough"",
""Bar"": -42,
""Baz"": ""2023-07-11 09:06:42""
}";
        var converter = new ValidatingJsonConverter
        {
            OutputFormat = OutputFormat.List,
            RequireFormatValidation = true
        };
        var options = new JsonSerializerOptions {Converters = {converter}};
        // TODO
        var result = JsonSerializer.Deserialize<MyModel>(jsonText, options);
        var exception = Record.Exception(() =>
            JsonSerializer.Deserialize<MyModel>(jsonText, options));
        Assert.NotNull(exception);
        Assert.Equal(typeof(JsonException), exception.GetType());
        Assert.Equal("JSON does not meet schema requirements", exception.Message);
        */
    }

    [Fact]
    public void OfficialSample_CanDeserialize1()
    {
        // https://qiita.com/hatobeam75/items/c4d7a2d2dc8df697030d
        const string json =
            """
            {
            "CreatedAt":"2020-01-01 00:00:00",
            "UpdatedAt":"2020-01-01 00:00:00"
            }
            """;
        var obj = JsonSerializer.Deserialize<Sample1>(json);
        Assert.NotNull(obj);
        Assert.Equal(new DateTime(2020, 1, 1, 0, 0, 0), obj!.CreatedAt);
        Assert.Equal(new DateTime(2020, 1, 1, 0, 0, 0), obj.UpdatedAt);
    }

    [Fact]
    public void OfficialSample_CanDeserialize2()
    {
        const string jsonText =
            """
            {
            "CreatedAt":"2021-07-11 09:06:42",
            "UpdatedAt":"2021-07-11 09:06:42"
            }
            """;
        var converter = new ValidatingJsonConverter
        {
            OutputFormat = OutputFormat.List,
            RequireFormatValidation = true
        };
        var options = new JsonSerializerOptions {Converters = {converter}};
        var result = JsonSerializer.Deserialize<Sample1>(jsonText, options);

        Assert.NotNull(result);
        Assert.Equal(new DateTime(2021, 7, 11, 9, 6, 42), result!.CreatedAt);
        Assert.Equal(new DateTime(2021, 7, 11, 9, 6, 42), result.UpdatedAt);
    }
}
