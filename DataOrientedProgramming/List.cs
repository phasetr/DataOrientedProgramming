namespace DataOrientedProgramming;

public class List : List<dynamic>
{
    public static List Of(params dynamic[] inParams)
    {
        var result = new List();
        result.AddRange(inParams);
        return result;
    }
}
