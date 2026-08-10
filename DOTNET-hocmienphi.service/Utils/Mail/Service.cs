using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Configuration;
using MimeKit;

namespace DOTNET_hocmienphi.service.Utils.Mail;

public class Service : IService
{
    private readonly MailOptions _mailOptions = new();

    public Service(IConfiguration configuration)
    {
        configuration.GetSection(nameof(MailOptions)).Bind(_mailOptions);
    }

    public async Task SendMail(MailContent mailContent)
    {
        MimeMessage email = new();
        email.Sender = new MailboxAddress(_mailOptions.DisplayName, _mailOptions.Address);
        email.From.Add(new MailboxAddress(_mailOptions.DisplayName, _mailOptions.Address));
        email.To.Add(MailboxAddress.Parse(mailContent.To));
        email.Subject = mailContent.Subject;
        
        BodyBuilder builder = new()
        {
            HtmlBody = mailContent.Body
        };
        email.Body = builder.ToMessageBody();

        // dùng SmtpClient của MailKit
        using SmtpClient smtp = new();

        await smtp.ConnectAsync(_mailOptions.Host, _mailOptions.Port, SecureSocketOptions.StartTls);
        await smtp.AuthenticateAsync(_mailOptions.Address, _mailOptions.Password);
        await smtp.SendAsync(email);

        await smtp.DisconnectAsync(true);
    }
}