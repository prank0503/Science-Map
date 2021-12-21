using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScienceMap.WebServices.Data.Models
{
    [Table("SM_PUB_INFLUENCE_TYPE")]
    public class PubInfluenceType
    {
        [Key]
        [Column("ID")]
        public Guid Id { get; set; }

        [Column("NAME")]
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }

        [Column("PUB_INFLUENCE_TYPE_ASSEMENT_ID")]
        [ForeignKey("PubInfluenceTypeAssessment")]
        [Required]
        public Guid PubInfluenceTypeAssementId { get; set; }

        [Column("PUB_INFLUENCE_TYPE_STATE_ID")]
        [ForeignKey("PubInfluenceTypeState")]
        [Required]
        public Guid PubInfluenceTypeStateId { get; set; }

        [Column("DESCRIPTION")]
        [MaxLength(250)]
        public string Description { get; set; }

        #region Back Navigation
        public virtual PubInfluenceTypeAssessment PubInfluenceTypeAssessment { get; set; }
        public virtual PubInfluenceTypeState PubInfluenceTypeState { get; set; }
        #endregion

    }
}
