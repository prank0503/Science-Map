using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScienceMap.Backend.Data.Models
{
    [Table("SM_SCS_PUBLICATION_STATE")]
    public class ClassificationSubjectPublicationState
    {
        [Key]
        [Column("ID")]
        public Guid Id { get; set; }

        [Column("NAME")]
        [MaxLength(20)]
        [Required]
        public string Name { get; set; }
    }
}
