using System.ComponentModel.DataAnnotations;

namespace Lost_in_the_Woods.Models
{
    public class TrailViewModel : BaseEntity
    {
        [Required]
        [Display(Name = "Trail Name")]
        public string Name { get; set; }
        [Required]
        [MinLength (10)]
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Required]
        [Display(Name = "Trail Length")]
        public float Length { get; set; }
        [Required]
        [Display(Name = "Elevation Change")]
        public float Elevation { get; set; }
        [Required]
        [Display(Name = "Longitude")]
        public double Longitude { get; set; }
        [Required]
        [Display(Name = "Latitude")]
        public double Latitude { get; set; }
    }
}