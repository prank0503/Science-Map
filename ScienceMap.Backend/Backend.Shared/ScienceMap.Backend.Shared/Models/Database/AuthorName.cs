using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScienceMap.Backend.Data.Models
{
    [Table("SM_AUTHOR_NAME")]
    public class AuthorName
    {
        [Key]
        [Column("ID")]
        public Guid Id { get; set; }

        [Column("FIRST_NAME")]
        [MaxLength(30)]
        [Required]
        public string FirstName { get; set; }

        [Column("MIDDLE_NAME")]
        [MaxLength(30)]
        public string MiddleName { get; set; }

        [Column("LAST_NAME")]
        [MaxLength(30)]
        public string LastName { get; set; }

    }
}
