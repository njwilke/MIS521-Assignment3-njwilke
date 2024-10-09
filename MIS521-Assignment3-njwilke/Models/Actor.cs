using System.ComponentModel.DataAnnotations;

namespace MIS521_Assignment3_njwilke.Models
{
    public class Actor
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Gender { get; set; }

        [Display(Name = "IMDB Page")]
        public string? HyperLink { get; set; }

        [Display(Name = "Actor Picture")]
        public string? ActorImage { get; set; }
    }
}
