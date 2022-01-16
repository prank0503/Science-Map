using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScienceMap.Backend.Data.Models
{
    [Table("SM_PUB_INFLUENCE")]
    public class PubInfluence
    {
        [Key]
        [Column("ID")]
        public Guid Id { get; set; }

        [Column("PUB_ID_SOURCE")]
        [ForeignKey("PublicationSource")]
        [Required]
        public Guid PubIdSource { get; set; }

        [Column("PUB_ID_TARGET")]
        [ForeignKey("PublicationTarget")]
        [Required]
        public Guid PubIdTarget { get; set; }

        [Column("PUB_INFLUENCE_TYPE_ID")]
        [ForeignKey("PubInfluenceType")]
        [Required]
        public Guid PubInfluenceTypeId { get; set; }

        [Column("NOTE")]
        [MaxLength(250)]
        public string NOTE { get; set; }

        [Column("CREATED_USER_ID")]
        [Required]
        [ForeignKey("User")]
        public Guid CreatedUserId { get; set; }

        #region Back Navigation
        public virtual Publication PublicationSource { get; set; }
        public virtual Publication PublicationTarget { get; set; }
        public virtual PubInfluenceType PubInfluenceType { get; set; }
        public virtual User User { get; set; }
        #endregion

    }
}
