using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScienceMap.WebServices.Data.Models
{
    [Table("SM_SCS")]
    public class ClassificationSubject
    {
        [Key]
        [Column("ID")]
        public Guid? Id { get; set; }

        [Column("NAME")]
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }

        [Column("DESCRIPTION")]
        [MaxLength(120)]
        public string Description { get; set; }

        [Column("IMAGE_URL")]
        [MaxLength(50)]
        public string ImageUrl { get; set; }

        [Column("KEYWORDS")]
        [MaxLength(30)]
        public string Keywords { get; set; }

        [Column("STATE_ID")]
        [ForeignKey("SM_SCS_STATE")]
        [Required]
        public Guid? StateId { get; set; }
    }
}
