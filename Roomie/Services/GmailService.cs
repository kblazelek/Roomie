using Microsoft.Extensions.Options;
using Roomie.Options;
using System.Net.Mail;
using System.Net;
using Roomie.Domain;

namespace Roomie.Services
{
    public interface IMailService
    {
        Task SendEmailAsync(SendEmailRequest sendEmailRequest);
    }

    public class GmailService : IMailService
    {
        private readonly GmailOptions _gmailOptions;
        private readonly GmailSecrets _gmailSecrets;

        public GmailService(IOptions<GmailOptions> gmailOptions, IOptions<GmailSecrets> gmailSecrets)
        {
            _gmailOptions = gmailOptions.Value;
            _gmailSecrets = gmailSecrets.Value;
        }

        public async Task SendEmailAsync(SendEmailRequest sendEmailRequest)
        {
            MailMessage mailMessage = new MailMessage
            {
                From = new MailAddress(_gmailSecrets.Email),
                Subject = sendEmailRequest.Subject,
                Body = sendEmailRequest.Body
            };

            mailMessage.To.Add(sendEmailRequest.Recipient);

            using var smtpClient = new SmtpClient();
            smtpClient.Host = _gmailOptions.Host;
            smtpClient.Port = _gmailOptions.Port;
            smtpClient.Credentials = new NetworkCredential(
                _gmailSecrets.Email, _gmailSecrets.Password);
            smtpClient.EnableSsl = true;

            await smtpClient.SendMailAsync(mailMessage);
        }
    }
}
