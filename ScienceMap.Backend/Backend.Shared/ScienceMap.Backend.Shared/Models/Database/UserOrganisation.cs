using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScienceMap.Backend.Data.Models
{
    [Table("SM_USER_ORGANISATION")]
    public class UserOrganisation
    {
        [Key]
        [Column("ID")]
        public Guid Id { get; set; }

        [Column("USER_ID")]
        [ForeignKey("User")]
        [Required]
        public Guid UserId { get; set; }

        [Column("ORGANISATION_ID")]
        [ForeignKey("Organisation")]
        [Required]
        public Guid OrganisationId { get; set; }

        [Column("ORDER_KEY")]
        public int OrderKey { get; set; }

        #region Back Navigation
        public virtual User User { get; set; }
        public virtual Organisation Organisation { get; set; }
        #endregion
    }
}
