using Pandape.Domain.Entities;
using System.Collections.Generic;

namespace Pandape.Application.CQRS.Responses
{
    public class GetAllCandidatesResponse
    {
        public IEnumerable<Candidate> Candidates { get; set; }

        public string Errors { get;  set; }

        public List<CandidateExperience> CandidateExperiences { get; set; }
    }
}