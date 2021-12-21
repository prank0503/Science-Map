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
        public Guid Id { get; set; }

        [Column("USER_ID")]
        [ForeignKey("User")]
        [Required]
        public Guid UserId { get; set; }

        [Column("USER_ROLE_TYPE_ID")]
        [ForeignKey("UserRoleType")]
        [Required]
        public Guid UserRoleTypeId { get; set; }

        #region Back Navigation
        public virtual User User { get; set; }
        public virtual UserRoleType UserRoleType { get; set; }
        #endregion
    }
}
