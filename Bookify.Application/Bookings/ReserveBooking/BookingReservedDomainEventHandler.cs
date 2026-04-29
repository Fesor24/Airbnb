using Airbnb.Domain.Bookings.Events;
using Bookify.Application.Abstractions.Email;
using MediatR;

namespace Bookify.Application.Bookings.ReserveBooking;

internal sealed class BookingReservedDomainEventHandler(IEmailService emailService) : 
    INotificationHandler<BookingReservedDomainEvent>
{
    public readonly IEmailService _emailService = emailService;
    public async Task Handle(BookingReservedDomainEvent notification, CancellationToken cancellationToken)
    {
        Console.WriteLine("Booking reserved. ID: " + notification.BookingId.ToString());

        await _emailService.SendAsync("random-mail@mail.com", "Booking Reserved", "A booking has been reserved");

        await Task.CompletedTask;
    }
}
