using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScienceMap.WebServices.Data.Models
{
    [Table("SM_USER_SCS")]
    public class UserScsMapping
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
