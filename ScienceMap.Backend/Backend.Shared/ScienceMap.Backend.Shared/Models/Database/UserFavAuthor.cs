using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScienceMap.Backend.Data.Models
{
    [Table("SM_USER_FAV_AUTHOR")]
    public class UserFavAuthor
    {
        [Key]
        [Column("ID")]
        public Guid Id { get; set; }

        [Column("USER_ID")]
        [ForeignKey("User")]
        [Required]
        public Guid UserId { get; set; }

        [Column("FAV_USER_AUTHOR_ID")]
        [ForeignKey("UserAuthor")]
        [Required]
        public Guid FavUserAuthorId { get; set; }

        #region Back Navigation
        public virtual User User { get; set; }
        public virtual UserAuthor UserAuthor { get; set; }
        #endregion
    }
}
