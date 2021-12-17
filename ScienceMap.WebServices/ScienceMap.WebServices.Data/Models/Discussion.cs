using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScienceMap.WebServices.Data.Models
{
    [Table("SM_DISCUSSION")]
    public class Discussion
    {
        [Key]
        [Column("ID")]
        public Guid? Id { get; set; }

        [Column("DISCUSSION_TYPE_ID")]
        [ForeignKey("SM_DISCUSSION_TYPE")]
        [Required]
        public Guid? DiscussionTypeId { get; set; }
    }
}
