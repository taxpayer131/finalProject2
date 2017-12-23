using System.ComponentModel.DataAnnotations;

namespace final.Models
{
    public class MovieViewModel
    {
        [Required]
        [MinLength(2)]
        [Display(Name="Movie Title")]
        public string Movie { get; set;}
        
        [Required]
        [MinLength(2)]
        [Display(Name="Director")]
        public string Director { get; set;}

        [Required]
        [Display(Name="Length (in minutes")]
        public int Length { get; set;}
        
    }
}