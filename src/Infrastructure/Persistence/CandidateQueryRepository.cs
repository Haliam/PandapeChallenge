using Pandape.Domain.Entities;

namespace Pandape.Infrastructure.Persistence
{
    public class CandidateQueryRepository : QueryRepository<Candidate>, ICandidateQueryRepository
    {
        public CandidateQueryRepository(PandapeContext context) : base(context)
        {
        }
    }
}
