using System.ComponentModel.DataAnnotations;

namespace KYSProjectApi.Models;

public class ForgotPasswordVm
{
    [Required(ErrorMessage ="E-Mail Alanı Boş Geçilemez.")]
    [EmailAddress(ErrorMessage ="E-mail standartlarına uygun bir mail giriniz.")]
    public string Email { get; set; }
}