using System.ComponentModel.DataAnnotations;

namespace HotelProject.Web.Dtos.LoginDto
{
    public class LoginUserDto
    {
        [Required(ErrorMessage ="Kullanıcı Adını giriniz")]
        public string Username { get; set; }

        [Required(ErrorMessage ="Şifreyi Giriniz")]
        public string Password { get; set; }
    }
}
