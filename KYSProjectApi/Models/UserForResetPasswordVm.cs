using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace KYSProjectApi.Models;

public class UserForResetPasswordVm
{
    [Required(ErrorMessage = "İsim Alanı boş geçilemez.")]
    [MaxLength(50, ErrorMessage = "İsim en fazla 50 karakter olabilir.")]
    [MinLength(2, ErrorMessage = "İsim en az 2 karakter olabilir.")]
    public string Name { get; init; }

    [Required(ErrorMessage = "Soyisim Alanı boş geçilemez.")]
    [MaxLength(50, ErrorMessage = "Soyisim en fazla 50 karakter olabilir.")]
    [MinLength(2, ErrorMessage = "Soyisim en az 2 karakter olabilir.")]
    public string Surname { get; init; }
    [Required(ErrorMessage = "Şifre Alanı boş geçilemez.")]
    [PasswordPropertyText]
    [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[!@#$%^&*]).{4,8}$", ErrorMessage = "Şifre en az bir büyük harf, bir küçük harf, bir rakam ve bir özel karakter içermeli ve 4-8 karakter uzunluğunda olmalıdır.")]
    public string NewPassword { get; set; }
}