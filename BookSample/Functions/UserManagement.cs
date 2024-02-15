using System.Collections.Immutable;
using DataOrientedProgramming;

namespace BookSample.Functions;

public static class UserManagement
{
    public static bool IsLibrarian(ImmutableDictionary<string, dynamic> userManagementData, string email)
    {
        var dict = (ImmutableDictionary<string, dynamic>) _.Get(userManagementData, "librariansByEmail", email);
        return dict.ContainsValue(email);
    }
}
