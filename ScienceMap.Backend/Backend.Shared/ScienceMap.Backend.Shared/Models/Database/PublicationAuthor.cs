using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScienceMap.Backend.Data.Models
{
    [Table("SM_PUBLICATION_AUTHOR")]
    public class PublicationAuthor
    {
        [Key]
        [Column("ID")]
        public Guid Id { get; set; }

        [Column("PUBLICATION_ID")]
        [ForeignKey("Publication")]
        [Required]
        public Guid PublicationId { get; set; }

        [Column("AUTHOR_NAME_ID")]
        [ForeignKey("AuthorName")]
        [Required]
        public Guid AuthorNameId { get; set; }

        [Column("ORDER_KEY")]
        public int OrderKey { get; set; }

        #region Back Navigation
        public virtual Publication Publication { get; set; }
        public virtual AuthorName AuthorName { get; set; }
        #endregion
    }
}
