using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScienceMap.WebServices.Data.Models
{
    [Table("SM_SCS_RELATION")]
    public class ClassificationSubjectRelation
    {
        [Key]
        [Column("ID")]
        public Guid Id { get; set; }

        [Column("PARENT_SCS_ID")]
        [ForeignKey("ParentClassificationSubject")]
        [Required]
        public Guid ParentScsId { get; set; }

        [Column("SCS_ID")]
        [ForeignKey("ClassificationSubject")]
        [Required]
        public Guid ScsId { get; set; }

        #region Back Navigation
        public virtual ClassificationSubject ClassificationSubject { get; set; }
        public virtual ClassificationSubject ParentClassificationSubject { get; set; }
        #endregion
    }
}
