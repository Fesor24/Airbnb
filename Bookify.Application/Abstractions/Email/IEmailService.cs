namespace Bookify.Application.Abstractions.Email;

internal interface IEmailService
{
    Task SendAsync(string email, string subject, string body);
}
