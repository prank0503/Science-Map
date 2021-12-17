using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScienceMap.WebServices.Data.Models
{
    [Table("SM_USER_ORGANISATION")]
    public class UserOrganisation
    {
        [Key]
        [Column("ID")]
        public Guid? Id { get; set; }

        [Column("USER_ID")]
        [ForeignKey("SM_USER")]
        [Required]
        public Guid? UserId { get; set; }

        [Column("ORGANISATION_ID")]
        [ForeignKey("SM_ORGANISATION")]
        [Required]
        public Guid? OrganisationId { get; set; }

        [Column("ORDER_KEY")]
        public int OrderKey { get; set; }
    }
}
