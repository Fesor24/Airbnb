using Airbnb.Domain.Abstractions;

namespace Airbnb.Domain.Users;

public static class UserErrors
{
    public static Error NotFound = new("User.NotFound", "User not found");
}
