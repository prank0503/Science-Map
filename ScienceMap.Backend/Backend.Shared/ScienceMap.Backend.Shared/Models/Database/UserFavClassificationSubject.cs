using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScienceMap.Backend.Data.Models
{
    [Table("SM_USER_FAV_SCS")]
    public class UserFavClassificationSubject
    {
        [Key]
        [Column("ID")]
        public Guid Id { get; set; }

        [Column("USER_ID")]
        [ForeignKey("User")]
        [Required]
        public Guid UserId { get; set; }

        [Column("SCS_ID")]
        [ForeignKey("ClassificationSubject")]
        [Required]
        public Guid ScsId { get; set; }

        #region Back Navigation
        public virtual User User { get; set; }
        public virtual ClassificationSubject ClassificationSubject { get; set; }
        #endregion
    }
}
