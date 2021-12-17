using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScienceMap.WebServices.Data.Models
{
    [Table("SM_PUBLICATION_AUTHOR")]
    public class PublicationAuthor
    {
        [Key]
        [Column("ID")]
        public Guid? Id { get; set; }

        [Column("PUBLICATION_ID")]
        [ForeignKey("SM_PUBLICATION")]
        [Required]
        public Guid? PublicationId { get; set; }

        [Column("AUTHOR_NAME_ID")]
        [ForeignKey("SM_AUTHOR_NAME")]
        [Required]
        public Guid? AuthorNameId { get; set; }

        [Column("ORDER_KEY")]
        public int OrderKey { get; set; }
    }
}
