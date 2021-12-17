using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScienceMap.WebServices.Data.Models
{
    [Table("SM_SCS_SUGGESTION")]
    public class ClassificationSubjectSuggestion
    {
        [Key]
        [Column("ID")]
        public Guid? Id { get; set; }

        [Column("SCS_ID")]
        [ForeignKey("SM_SCS")]
        [Required]
        public Guid? ScsId { get; set; }

        [Column("SUGGESTED_USER_ID")]
        [ForeignKey("SM_USER")]
        [Required]
        public Guid? SuggestedUserId { get; set; }

        [Column("APPLIED_USER_ORCHESTRATOR_ROLE")]
        [Required]
        public bool AppliedUserOrchestratorRole { get; set; }

        [Column("SUGGESTED_ORCHESTRATOR_NAME")]
        [MaxLength(40)]
        public string SuggestedOrchestratorName { get; set; }

        [Column("SUGGESTED_ORCHESTRATOR_MAIL")]
        [MaxLength(40)]
        public string SuggestedOrchestratorMail { get; set; }

        [Column("SUGGESTED_ORCHESTRATOR_PHONE")]
        [MaxLength(20)]
        public string SuggestedOrchestratorPhone { get; set; }

    }
}
