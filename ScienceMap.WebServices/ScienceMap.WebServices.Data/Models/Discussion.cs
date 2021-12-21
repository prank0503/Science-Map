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
        public Guid Id { get; set; }

        [Column("DISCUSSION_TYPE_ID")]
        [ForeignKey("DiscussionType")]
        [Required]
        public Guid DiscussionTypeId { get; set; }

        #region Back Navigation
        public virtual DiscussionType DiscussionType { get; set; }
        #endregion
    }
}
