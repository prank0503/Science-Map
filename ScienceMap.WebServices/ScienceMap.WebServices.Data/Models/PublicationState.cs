using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScienceMap.WebServices.Data.Models
{
    [Table("SM_PUBLICATION_STATE")]
    public class PublicationState
    {
        [Key]
        [Column("ID")]
        public Guid? Id { get; set; }

        [Column("NAME")]
        [MaxLength(20)]
        [Required]
        public string Name { get; set; }
    }
}
