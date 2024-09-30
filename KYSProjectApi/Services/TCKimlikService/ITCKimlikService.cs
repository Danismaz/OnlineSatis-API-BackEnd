namespace KYSProjectApi.Services.TCKimlikService
{
    public interface ITCKimlikService
    {
        Task<bool> VerifyTcKimlikNoAsync(string tcKimlikNo, string ad, string soyad, DateTime dogumTarihi);
    }
}
