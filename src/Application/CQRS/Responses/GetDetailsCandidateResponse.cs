using Pandape.Domain.Entities;
using System.Collections.Generic;

namespace Pandape.Application.CQRS.Responses
{
    public class GetDetailsCandidateResponse
    {
        public Candidate Candidate { get; set; }

        public List<CandidateExperience> CandidateExperiences { get; set; }
    }
}
