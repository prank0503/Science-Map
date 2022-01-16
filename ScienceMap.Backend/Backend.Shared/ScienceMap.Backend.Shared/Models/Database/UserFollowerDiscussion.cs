using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScienceMap.Backend.Data.Models
{
    [Table("SM_USER_FOLLOWER_DISCUSSION")]
    public class UserFollowerDiscussion
    {
        [Key]
        [Column("ID")]
        public Guid Id { get; set; }

        [Column("USER_ID")]
        [ForeignKey("User")]
        [Required]
        public Guid UserId { get; set; }

        [Column("DISCUSSION_ID")]
        [ForeignKey("Discussion")]
        [Required]
        public Guid DiscussionId { get; set; }

        #region Back Navigation
        public virtual User User { get; set; }
        public virtual Discussion Discussion { get; set; }
        #endregion
    }
}
