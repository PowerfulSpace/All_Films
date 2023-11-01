using System.ComponentModel.DataAnnotations;

namespace PS.All_Films.Web.Models
{
    public class Movie
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(25)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(75)]
        public string Description { get; set; } = null!;

        [Required]
        [Range(0, 10)]
        public double Rating { get; set; }
    }
}
