using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pandape.Domain.Entities
{
    public class CandidateExperience
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Company { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Job { get; set; }

        [Required]
        [Column(TypeName = "varchar(4000)")]
        public string Description { get; set; }

        [Required]
        [Column(TypeName = "decimal(8,2)")]
        public decimal Salary { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime BeginDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? EndDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime InsertDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? ModifyDate { get; set; }

        /// <summary>
        /// Foreing key
        /// </summary>
        public int CandidateId { get; set; }

        /// <summary>
        /// Navigation property
        /// </summary>
        public Candidate Candidate { get; set; }
    }
}
