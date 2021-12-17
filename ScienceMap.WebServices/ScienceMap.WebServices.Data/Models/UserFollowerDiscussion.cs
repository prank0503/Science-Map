using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScienceMap.WebServices.Data.Models
{
    [Table("SM_USER_FOLLOWER_DISCUSSION")]
    public class UserFollowerDiscussion
    {
        [Key]
        [Column("ID")]
        public Guid? Id { get; set; }

        [Column("USER_ID")]
        [ForeignKey("SM_USER")]
        [Required]
        public Guid? UserId { get; set; }

        [Column("DISCUSSION_ID")]
        [ForeignKey("SM_DISCUSSION")]
        [Required]
        public Guid? DiscussionId { get; set; }

    }
}
