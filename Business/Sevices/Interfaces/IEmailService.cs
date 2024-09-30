using DataTransfer.Concrete;

namespace Business.Sevices.Interfaces;

public interface IEmailService
{ 
    Task SendEmailAsync(string email, string subject, string htmlMessage);
    Task SendWelcomeEmail(UserForRegisterModel user);
    Task SendPasswordResetEmail(string email, string resetToken);
    Task SendTwoFactorCodeEmail(string email, string twoFactorCode);
    Task ContactUsAsync(ContactUsDto dto, bool isRegistered);
}