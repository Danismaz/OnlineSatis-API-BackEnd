using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace KYSProjectApi.Models
{
    public record UserForRegisterVm
    {
        [Required(ErrorMessage = "E-Mail Alanı Boş Geçilemez.")]
        [EmailAddress(ErrorMessage = "E-mail standartlarına uygun bir mail giriniz.")]
        public string Email { get; init; }
        [Required(ErrorMessage = "Şifre Alanı boş geçilemez.")]
        [PasswordPropertyText]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[!@#$%^&*]).{4,8}$", ErrorMessage = "Şifre en az bir büyük harf, bir küçük harf, bir rakam ve bir özel karakter içermeli ve 4-8 karakter uzunluğunda olmalıdır.")]
        //[RegularExpression("^[0-9]{3,8}$", ErrorMessage = "Şifre yalnızca sayılardan oluşmalı ve 3-8 karakter uzunluğunda olmalıdır.")]
        public string Password { get; init; }
        [Required(ErrorMessage = "Telefon Numarası Alanı boş geçilemez.")]
        [Phone(ErrorMessage = "Lütfen geçerli bir telefon numarası giriniz.")]
        [RegularExpression(@"^\+\d{12}$", ErrorMessage = "Telefon numarası '+905325323232' gibi olmalıdır.")]
        public string MobilePhone { get; init; }

        [Required(ErrorMessage = "İsim Alanı boş geçilemez.")]
        [MaxLength(50, ErrorMessage = "İsim en fazla 50 karakter olabilir.")]
        [MinLength(2, ErrorMessage = "İsim en az 2 karakter olabilir.")]
        public string Name { get; init; }

        [Required(ErrorMessage = "Soyisim Alanı boş geçilemez.")]
        [MaxLength(50, ErrorMessage = "Soyisim en fazla 50 karakter olabilir.")]
        [MinLength(2, ErrorMessage = "Soyisim en az 2 karakter olabilir.")]
        public string Surname { get; init; }

        [Required(ErrorMessage = "Kimlik Numarası Alanı boş geçilemez.")]
        [RegularExpression(@"^\d{11}$", ErrorMessage = "Kimlik numarası 11 haneli olmalıdır.")]
        public string IdentityNumber { get; init; }

        [Required(ErrorMessage = "Doğum Tarihi Alanı boş geçilemez.")]
        [DataType(DataType.Date, ErrorMessage = "Geçerli bir doğum tarihi giriniz.")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime BirthDate { get; init; }
    }
}
