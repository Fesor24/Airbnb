using Airbnb.Domain.Abstractions;

namespace Airbnb.Domain.Bookings.Events;

public sealed record BookingConfirmedDomainEvent(Guid Id) : IDomainEvent;
