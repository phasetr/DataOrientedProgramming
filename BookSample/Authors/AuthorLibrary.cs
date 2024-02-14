using DataOrientedProgramming;

namespace BookSample.Authors;

public static class AuthorLibrary
{
    /// <summary>
    ///     リスト3-14で定義。
    /// </summary>
    /// <param name="catalogData"></param>
    /// <param name="book"></param>
    /// <returns></returns>
    public static List<string> AuthorNames(Dictionary<string, dynamic> catalogData, Dictionary<string, dynamic> book)
    {
        var authorIds = (List<dynamic>) _.Get(book, "authorIds");
        return authorIds
            .Select(authorId => (string) _.Get(catalogData, "authorsById", authorId, "name"))
            .ToList() ?? [];
    }
}
