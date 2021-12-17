using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScienceMap.WebServices.Data.Models
{
    [Table("SM_SCS_DISCUSSION")]
    public class ClassificationSubjectDiscussion
    {
        [Key]
        [Column("ID")]
        public Guid? Id { get; set; }

        [Column("DISCUSSION_ID")]
        [ForeignKey("SM_DISCUSSION")]
        [Required]
        public Guid? DiscussionId { get; set; }

        [Column("SCS_ID")]
        [ForeignKey("SM_SCS")]
        [Required]
        public Guid? ScsId { get; set; }

        [Column("TITLE")]
        [MaxLength(50)]
        [Required]
        public string Title { get; set; }

        [Column("DESCRIPTION")]
        [MaxLength(80)]
        public string Description { get; set; }

        [Column("INITIATED_USER_ID")]
        [Required]
        [ForeignKey("SM_USER")]
        public Guid? InitiatedUserId { get; set; }

        [Column("INITIATED_DATE")]
        [Required]
        public DateTime? InitiatedDate { get; set; }

        [Column("KEYWORDS")]
        [MaxLength(30)]
        public string Keywords { get; set; }

    }
}
