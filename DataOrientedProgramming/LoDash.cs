namespace DataOrientedProgramming;

public static class _
{
    public static dynamic Get(dynamic inTarget, params string[] inParams)
    {
        switch (inTarget)
        {
            case Map map:
            {
                var key = inParams[0];
                if (!map.TryGetValue(key, out var result))
                    throw new KeyNotFoundException($"The key {key} not found.");
                var nextParam = inParams.Skip(1).ToArray();
                return nextParam.Length == 0 ? result : Get(result, nextParam);
            }
            case List list:
            {
                var key = inParams[0];

                if (!int.TryParse(key, out var index))
                    return new FormatException($"The key {key} is not a number.");
                if (index < 0 || index >= list.Count)
                    return new IndexOutOfRangeException($"The index {index} is out of range.");

                var result = list[index];
                var nextParam = inParams.Skip(1).ToArray();
                return nextParam.Length == 0 ? result : Get(result, nextParam);
            }
            default: return new Exception();
        }
    }

    public static dynamic Map(IEnumerable<string> inKeys, Func<string, dynamic> inFunction)
    {
        var result = new List();
        result.AddRange(inKeys.Select(key => inFunction(key)));
        return result;
    }
}
