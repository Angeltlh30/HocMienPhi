namespace DOTNET_hocmienphi.service.Utils.Mail;

public interface IService
{
    public Task SendMail(MailContent mailContent);
}