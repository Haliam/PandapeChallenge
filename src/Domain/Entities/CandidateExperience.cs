using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pandape.Domain.Entities
{
    public class CandidateExperience
    {
        [Key]
        public int IdCandidateExperience { get; set; }

        [ForeignKey("Candidate")]
        public int IdCandidate { get; set; }

        [MaxLength(100)]
        public string Company { get; set; }

        [MaxLength(100)]
        public string Job { get; set; }

        [MaxLength(4000)]
        public string Description { get; set; }

        public decimal Salary { get; set; }

        public DateTime BeginDate { get; set; }

        public DateTime? EndDate { get; set; }

        public DateTime InsertDate { get; set; }

        public DateTime? ModifyDate { get; set; }
    }
}
