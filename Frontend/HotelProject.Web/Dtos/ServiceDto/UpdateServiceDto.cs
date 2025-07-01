using System.ComponentModel.DataAnnotations;

namespace HotelProject.Web.Dtos.ServiceDto
{
    public class UpdateServiceDto
    {

        public int ServiceID { get; set; }
        [Required(ErrorMessage = "Servis İkon linki giriniz")]
        public string ServiceIcon { get; set; }
        [Required(ErrorMessage = "Servis başlığı giriniz")]

        public string Title { get; set; }
        [Required(ErrorMessage = "Servis açıklaması giriniz")]

        public string Description { get; set; }
    }
}
