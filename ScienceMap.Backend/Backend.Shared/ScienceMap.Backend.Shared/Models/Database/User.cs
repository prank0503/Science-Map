using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScienceMap.Backend.Data.Models
{
    [Table("SM_USER")]
    public class User
    {
        [Key]
        [Column("ID")]
        public Guid Id { get; set; }

        // TODO - Email Validation
        [Column("USER_NAME")]
        [MaxLength(30)]
        [Required]
        public string UserName { get; set; }

        [Column("FIRST_NAME")]
        [MaxLength(30)]
        [Required]
        public string FirstName { get; set; }

        [Column("LAST_NAME")]
        [MaxLength(30)]
        public string LastName { get; set; }

        [Column("ENCRYPTED_PASSWORD_HASH")]
        [MaxLength(50)]
        [Required]
        public string EncryptedPasswordHash { get; set; }

        [Column("USER_STATE_ID")]
        [ForeignKey("UserState")]
        [Required]
        public Guid UserStateId { get; set; }

        #region Back Navigation
        public virtual UserState UserState { get; set; }
        #endregion
    }
}
