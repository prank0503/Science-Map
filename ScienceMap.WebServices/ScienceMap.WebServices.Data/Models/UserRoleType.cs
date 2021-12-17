using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScienceMap.WebServices.Data.Models
{
    [Table("SM_USER_ROLE_TYPE")]
    public class UserRoleType
    {
        [Key]
        [Column("ID")]
        public Guid? Id { get; set; }

        [Column("NAME")]
        [Required]
        [MaxLength(30)]
        public Guid? Name { get; set; }

        [Column("DESCRIPTION")]
        [Required]
        [MaxLength(250)]
        public Guid? Description { get; set; }
    }
}
