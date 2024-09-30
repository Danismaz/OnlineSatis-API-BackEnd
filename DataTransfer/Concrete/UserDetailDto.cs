namespace DataTransfer.Concrete;

public class UserDetailDto
{
    public Int64 UserDetailCode { get; set; }
    public Int64 UserCode { get; set; }
    public string Email { get; set; }
    public string MobilePhone { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string IdentityNumber { get; set; }
    public DateTime BirthDate { get; set; }
}