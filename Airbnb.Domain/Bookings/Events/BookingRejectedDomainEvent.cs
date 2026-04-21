using Airbnb.Domain.Abstractions;

namespace Airbnb.Domain.Bookings.Events;

public sealed record BookingRejectedDomainEvent(Guid Id) : IDomainEvent;
