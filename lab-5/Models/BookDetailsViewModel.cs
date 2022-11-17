using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace lab_5.Models
{    public class BookDetailsViewModel
    {
        [Required]
        public string ISBN { get; set; }

        [Required]
        public int NumberOfPages { get; set; }

        [Required]
        public int Rating { get; set; }

        public int BookId { get; set; }


        public SelectList Books { get; set; }
    }
}
