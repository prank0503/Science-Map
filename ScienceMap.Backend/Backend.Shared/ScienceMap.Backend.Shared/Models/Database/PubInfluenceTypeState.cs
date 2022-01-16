using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScienceMap.Backend.Data.Models
{
    [Table("SM_PUB_INFLUENCE_TYPE_STATE")]
    public class PubInfluenceTypeState
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
