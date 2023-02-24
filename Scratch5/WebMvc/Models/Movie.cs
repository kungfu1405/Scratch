using System;
using System.ComponentModel.DataAnnotations;

namespace WebMvc.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        [MaxLength(6)]
        [MinLength(2,ErrorMessage ="min value")]
        public decimal Price { get; set; }
        public string? Rating { get; set; }
    }
}
    