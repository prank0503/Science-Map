using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScienceMap.Backend.Data.Models
{
    [Table("SM_PUB_INFLUENCE_TYPE_ASSESSMENT")]
    public class PubInfluenceTypeAssessment
    {
        [Key]
        [Column("ID")]
        public Guid Id { get; set; }

        // TODO: Enum
        [Column("NAME")]
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }
    }
}
