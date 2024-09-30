using Business.Sevices.Interfaces;

namespace Business.Sevices.Concrete;

public class TwoFactorAuthService : ITwoFactorAuthService
{
    private readonly IEmailService _email;
    private readonly Dictionary<string, (string Code, DateTime Expiry)> _verificationCodes = new Dictionary<string, (string Code, DateTime Expiry)>();
    private readonly TimeSpan _codeValidityPeriod = TimeSpan.FromMinutes(5); // Kodun geçerlilik süresi
    private static readonly Random _random = new Random();
    private readonly object _lock = new object();

    public TwoFactorAuthService(IEmailService email)
    {
        _email = email;
    }

    public async Task SendVerificationCodeAsync(string email)
    {
        string code;
        lock (_lock)
        {
            code = GenerateVerificationCode();
            var expiry = DateTime.UtcNow.Add(_codeValidityPeriod);
            _verificationCodes[email] = (code, expiry);
        }

        await _email.SendTwoFactorCodeEmail(email, code);
    }


    // Kod doğrulama
    public bool ValidateCode(string email, string code)
    {
        if (_verificationCodes.TryGetValue(email, out var record))
        {
            if (record.Code == code && record.Expiry > DateTime.UtcNow)
            {
                // Kod doğru ve süresi geçmemiş
                _verificationCodes.Remove(email); // Kod bir kez kullanıldıktan sonra kaldırılabilir
                return true;
            }
        }

        // Kod yanlış veya süresi dolmuş
        return false;
    }

    // Kod üretimi
    private string GenerateVerificationCode()
    {
        return _random.Next(100000, 999999).ToString("D6");
    }
}