using System.ComponentModel.DataAnnotations;

namespace Antra.CRMApp.WebMVC.Models
{
    public class Vender
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public string City { get; set; }
        public string Country { get; set; }
        public string Mobile { get; set; }

        public string EmailId { get; set; }
        public bool IsActive { get; set; }

    }
}
