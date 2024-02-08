namespace Helpers;

public class Accessor
{
    public static dynamic? Get<T>(Dictionary<T, dynamic> data, List<T> path) where T : notnull
    {
        Dictionary<T, dynamic> current = data;
        foreach (var key in path)
            if (current.TryGetValue(key, out dynamic? value1) && value1 is Dictionary<string, dynamic>)
                current = (Dictionary<T, dynamic>) current[key];
            else if (current.TryGetValue(key, out var value2))
                return value2;
            else
                return null;
        return null;
    }
}
