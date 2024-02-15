using System.Collections.Immutable;

namespace DataOrientedProgramming;

public static class _
{
    /// <summary>
    ///     `map`の`path`にある値を取得する
    /// </summary>
    /// <param name="map"></param>
    /// <param name="path"></param>
    /// <returns></returns>
    public static dynamic? Get(dynamic map, params string[] path)
    {
        switch (map)
        {
            case ImmutableDictionary<string, dynamic> dict:
            {
                var key = path[0];
                if (!dict.TryGetValue(key, out var result))
                    return null;
                var nextParam = path.Skip(1).ToArray();
                return nextParam.Length == 0 ? result : Get(result, nextParam);
            }
            case ImmutableList<dynamic> list:
            {
                var key = path[0];

                if (!int.TryParse(key, out var index))
                    return new FormatException($"The key {key} is not a number.");
                if (index < 0 || index >= list.Count)
                    return new IndexOutOfRangeException($"The index {index} is out of range.");

                var result = list[index];
                var nextParam = path.Skip(1).ToArray();
                return nextParam.Length == 0 ? result : Get(result, nextParam);
            }
            default: return new Exception();
        }
    }

    /// <summary>
    ///     `map`に`path`があるかどうかを調べる
    /// </summary>
    /// <param name="map"></param>
    /// <param name="path"></param>
    /// <returns></returns>
    public static bool Has(ImmutableDictionary<string, dynamic> map, params string[] path)
    {
        return Get(map, path) != null;
    }
}
