using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScienceMap.Backend.Data.Models
{
    [Table("SM_SCS_USER")]
    public class ClassificationSubjectUser
    {
        [Key]
        [Column("ID")]
        public Guid Id { get; set; }

        [Column("SCS_ID")]
        [ForeignKey("ClassificationSubject")]
        [Required]
        public Guid ScsId { get; set; }

        [Column("USER_ID")]
        [ForeignKey("User")]
        [Required]
        public Guid UserId { get; set; }

        [Column("SCS_USER_ROLE_ID")]
        [ForeignKey("ClassificationSubjectUserRole")]
        [Required]
        public Guid ScsUserRoleId { get; set; }

        #region Back Navigation
        public virtual ClassificationSubject ClassificationSubject { get; set; }
        public virtual User User { get; set; }
        public virtual ClassificationSubjectUserRole ClassificationSubjectUserRole { get; set; }
        #endregion

    }
}
