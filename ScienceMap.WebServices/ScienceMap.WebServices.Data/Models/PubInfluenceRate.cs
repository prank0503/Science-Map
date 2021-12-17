using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScienceMap.WebServices.Data.Models
{
    [Table("SM_PUB_INFLUENCE_RATE")]
    public class PubInfluenceRate
    {
        [Key]
        [Column("ID")]
        public Guid? Id { get; set; }

        [Column("DISCUSSION_ID")]
        [ForeignKey("SM_DISCUSSION")]
        [Required]
        public Guid? DiscussionId { get; set; }

        [Column("PUB_INFLUENCE_ID")]
        [ForeignKey("SM_PUB_INFLUENCE")]
        [Required]
        public Guid? PubInfluenceId { get; set; }

        [Column("PUB_INFLUENCE_RATE_TYPE_ID")]
        [ForeignKey("SM_PUB_INFLUENCE_RATE_TYPE")]
        [Required]
        public Guid? PubInfluenceRateTypeId { get; set; }

        [Column("ORIGINATOR_USER_ID")]
        [Required]
        [ForeignKey("SM_USER")]
        public Guid? OriginatorUserId { get; set; }

        [Column("CREATED_DATE")]
        public DateTime CreatedDate { get; set; }


    }
}
