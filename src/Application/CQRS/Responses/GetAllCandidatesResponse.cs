using Pandape.Application.Dtos;
using System.Collections.Generic;

namespace Pandape.Application.CQRS.Responses
{
    public class GetAllCandidatesResponse
    {
        public IEnumerable<CandidateDto> Candidates { get; set; }

        public string Errors { get;  set; }

        public List<CandidateExperienceDto> CandidateExperiences { get; set; }
    }
}