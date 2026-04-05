using Airbnb.Domain.Abstractions;
using Airbnb.Domain.Users.Events;

namespace Airbnb.Domain.Users;

public class User : Entity
{
    private User(Guid id) : base(id)
    {
        
    }

    public FirstName FirstName { get; private set; }
    public LastName LastName { get; private set; }
    public Email Email { get; private set; }

    public static User Create(FirstName firstName, LastName lastName, Email email)
    {
        var user = new User(Guid.NewGuid())
        {
            FirstName = firstName,
            LastName = lastName,
            Email = email,
        };

        user.RaiseDomainEvent(new UserCreatedEvent(user.Id));

        return user;
    }
}
