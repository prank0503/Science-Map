using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScienceMap.WebServices.Data.Models
{
    [Table("SM_DISCUSSION_ENTRY")]
    public class DiscussionEntry
    {
        [Key]
        [Column("ID")]
        public Guid? Id { get; set; }

        [Column("DISCUSSION_ID")]
        [ForeignKey("SM_DISCUSSION")]
        [Required]
        public Guid? DiscussionId { get; set; }

        [Column("PARENT_ID")]
        public Guid ParentId { get; set; }

        [Column("TEXT")]
        [MaxLength(100)]
        [Required]
        public string Text { get; set; }

        [Column("CREATED_USER_ID")]
        [Required]
        [ForeignKey("SM_USER")]
        public Guid? CreatedUserId { get; set; }

        [Column("CREATED_DATE")]
        [Required]
        public DateTime? CreatedDate { get; set; }

    }
}
