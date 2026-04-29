using Bookify.Application.Abstractions.Messaging;

namespace Bookify.Application.Bookings.GetBooking;

internal sealed record GetBookingQuery(Guid BookingId) : IQuery<BookingResponse>;
