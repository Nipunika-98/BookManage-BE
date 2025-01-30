using System;
using System.ComponentModel.DataAnnotations;

namespace BookManage_BE.Models
{
    public class BookDTO
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        [MaxLength(50)]
        public string Author { get; set; }

        public string ISBN { get; set; }

        [Required]
        public DateTime PublicationDate { get; set; }
    }
}
