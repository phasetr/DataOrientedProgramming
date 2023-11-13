using System.Text.Json.Nodes;
using AppendixA.A._4;
using Json.Schema;

namespace Test.Unit.AppendixA.A._4;

public class AuthorRequestSchemaTests
{
    [Fact]
    public void AuthorRequestSchema_Succeeded1()
    {
        const string validAuthorData = @"{
  ""FirstName"": ""Isaac"",
  ""LastName"": ""Asimov"",
  ""Books"": 500
}";
        var schema = Schemas.AuthorRequestSchema;
        var jsonNode = JsonNode.Parse(validAuthorData);
        var evaluationOptions = new EvaluationOptions {OutputFormat = OutputFormat.List};
        var validationResults = schema.Evaluate(jsonNode, evaluationOptions);

        Assert.NotNull(validationResults);
        Assert.True(validationResults.IsValid);
        Assert.Null(validationResults.Errors);
    }

    [Fact]
    public void AuthorRequestSchema_Succeeded2()
    {
        const string validAuthorData = @"{
  ""FirstName"": ""Isaac"",
  ""LastName"": ""Asimov"",
  ""Books"": 500
}";
        var schema = Schemas.AuthorRequestSchema;
        var jsonNode = JsonNode.Parse(validAuthorData);
        var evaluationOptions = new EvaluationOptions {OutputFormat = OutputFormat.Flag};
        var validationResults = schema.Evaluate(jsonNode, evaluationOptions);

        Assert.NotNull(validationResults);
        Assert.True(validationResults.IsValid);
    }

    [Fact]
    public void AuthorRequestSchema_Failed_BooksIsString1()
    {
        const string validAuthorData = @"{
  ""FirstName"": ""Isaac"",
  ""LastName"": ""Asimov"",
  ""Books"": ""five hundred""
}";
        var schema = Schemas.AuthorRequestSchema;
        var jsonNode = JsonNode.Parse(validAuthorData);
        var evaluationOptions = new EvaluationOptions {OutputFormat = OutputFormat.List};
        var validationResults = schema.Evaluate(jsonNode, evaluationOptions);

        Assert.NotNull(validationResults);
        Assert.False(validationResults.IsValid);
        var booksResult = validationResults.Details[3];
        Assert.False(booksResult.IsValid);
        Assert.NotNull(booksResult.Errors);
        Assert.Equal(@"Value is ""string"" but should be ""integer""",
            booksResult.Errors!["type"]);
    }
    
    [Fact]
    public void AuthorRequestSchema_Failed_BooksIsString2()
    {
        const string validAuthorData = @"{
  ""FirstName"": ""Isaac"",
  ""LastName"": ""Asimov"",
  ""Books"": ""five hundred""
}";
        var schema = Schemas.AuthorRequestSchema;
        var jsonNode = JsonNode.Parse(validAuthorData);
        var evaluationOptions = new EvaluationOptions {OutputFormat = OutputFormat.Flag};
        var validationResults = schema.Evaluate(jsonNode, evaluationOptions);

        Assert.NotNull(validationResults);
        Assert.False(validationResults.IsValid);
    }
}
