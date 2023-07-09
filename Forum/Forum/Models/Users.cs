using System.ComponentModel.DataAnnotations;

namespace Forum.Models
{
    public class Users
    {
        public int id { get; set; }

        [Display(Name = "Введите логин")]
        [Required(ErrorMessage = "Это поле обязательно для заполнения")]
        public string login { get; set; }
        
        [Display(Name = "Введите псевдоним")]
        [Required(ErrorMessage = "Это поле обязательно для заполнения")]
        public string psevdonim { get; set; }

        [Display(Name = "Загрузите фото")]
        [Required(ErrorMessage = "Это поле обязательно для заполнения")]
        public string photo { get; set; }

        public bool isRecovery { get; set; }

        [Display(Name = "Введите почту")]
        [Required(ErrorMessage = "Это поле обязательно для заполнения")]
        public string email { get; set; }

        [Display(Name = "Введите кодовое слово")]
        [Required(ErrorMessage = "Это поле обязательно для заполнения")]
        public string codeWord { get; set; }

        [Display(Name = "Введите пароль")]
        [Required(ErrorMessage = "Это поле обязательно для заполнения")]
        [MinLength(10, ErrorMessage = "Пароль должен быть больше 10 символов ")]
        public string password { get; set; }

        public string roles { get; set; }
        public bool isActive { get; set; }
        public string sex { get; set; }
        public bool isTrusted { get; set; }
        public bool isDeleted { get; set; }
        public DateTime registration_time { get; set; }
    }
}
