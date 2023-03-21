using System;

namespace Pandape.Domain.Entities
{
    public class Candidate
    {
        public int IdCandidate { get; set; }

        public string Name { get; set; }

        public string SurName { get; set; }

        public DateTime BirthDate { get; set; }

        public string Email { get; set; }

        public DateTime InsertDate { get; set; }

        public DateTime ModifyDate { get; set; }

    }
}
