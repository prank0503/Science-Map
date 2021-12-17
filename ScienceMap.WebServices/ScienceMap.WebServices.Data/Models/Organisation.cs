using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScienceMap.WebServices.Data.Models
{
    [Table("SM_ORGANISATION")]
    public class Organisation
    {
        [Key]
        [Column("ID")]
        public Guid? Id { get; set; }

        [Column("ORGANISATION_TYPE_ID")]
        [ForeignKey("SM_ORGANISATION_TYPE")]
        [Required]
        public Guid? OrganisationTypeId { get; set; }

        [Column("ORGANISATION_STATE_ID")]
        [ForeignKey("SM_ORGANISATION_STATE")]
        [Required]
        public Guid? OrganisationStateId { get; set; }

        [Column("NAME")]
        [MaxLength(100)]
        [Required]
        public string Name { get; set; }

        [Column("SHORT_NAME")]
        [MaxLength(50)]
        public string ShortName { get; set; }

        [Column("URL")]
        [MaxLength(100)]
        public string Url { get; set; }
    }
}
