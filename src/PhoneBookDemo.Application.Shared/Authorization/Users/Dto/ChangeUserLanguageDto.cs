using System.ComponentModel.DataAnnotations;

namespace PhoneBookDemo.Authorization.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
