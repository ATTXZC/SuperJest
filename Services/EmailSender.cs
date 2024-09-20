using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Eco_life.Models;

namespace Eco_life.Services
{
public class EmailSender : IEmailSender
{
    private readonly SmtpSettings _smtpSettings;

    public EmailSender(IOptions<SmtpSettings> smtpSettings)
    {
        _smtpSettings = smtpSettings.Value ?? throw new ArgumentNullException(nameof(smtpSettings));
    }

    public async Task SendEmailAsync(string to, string subject, string message)
    {
        if (string.IsNullOrEmpty(_smtpSettings.Username))
        {
            throw new InvalidOperationException("SMTP username is not configured.");
        }

        if (string.IsNullOrEmpty(_smtpSettings.Host))
        {
            throw new InvalidOperationException("SMTP host is not configured.");
        }

        if (string.IsNullOrEmpty(to))
        {
            throw new ArgumentException("Recipient address cannot be null or empty.", nameof(to));
        }

        var smtpClient = new SmtpClient(_smtpSettings.Host)
        {
            Port = _smtpSettings.Port,
            Credentials = new NetworkCredential(_smtpSettings.Username, _smtpSettings.Password),
            EnableSsl = true,
        };

        var mailMessage = new MailMessage
        {
            From = new MailAddress(_smtpSettings.Username ?? throw new InvalidOperationException("SMTP username is not configured.")),
            Subject = subject,
            Body = message,
            IsBodyHtml = true,
        };

        mailMessage.To.Add(to);

        await smtpClient.SendMailAsync(mailMessage);
    }
}

}
