using System.ComponentModel.DataAnnotations;

namespace AccountManagementWebApp.WebUI.DTOs.AccountDTO
{
    public class LoginUserDTO
    {
        [Required(ErrorMessage = "Kullanıcı adını giriniz.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Şifrenizi giriniz.")]
        public string Password { get; set; }
    }
}
