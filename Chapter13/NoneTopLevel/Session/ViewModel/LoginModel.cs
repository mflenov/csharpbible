using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyWebSite.ViewModel
{
    public class LoginModel:IValidatableObject
    {
        [Required(ErrorMessage = "Email обязателен.")]
        [MaxLength(30, ErrorMessage = "Слишком много букв")]
        [RegularExpression(@"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)" + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$", 
            ErrorMessage = "Неверный формат")]
        public string Email { get; set; }

        [Required]
        [MaxLength(30)]
        public string Password { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Email != "test@email.com")
            {
                yield return new ValidationResult("Неизвестный пользователь", new string[] { "Email" });
            }
            else if (Password != "pass")
            {
                yield return new ValidationResult("Неверный пароль", new string[] { "Password" });
            }
        }
    }
}
