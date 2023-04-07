using AutoMapper;
using FluentAssertions;
using Moq;
using Pandape.Application.AppServices;
using Pandape.Application.CQRS.Queries;
using Pandape.Application.Mapping;
using Pandape.Domain.Entities;
using Pandape.Infrastructure.Persistence.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace Pandape.Test.Application
{
    public class QueryCandidateAppServiceTest
    {
        protected Mock<ICandidateQueryRepository> CandidateQueryRepository { get; }

        protected IQueryCandidateAppService QueryCandidateAppService { get; }

        protected IMapper Mapper { get; set; }


        public QueryCandidateAppServiceTest()
        {
            CandidateQueryRepository = new Mock<ICandidateQueryRepository>();

            InitializeMapper();

            QueryCandidateAppService = new QueryCandidateAppService(Mapper, CandidateQueryRepository.Object);
        }

        private void InitializeMapper()
        {
            var config = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new CandidateProfile());
            });

            Mapper = config.CreateMapper();
        }

        [Theory]
        [MemberData(nameof(QueryCandidateAppServiceData.FindTestData), MemberType = typeof(QueryCandidateAppServiceData))]
        public async Task Find_ShouldReturnResponse(IEnumerable<Candidate> candidates, FindCandidateQuery query) 
        {
            CandidateQueryRepository.Setup(c => c.Find(query.Expression)).ReturnsAsync(candidates);

            var result = await QueryCandidateAppService.Find(query);

            result.Should().NotBeNull();

            result.Candidates.Should().NotBeNull();

            result.Candidates.Should().BeEquivalentTo(candidates);

            CandidateQueryRepository.Verify(x => x.Find(query.Expression), Times.Once);
        }

        [Theory]
        [MemberData(nameof(QueryCandidateAppServiceData.GetAllTestData), MemberType = typeof(QueryCandidateAppServiceData))]
        public async Task GetAll_ShouldReturnResponse(IEnumerable<Candidate> candidates) 
        {
            CandidateQueryRepository.Setup(c => c.GetAll()).ReturnsAsync(candidates);

            var result = await QueryCandidateAppService.GetAll();

            result.Should().NotBeNull();

            result.Candidates.Should().NotBeNull();

            result.Candidates.Should().BeEquivalentTo(candidates);

            CandidateQueryRepository.Verify(x => x.GetAll(), Times.Once);
        }

        [Theory]
        [MemberData(nameof(QueryCandidateAppServiceData.GetByIdTestData), MemberType = typeof(QueryCandidateAppServiceData))]
        public async Task GetById_ShouldReturnResponse(Candidate candidate) 
        {
            CandidateQueryRepository.Setup(x => x.GetById(candidate.Id)).ReturnsAsync(candidate);

            var query = new GetByIdCandidateQuery { Id = candidate.Id };

            var result = await QueryCandidateAppService.GetById(query);

            result.Should().NotBeNull();

            result.Candidate.Should().NotBeNull();

            result.Candidate.Id.Should().Be(query.Id);

            CandidateQueryRepository.Verify(x => x.GetById(result.Candidate.Id), Times.Once);
        }
    }
}
