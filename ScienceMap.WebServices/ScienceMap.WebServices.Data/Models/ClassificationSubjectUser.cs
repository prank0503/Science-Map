using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScienceMap.WebServices.Data.Models
{
    [Table("SM_SCS_USER")]
    public class ClassificationSubjectUser
    {
        [Key]
        [Column("ID")]
        public Guid? Id { get; set; }

        [Column("SCS_ID")]
        [ForeignKey("SM_SCS")]
        [Required]
        public Guid? ScsId { get; set; }

        [Column("USER_ID")]
        [ForeignKey("SM_USER")]
        [Required]
        public Guid? UserId { get; set; }

        [Column("SCS_USER_ROLE_ID")]
        [ForeignKey("SM_SCS_USER_ROLE")]
        [Required]
        public Guid? ScsUserRoleId { get; set; }
    }
}
