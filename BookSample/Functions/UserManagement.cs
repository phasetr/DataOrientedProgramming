using System.Collections.Immutable;
using DataOrientedProgramming;

namespace BookSample.Functions;

public static class UserManagement
{
    /// <summary>
    /// P.79, リスト3-20
    /// </summary>
    /// <param name="userManagementData"></param>
    /// <param name="email"></param>
    /// <returns></returns>
    public static bool IsLibrarian(ImmutableDictionary<string, dynamic> userManagementData, string email)
    {
        var dict = (ImmutableDictionary<string, dynamic>) _.Get(userManagementData, "librariansByEmail", email);
        return dict.ContainsValue(email);
    }

    /// <summary>
    /// P.80, リスト3-30
    /// </summary>
    /// <param name="userManagementData"></param>
    /// <param name="email"></param>
    /// <returns></returns>
    public static bool IsVipMember(ImmutableDictionary<string,dynamic> userManagementData, string email)
    {
        return (bool) _.Get(userManagementData, "membersByEmail", email, "isVIP");
    }

    /// <summary>
    /// P.80, リスト3-30
    /// </summary>
    /// <param name="userManagementData"></param>
    /// <param name="email"></param>
    /// <returns></returns>
    public static bool IsSuperMember(ImmutableDictionary<string,dynamic> userManagementData, string email)
    {
        return (bool) _.Get(userManagementData, "membersByEmail", email, "isSuper");
    }
}
