using System.ComponentModel.DataAnnotations;

namespace Xtd.AngularWebApp.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}