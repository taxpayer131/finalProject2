using System.ComponentModel.DataAnnotations;
 
namespace final.Models
{
    public class Movie
    {
        public int MovieId {get; set;}
        public string Title { get; set; }

        public string Director { get; set; }
        public int Length { get; set; }
    }
}