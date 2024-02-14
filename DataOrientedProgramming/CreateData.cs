using System.Collections.Immutable;

namespace DataOrientedProgramming;

public static class CreateData
{
    public static ImmutableList<dynamic> ToListDynamic(params dynamic[] inParams)
    {
        var result = new List<dynamic>();
        result.AddRange(inParams);
        return result.ToImmutableList();
    }

    public static ImmutableDictionary<string, dynamic> ToDictionaryDynamic(params dynamic[] inParams)
    {
        if (inParams == null || inParams.Length == 0) throw new ArgumentNullException();

        if (inParams.Length % 2 != 0) throw new ArgumentException("Argument count not even.");

        var result = new Dictionary<string, dynamic>();
        for (var i = 0; i < inParams.Length; i += 2)
        {
            var key = (string) inParams[i];
            var value = inParams[i + 1];
            result.Add(key, value);
        }

        return result.ToImmutableDictionary();
    }
}
