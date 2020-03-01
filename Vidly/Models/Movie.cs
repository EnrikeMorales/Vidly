using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Favor de escribir nombre")]
        public string Name { get; set; }        
        public Genre Genre { get; set; }

        [Display(Name = "Genero")]
        [Required(ErrorMessage = "Favor de seleccionar genero")]
        public int GenreId { get; set; }

        [Required(ErrorMessage = "Favor de escribir fecha")]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public DateTime DateAdded { get; set; }

        [Required]
        [Range(1, 20)]
        public int Stock { get; set; }       
    }
}