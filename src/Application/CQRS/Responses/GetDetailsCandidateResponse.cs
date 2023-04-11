using Pandape.Application.Dtos;
using System.Collections.Generic;

namespace Pandape.Application.CQRS.Responses
{
    public class GetDetailsCandidateResponse
    {
        public CandidateDto CandidateDto { get; set; }

        public List<CandidateExperienceDto> CandidateExperiencesDto { get; set; }
    }
}
