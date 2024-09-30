namespace Business.Sevices.Interfaces;

public interface ITwoFactorAuthService
{
    Task SendVerificationCodeAsync(string email);
    bool ValidateCode(string email, string code);
}