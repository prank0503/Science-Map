using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScienceMap.Backend.Data.Models
{
    [Table("SM_PUBLICATION")]
    public class Publication
    {
        [Key]
        [Column("ID")]
        public Guid Id { get; set; }

        [Column("PUBLICATION_STATE_ID")]
        [ForeignKey("PublicationState")]
        [Required]
        public Guid PublicationStateId { get; set; }

        [Column("TITLE")]
        [MaxLength(80)]
        [Required]
        public string Title { get; set; }

        [Column("YEAR")]
        [MaxLength(4)]
        public int Year { get; set; }

        [Column("ABSTRACT")]
        [MaxLength(250)]
        public string Abstract { get; set; }

        [Column("ADDITIONAL_DETAILS")]
        [MaxLength(360)]
        public string AdditionalDetails { get; set; }

        #region Back Navigation
        public virtual PublicationState PublicationState { get; set; }
        #endregion
    }
}
