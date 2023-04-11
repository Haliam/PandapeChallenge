using Pandape.Domain.Entities;

namespace Pandape.Application.CQRS.Responses
{
    public class GetByIdCandidateResponse
    {
        public Candidate Candidate { get; set; }
        public string Errors { get; internal set; }
    }
}