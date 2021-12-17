using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScienceMap.WebServices.Data.Models
{
    [Table("SM_PUB_INFLUENCE")]
    public class PubInfluence
    {
        [Key]
        [Column("ID")]
        public Guid? Id { get; set; }

        [Column("PUB_ID_SOURCE")]
        [ForeignKey("SM_PUBLICATION")]
        [Required]
        public Guid? PubIdSource { get; set; }

        [Column("PUB_ID_TARGET")]
        [ForeignKey("SM_PUBLICATION")]
        [Required]
        public Guid? PubIdTarget { get; set; }

        [Column("PUB_INFLUENCE_TYPE_ID")]
        [ForeignKey("SM_PUB_INFLUENCE_TYPE")]
        [Required]
        public Guid? PubInfluenceTypeId { get; set; }

        [Column("NOTE")]
        [MaxLength(250)]
        public string NOTE { get; set; }

        [Column("CREATED_USER_ID")]
        [Required]
        [ForeignKey("SM_USER")]
        public Guid? CreatedUserId { get; set; }

    }
}
