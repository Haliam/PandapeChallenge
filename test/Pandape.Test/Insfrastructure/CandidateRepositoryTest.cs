using Pandape.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Pandape.Test.Insfrastructure
{
    public class CandidateRepositoryTest : GenericRepositoryTest<Candidate>, IRepositoryTest<Candidate>
    {

        [Theory]
        [MemberData(nameof(CandidateRepositoryData.GetAll), MemberType = typeof(CandidateRepositoryData))]
        public async Task GetAll_ShouldReturnAllEntities(List<Candidate> candidates, int range)
        {
            await GetAll(candidates, range);
        }

        [Theory]
        [MemberData(nameof(CandidateRepositoryData.GetById), MemberType = typeof(CandidateRepositoryData))]
        public async Task GetById_ShouldReturnEntity(Candidate candidate)
        {
            await commandRepository.Insert(candidate);
            var id = candidate.Id;
            await GetById(candidate, id);
        }

        [Theory]
        [MemberData(nameof(CandidateRepositoryData.Insert), MemberType = typeof(CandidateRepositoryData))]
        public async Task Insert_ShouldAddEntityToDatabase(Candidate candidate)
        {
            await Insert(candidate);
        }

        [Theory]
        [MemberData(nameof(CandidateRepositoryData.InsertRange), MemberType = typeof(CandidateRepositoryData))]
        public async Task InsertRange_ShouldAddEntitiesToDatabase(List<Candidate> candidates, int range)
        {
            await InsertRange(candidates, range);
        }


        [Theory]
        [MemberData(nameof(CandidateRepositoryData.DeleteByEntity), MemberType = typeof(CandidateRepositoryData))]
        public async Task DeleteByEntity_ShouldRemoveEntityFromDatabase(Candidate candidate)
        {
            await DeleteByEntity(candidate);
        }

        [Theory]
        [MemberData(nameof(CandidateRepositoryData.DeleteById), MemberType = typeof(CandidateRepositoryData))]
        public async Task DeleteById_ShouldRemoveEntityFromDatabase(Candidate candidate)
        {
            await commandRepository.Insert(candidate);
            var id = candidate.Id;
            await DeleteById(candidate, id);
        }

        [Theory]
        [MemberData(nameof(CandidateRepositoryData.DeleteRange), MemberType = typeof(CandidateRepositoryData))]
        public async Task DeleteRange_ShouldRemoveEntitiesFromDatabase(List<Candidate> candidates, int range)
        {
            await DeleteRange(candidates, range);
        }
    }
}
