using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lab_5.Models
{
    public class BookDetails
    {
        [ForeignKey("Book")]
        public int BookDetailsId { get; set; }

        [Required]
        public string ISBN { get; set; }

        [Required]
        public int NumberOfPages { get; set; }

        [Required]
        public int Rating { get; set; }

        public virtual Book Book { get; set; }
    }
}
