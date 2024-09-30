namespace KYSProjectApi.Models;

public class CommentVm
{
    
    public string Name { get; set; }
    public string Email { get; set; }
    public string Comment { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
}