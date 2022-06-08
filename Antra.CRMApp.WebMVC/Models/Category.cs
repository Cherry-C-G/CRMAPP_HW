using System.ComponentModel.DataAnnotations;

namespace Antra.CRMApp.WebMVC.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string CategoryName { get; set; }

        public bool Status { get; set; }

    }
}
