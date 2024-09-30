using System.ComponentModel.DataAnnotations;

namespace DataTransfer.Concrete;

public class UserForForgotPasswordDto
{
    [Required(ErrorMessage ="E-Mail Alanı Boş Geçilemez.")]
    [EmailAddress(ErrorMessage ="E-mail standartlarına uygun bir mail giriniz.")]
    public string Email { get; set; }
}