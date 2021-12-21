using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScienceMap.WebServices.Data.Models
{
    [Table("SM_PUB_INFLUENCE_RATE_TYPE")]
    public class PubInfluenceRateType
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
