namespace Roomie.Domain
{
    public record SendEmailRequest(string Recipient, string Subject, string Body);
}
