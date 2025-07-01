using System.ComponentModel.DataAnnotations;

namespace HotelProject.Web.Dtos.RegisterDto
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage ="İsim Boş geçilemez")]
        public string Name { get; set; }
        
        [Required(ErrorMessage ="Soyad Boş geçilemez")]
        public string Surname { get; set; }
        [Required(ErrorMessage ="Kullanıcı Adı Boş geçilemez")]
        public string UserName { get; set; }
        [Required(ErrorMessage ="Mail Boş geçilemez")]
        public string Mail { get; set; }
        [Required(ErrorMessage ="Şifre Boş geçilemez")]
        public string Password { get; set; }
        [Required(ErrorMessage ="Şifre Tekrar Alanı Boş geçilemez")]
        [Compare("Password",ErrorMessage ="Şifreler Aynı Olmalıdır")]
        public string ConfirmPassword { get; set; }
        
    }
}
