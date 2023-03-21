using System;
using System.ComponentModel.DataAnnotations;

namespace Pandape.Domain.Entities
{
    public class Candidate
    {
        [Key]
        public int IdCandidate { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(150)]
        public string SurName { get; set; }

        public DateTime BirthDate { get; set; }

        [MaxLength(250)]
        public string Email { get; set; }

        public DateTime InsertDate { get; set; }

        public DateTime? ModifyDate { get; set; }

    }
}
