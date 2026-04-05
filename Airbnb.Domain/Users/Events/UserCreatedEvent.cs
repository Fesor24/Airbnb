using Airbnb.Domain.Abstractions;

namespace Airbnb.Domain.Users.Events;

public sealed record UserCreatedEvent(Guid UserId) : IDomainEvent;
