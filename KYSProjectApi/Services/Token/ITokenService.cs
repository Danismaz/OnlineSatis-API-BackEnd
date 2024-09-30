using DataTransfer.Concrete;

namespace KYSProjectApi.Services.Token
{
    public interface ITokenService
    {
        Task<string> GenerateTokenAsync(string email);
        bool ValidateTokenAsync(string token);
        Task<UserForLoginDto> GetUserFromTokenAsync(string token);
        string GetEmailFromToken(string token);
        void AddToBlacklist(string token);
        bool IsTokenBlacklisted(string token);
    }
}
