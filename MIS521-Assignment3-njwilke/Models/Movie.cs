using System.ComponentModel.DataAnnotations;

namespace MIS521_Assignment3_njwilke.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Genre {  get; set; }

        [Display(Name = "Release Year")]
        public int YearOfRelease {  get; set; }

        [Display(Name = "IMDB Page")]
        public string HyperLink { get; set; }

        [Display(Name = "Movie Poster")]
        public string? ImageURL {  get; set; }
    }
}
