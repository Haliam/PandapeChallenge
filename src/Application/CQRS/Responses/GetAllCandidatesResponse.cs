using Pandape.Domain.Entities;
using System.Collections.Generic;

namespace Pandape.Application.CQRS.Responses
{
    public class GetAllCandidatesResponse
    {
        public IEnumerable<Candidate> Candidates { get; set; }
    }
}