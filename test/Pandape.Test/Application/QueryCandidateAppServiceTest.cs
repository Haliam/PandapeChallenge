using AutoMapper;
using FluentAssertions;
using Moq;
using Pandape.Application.AppServices;
using Pandape.Application.CQRS.Queries;
using Pandape.Application.Dtos;
using Pandape.Application.Mapping;
using Pandape.Domain.Entities;
using Pandape.Infrastructure.Persistence.Repositories;
using System.Collections.Generic;
using System.Linq;
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

            QueryCandidateAppService = new QueryCandidateAppService(Mapper, null, CandidateQueryRepository.Object);
        }

        private void InitializeMapper()
        {
            var config = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new CandidateAppProfile());
            });

            Mapper = config.CreateMapper();
        }

        [Theory]
        [MemberData(nameof(QueryCandidateAppServiceData.FindCandidateSuccess), MemberType = typeof(QueryCandidateAppServiceData))]
        public async Task FindCandidateSuccess(IEnumerable<Candidate> candidates, FindCandidateQuery query) 
        {
            CandidateQueryRepository.Setup(c => c.Find(query.Expression)).ReturnsAsync(candidates);

            var result = await QueryCandidateAppService.Find(query);

            result.Should().NotBeNull();

            result.CandidatesDto.Should().NotBeNull();

            result.CandidatesDto.Should().BeEquivalentTo(Mapper.Map<IEnumerable<CandidateDto>>(candidates));

            CandidateQueryRepository.Verify(x => x.Find(query.Expression), Times.Once);
        }

        [Theory]
        [MemberData(nameof(QueryCandidateAppServiceData.GetAllCandidatesSuccess), MemberType = typeof(QueryCandidateAppServiceData))]
        public async Task GetAllCandidatesSuccess(IEnumerable<Candidate> candidates) 
        {
            CandidateQueryRepository.Setup(c => c.GetAll()).ReturnsAsync(candidates);

            var result = await QueryCandidateAppService.GetAll();

            result.Should().NotBeNull();

            result.CandidatesDto.Should().NotBeNull();

            result.CandidatesDto.Should().BeEquivalentTo(Mapper.Map<IEnumerable<CandidateDto>>(candidates));

            CandidateQueryRepository.Verify(x => x.GetAll(), Times.Once);
        }

        [Theory]
        [MemberData(nameof(QueryCandidateAppServiceData.GetByIdCandidateSuccess), MemberType = typeof(QueryCandidateAppServiceData))]
        public async Task GetByIdCandidateSuccess(Candidate candidate) 
        {
            CandidateQueryRepository.Setup(x => x.GetById(candidate.Id)).ReturnsAsync(candidate);

            var query = new GetByIdCandidateQuery(candidate.Id);

            var result = await QueryCandidateAppService.GetById(query);

            result.Should().NotBeNull();

            result.CandidateDto.Should().NotBeNull();

            result.CandidateDto.Id.Should().Be(query.Id);

            CandidateQueryRepository.Verify(x => x.GetById(result.CandidateDto.Id), Times.Once);
        }
    }
}
