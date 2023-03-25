using Pandape.Domain.Entities;

namespace Pandape.Infrastructure.Persistence
{
    public class CandidateCommandRepository : CommandRepository<Candidate>, ICandidateCommandRepository
    {
        public CandidateCommandRepository(PandapeContext context) : base(context)
        {
        }
    }
}
