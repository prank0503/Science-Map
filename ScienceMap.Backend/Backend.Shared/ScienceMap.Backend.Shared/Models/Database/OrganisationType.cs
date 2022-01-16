using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScienceMap.Backend.Data.Models
{
    [Table("SM_ORGANISATION_TYPE")]
    public class OrganisationType
    {
        [Key]
        [Column("ID")]
        public Guid Id { get; set; }

        [Column("NAME")]
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }
    }
}
