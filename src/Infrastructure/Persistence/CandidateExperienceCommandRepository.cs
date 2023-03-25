using Pandape.Domain.Entities;

namespace Pandape.Infrastructure.Persistence
{
    public class CandidateExperienceCommandRepository : CommandRepository<CandidateExperience>, ICandidateExperienceCommandRepository
    {
        public CandidateExperienceCommandRepository(PandapeContext context) : base(context)
        {
        }
    }
}
