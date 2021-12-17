using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScienceMap.WebServices.Data.Models
{
    [Table("SM_SCS_PUBLICATION")]
    public class ClassificationSubjectPublication
    {
        [Key]
        [Column("ID")]
        public Guid? Id { get; set; }

        [Column("SCS_ID")]
        [ForeignKey("SM_SCS")]
        [Required]
        public Guid? ScsId { get; set; }

        [Column("PUBLICATION_ID")]
        [ForeignKey("SM_PUBLICATION")]
        [Required]
        public Guid? PublicationId { get; set; }

        [Column("SCS_PUBLICATION_STATE_ID")]
        [ForeignKey("SM_SCS_PUBLICATION_STATE")]
        [Required]
        public Guid? ScsPublicationStateId { get; set; }

        [Column("ORIGINATOR_USER_ID")]
        [ForeignKey("SM_USER")]
        [Required]
        public Guid? OriginatorUserId { get; set; }
    }
}
