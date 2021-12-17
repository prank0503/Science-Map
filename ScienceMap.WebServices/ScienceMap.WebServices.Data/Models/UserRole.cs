using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScienceMap.WebServices.Data.Models
{
    [Table("SM_USER_ROLE")]
    public class UserRole
    {
        [Key]
        [Column("ID")]
        public Guid? Id { get; set; }

        [Column("USER_ID")]
        [ForeignKey("SM_USER")]
        [Required]
        public Guid? UserId { get; set; }

        [Column("USER_ROLE_TYPE_ID")]
        [ForeignKey("SM_USER_ROLE_TYPE")]
        [Required]
        public Guid? UserRoleTypeId { get; set; }
    }
}
