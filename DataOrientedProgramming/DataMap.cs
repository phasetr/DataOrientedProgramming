namespace DataOrientedProgramming;

public class DataMap
{
    public dynamic Value { get; } = null;

    public bool SetData(dynamic inValue, params string[] inParam)
    {
        var currentNode = Value;

        for (var i = 0; i < inParam.Length; i++)
            if (currentNode == null)
            {
                currentNode = new Dictionary<string, dynamic>();
            }
            else if (currentNode is Dictionary<string, dynamic>)
            {
                var currentHashtable = currentNode as Dictionary<string, dynamic>;
                if (currentHashtable.ContainsKey(inParam[i]))
                {
                    currentNode = currentHashtable[inParam[i]];
                }
                else
                {
                    currentHashtable.Add(inParam[i],
                        i == inParam.Length - 1 ? inValue : new Dictionary<string, dynamic>());
                    currentNode = currentHashtable[inParam[i]];
                }
            }

        return true;
    }
}
