using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScienceMap.WebServices.Data.Models
{
    [Table("SM_USER_AUTHOR")]
    public class UserAuthor
    {
        [Key]
        [Column("ID")]
        public Guid? Id { get; set; }

        [Column("USER_ID")]
        [ForeignKey("SM_USER")]
        [Required]
        public Guid? UserId { get; set; }

        [Column("PUBLICATION_AUTHOR_ID")]
        [ForeignKey("SM_PUBLICATION_AUTHOR")]
        [Required]
        public Guid? PublicationAuthorId { get; set; }

    }
}
