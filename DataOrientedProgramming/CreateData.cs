namespace DataOrientedProgramming;

public static class CreateData
{
    public static List<dynamic> ToListDynamic(params dynamic[] inParams)
    {
        var result = new List<dynamic>();
        result.AddRange(inParams);
        return result;
    }
}
