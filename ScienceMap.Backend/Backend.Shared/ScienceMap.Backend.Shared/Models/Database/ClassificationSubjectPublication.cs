using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScienceMap.Backend.Data.Models
{
    [Table("SM_SCS_PUBLICATION")]
    public class ClassificationSubjectPublication
    {
        [Key]
        [Column("ID")]
        public Guid Id { get; set; }

        [Column("SCS_ID")]
        [ForeignKey("ClassificationSubject")]
        [Required]
        public Guid ScsId { get; set; }

        [Column("PUBLICATION_ID")]
        [ForeignKey("Publication")]
        [Required]
        public Guid PublicationId { get; set; }

        [Column("SCS_PUBLICATION_STATE_ID")]
        [ForeignKey("ClassificationSubjectPublicationState")]
        [Required]
        public Guid ScsPublicationStateId { get; set; }

        [Column("ORIGINATOR_USER_ID")]
        [ForeignKey("User")]
        [Required]
        public Guid OriginatorUserId { get; set; }

        #region Back Navigation
        public virtual Publication Publication { get; set; }
        public virtual ClassificationSubject ClassificationSubject { get; set; }
        public virtual ClassificationSubjectPublicationState ClassificationSubjectPublicationState { get; set; }
        public virtual User User { get; set; }
        #endregion
    }
}
