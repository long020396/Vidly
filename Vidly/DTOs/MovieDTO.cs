using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.DTOs
{
    public class MovieDTO
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public byte GenreId { get; set; }

        public GenreDTO Genre { get; set; }

        public DateTime DateAdded { get; }

        public DateTime ReleasedDate { get; set; }

        [Range(1, 20)]
        public byte NumberInStock { get; set; }

        public MovieDTO()
        {
            this.DateAdded = DateTime.Now;
        }
    }
}