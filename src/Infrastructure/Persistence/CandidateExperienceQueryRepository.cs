using Pandape.Domain.Entities;

namespace Pandape.Infrastructure.Persistence
{
    public class CandidateExperienceQueryRepository : QueryRepository<CandidateExperience>, ICandidateExperienceQueryRepository
    {
        public CandidateExperienceQueryRepository(PandapeContext context) : base(context)
        {
        }
    }
}