using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScienceMap.WebServices.Data.Models
{
    [Table("SM_USER_FAV_AUTHOR")]
    public class UserFavAuthor
    {
        [Key]
        [Column("ID")]
        public Guid? Id { get; set; }

        [Column("USER_ID")]
        [ForeignKey("SM_USER")]
        [Required]
        public Guid? UserId { get; set; }

        [Column("FAV_USER_AUTHOR_ID")]
        [ForeignKey("SM_USER_AUTHOR")]
        [Required]
        public Guid? FavUserAuthorId { get; set; }

    }
}
