using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScienceMap.WebServices.Data.Models
{
    [Table("SM_USER_STATE")]
    public class UserState
    {
        [Key]
        [Column("ID")]
        public Guid? Id { get; set; }

        [Column("NAME")]
        [MaxLength(30)]
        [Required]
        public string Name { get; set; }

    }
}
