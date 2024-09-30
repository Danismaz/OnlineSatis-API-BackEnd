namespace Business.Exceptions
{
    public sealed class UserNotFoundException : NotFoundException
    {
        public UserNotFoundException(string email) : base($"Bu {email}'e sahip kullanıcı bulunamadı. Lütfen kayıt olunuz.")
        {
        }
    }
}
