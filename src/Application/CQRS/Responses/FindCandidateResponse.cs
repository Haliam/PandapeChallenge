using Pandape.Domain.Entities;
using System.Collections.Generic;

namespace Pandape.Application.CQRS.Responses
{
    public class FindCandidateResponse
    {
        public IEnumerable<Candidate> Candidates { get; set; }
    }
}