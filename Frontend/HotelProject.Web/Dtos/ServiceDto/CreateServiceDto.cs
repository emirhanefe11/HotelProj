using System.ComponentModel.DataAnnotations;

namespace HotelProject.Web.Dtos.ServiceDto
{
    public class CreateServiceDto
    {
        [Required(ErrorMessage ="Servis İkon linki giriniz")] 
        public string ServiceIcon { get; set; }
        [Required(ErrorMessage = "Servis başlığı giriniz")]

        public string Title { get; set; }
        public string Description { get; set; }
    }
}
