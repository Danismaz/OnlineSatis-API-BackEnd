using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace KYSProjectApi.Models
{
    public record UserForChangePasswordVm
    {
        [Required(ErrorMessage = "E-Mail Alanı Boş Geçilemez.")]
        [EmailAddress(ErrorMessage = "E-mail standartlarına uygun bir mail giriniz.")]
        public string Email { get; init; }
        [Required(ErrorMessage = "Şifre Alanı boş geçilemez.")]
        [PasswordPropertyText]
        // [RegularExpression("^[0-9]{3,8}$", ErrorMessage = "Şifre yalnızca sayılardan oluşmalı ve 3-8 karakter uzunluğunda olmalıdır.")]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[!@#$%^&*]).{4,8}$", ErrorMessage = "Şifre en az bir büyük harf, bir küçük harf, bir rakam ve bir özel karakter içermeli ve 4-8 karakter uzunluğunda olmalıdır.")]
        public string OldPassword { get; init; }
        [Required(ErrorMessage = "Şifre Alanı boş geçilemez.")]
        [PasswordPropertyText]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[!@#$%^&*]).{4,8}$", ErrorMessage = "Şifre en az bir büyük harf, bir küçük harf, bir rakam ve bir özel karakter içermeli ve 4-8 karakter uzunluğunda olmalıdır.")]
        public string NewPassword { get; init; }
    }
}
