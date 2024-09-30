using System.ComponentModel.DataAnnotations;

namespace KYSProjectApi.Models;

public class Verify2FACodeVm
{
    [Required(ErrorMessage ="E-Mail Alanı Boş Geçilemez.")]
    [EmailAddress(ErrorMessage ="E-mail standartlarına uygun bir mail giriniz.")]
    public string Email { get; set; }
    [Required(ErrorMessage = "Kod alanı boş geçilemez.")]
    [StringLength(6, MinimumLength = 6, ErrorMessage = "Kod 6 karakter uzunluğunda olmalıdır.")]
    public string Code { get; set; }
}