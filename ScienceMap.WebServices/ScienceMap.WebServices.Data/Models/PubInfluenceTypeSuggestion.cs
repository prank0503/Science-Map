using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScienceMap.WebServices.Data.Models
{
    [Table("SM_PUB_INFLUENCE_TYPE_SUGGESTION")]
    public class PubInfluenceTypeSuggestion
    {
        [Key]
        [Column("ID")]
        public Guid Id { get; set; }

        [Column("SUGGESTED_USER_ID")]
        [ForeignKey("User")]
        [Required]
        public Guid SuggestedUserId { get; set; }

        [Column("PUB_INFLUENCE_TYPE_ID")]
        [ForeignKey("PubInfluenceType")]
        [Required]
        public Guid PubInfluenceTypeId { get; set; }

        #region Back Navigation
        public virtual PubInfluenceType PubInfluenceType { get; set; }
        public virtual User User { get; set; }
        #endregion
    }
}
