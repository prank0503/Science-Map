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
        public Guid Id { get; set; }

        [Column("DISCUSSION_ID")]
        [ForeignKey("Discussion")]
        [Required]
        public Guid DiscussionId { get; set; }

        [Column("PARENT_ID")]
        public Guid ParentId { get; set; }

        [Column("TEXT")]
        [MaxLength(100)]
        [Required]
        public string Text { get; set; }

        [Column("CREATED_USER_ID")]
        [Required]
        [ForeignKey("User")]
        public Guid CreatedUserId { get; set; }

        [Column("CREATED_DATE")]
        [Required]
        public DateTime? CreatedDate { get; set; }

        #region Back Navigation
        public virtual Discussion Discussion { get; set; }
        public virtual User User { get; set; }
        #endregion

    }
}
