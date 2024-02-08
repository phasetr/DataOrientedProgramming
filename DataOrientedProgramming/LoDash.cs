namespace DataOrientedProgramming;

public static class _
{
    public static dynamic Get(dynamic inTarget, params string[] inParams)
    {
        var dict = inTarget as Map;
        if (dict == null) return inTarget;

        var key = inParams[0];
        var nextParam = inParams.Skip(1).ToArray();

        if (!dict.TryGetValue(key, out var result)) return null;

        return nextParam.Length == 0 ? result : Get(result, nextParam);
    }

    public static dynamic Map(IEnumerable<string> inKeys, Func<string, dynamic> inFunction)
    {
        var result = new List();
        result.AddRange(inKeys.Select(key => inFunction(key)));
        return result;
    }
}
