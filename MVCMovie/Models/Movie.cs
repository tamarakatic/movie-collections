using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace MVCMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)] //validation for length
        public string Title { get; set; }

        //validation rules for realeasedate
        [Display(Name= "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        //validation rules for genre
        [RegularExpression(@"^[A-Z] + [a-zA-Z''-'\s]*$")]
        [Required]
        [StringLength(20)]
        public string Genre { get; set; }

        //validation rules for price
        [Range(1,100)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        //validation rules for raiting
        [RegularExpression(@"^[A-Z] + [a-zA-Z''-'\s]*$")]
        [StringLength(5)]
        public string Rating { get; set; }
    }

    public class MovieDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

    }
}