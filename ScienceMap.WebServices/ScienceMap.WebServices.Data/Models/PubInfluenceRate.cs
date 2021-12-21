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
        public Guid Id { get; set; }

        [Column("DISCUSSION_ID")]
        [ForeignKey("Discussion")]
        [Required]
        public Guid DiscussionId { get; set; }

        [Column("PUB_INFLUENCE_ID")]
        [ForeignKey("PubInfluence")]
        [Required]
        public Guid PubInfluenceId { get; set; }

        [Column("PUB_INFLUENCE_RATE_TYPE_ID")]
        [ForeignKey("PubInfluenceRateType")]
        [Required]
        public Guid PubInfluenceRateTypeId { get; set; }

        [Column("ORIGINATOR_USER_ID")]
        [Required]
        [ForeignKey("User")]
        public Guid OriginatorUserId { get; set; }

        [Column("CREATED_DATE")]
        public DateTime CreatedDate { get; set; }

        #region Back Navigation
        public virtual Discussion Discussion { get; set; }
        public virtual PubInfluence PubInfluence { get; set; }
        public virtual PubInfluenceRateType PubInfluenceRateType { get; set; }
        public virtual User User { get; set; }
        #endregion
    }
}
