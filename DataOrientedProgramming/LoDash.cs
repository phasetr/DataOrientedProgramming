namespace DataOrientedProgramming;

public static class _
{
    public static dynamic Get(dynamic inTarget, params string[] inParams)
    {
        switch (inTarget)
        {
            case Map map:
            {
                var dict = map;
                var key = inParams[0];
                var nextParam = inParams.Skip(1).ToArray();

                if (!dict.TryGetValue(key, out var result)) return null;

                return nextParam.Length == 0 ? result : Get(result, nextParam);
            }
            case List list:
            {
                var key = inParams[0];
                var nextParam = inParams.Skip(1).ToArray();

                if (!int.TryParse(key, out var index)) return null;

                if (index < 0 || index >= list.Count) return null;

                var result = list[index];

                return nextParam.Length == 0 ? result : Get(result, nextParam);
            }
            default: return null;
        }
    }

    public static dynamic Map(IEnumerable<string> inKeys, Func<string, dynamic> inFunction)
    {
        var result = new List();
        result.AddRange(inKeys.Select(key => inFunction(key)));
        return result;
    }
}
