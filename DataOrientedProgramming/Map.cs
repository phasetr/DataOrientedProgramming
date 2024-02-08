namespace DataOrientedProgramming;

public class Map : Dictionary<string, dynamic>
{
    public static Map Of(params dynamic[] inParams)
    {
        if (inParams == null || inParams.Length == 0) throw new ArgumentNullException();

        if (inParams.Length % 2 != 0) throw new ArgumentException("Argument count not even.");

        var result = new Map();
        for (var i = 0; i < inParams.Length; i += 2)
        {
            var key = (string) inParams[i];
            var value = inParams[i + 1];
            result.Add(key, value);
        }

        return result;
    }
}
