using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Helpers;
using System.Xml.Linq;

namespace Forum.Models
{
    public class RegistrationBinding
    {
        public int id { get; set; }

        [Display(Name = "Введите логин")]
        [Required(ErrorMessage = "Это поле обязательно для заполнения")]
        [RegularExpression(@"^\S*$", ErrorMessage = "Логин не должен содержать пробелы")]
        public string login { get; set; }

        [Display(Name = "Введите псевдоним")]
        [Required(ErrorMessage = "Это поле обязательно для заполнения")]
        [RegularExpression(@"^\S*$", ErrorMessage = "Псевдоним не должен содержать пробелы")]
        public string psevdonim { get; set; }

        [Display(Name = "Загрузите фото")]
        [Required(ErrorMessage = "Это поле обязательно для заполнения")]
        [NotMapped]
        public IFormFile photo { get; set; }

        public string? email { get; set; }

        public string? codeWord { get; set; }

        [UIHint("Password")]
        [Display(Name = "Введите пароль")]
        [Required(ErrorMessage = "Это поле обязательно для заполнения")]
        [MinLength(10, ErrorMessage = "Пароль должен быть больше 10 символов ")]
        public string password { get; set; }

        [UIHint("Password")]
        [Display(Name = "Введите повторно пароль")]
        [Required(ErrorMessage = "Это поле обязательно для заполнения")]
        [Compare("password", ErrorMessage = "Пароли не совпадают")]
        public string confirmPassword { get; set; }

        [Display(Name = "Пол")]
        public string sex { get; set; }

        public DateTime registration_time { get; set; }
    }
}
