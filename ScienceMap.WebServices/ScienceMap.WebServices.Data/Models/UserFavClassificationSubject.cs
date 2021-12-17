using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScienceMap.WebServices.Data.Models
{
    [Table("SM_USER_FAV_SCS")]
    public class UserFavClassificationSubject
    {
        [Key]
        [Column("ID")]
        public Guid? Id { get; set; }

        [Column("USER_ID")]
        [ForeignKey("SM_USER")]
        [Required]
        public Guid? UserId { get; set; }

        [Column("SCS_ID")]
        [ForeignKey("SM_SCS")]
        [Required]
        public Guid? ScsId { get; set; }

    }
}
