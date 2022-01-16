using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScienceMap.Backend.Data.Models
{
    [Table("SM_USER_AUTHOR")]
    public class UserAuthor
    {
        [Key]
        [Column("ID")]
        public Guid Id { get; set; }

        [Column("USER_ID")]
        [ForeignKey("User")]
        [Required]
        public Guid UserId { get; set; }

        [Column("PUBLICATION_AUTHOR_ID")]
        [ForeignKey("PublicationAuthor")]
        [Required]
        public Guid PublicationAuthorId { get; set; }

        #region Back Navigation
        public virtual User User { get; set; }
        public virtual PublicationAuthor PublicationAuthor { get; set; }
        #endregion

    }
}
