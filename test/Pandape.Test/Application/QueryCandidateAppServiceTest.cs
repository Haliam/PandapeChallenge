using Pandape.Application.CQRS.Queries;
using System.Threading.Tasks;
using Xunit;

namespace Pandape.Test.Application
{
    public class QueryCandidateAppServiceTest
    {
        [Theory]
        [MemberData(nameof(QueryCandidateAppServiceData.Find), MemberType = typeof(QueryCandidateAppServiceData))]
        public async Task Find_ShouldReturnResponse(FindCandidateQuery query) 
        { 

        }

        [Theory]
        [MemberData(nameof(QueryCandidateAppServiceData.GetAll), MemberType = typeof(QueryCandidateAppServiceData))]
        public async Task GetAll_ShouldReturnResponse() 
        { 

        }

        [Theory]
        [MemberData(nameof(QueryCandidateAppServiceData.GetById), MemberType = typeof(QueryCandidateAppServiceData))]
        public async Task GetById_ShouldReturnResponse(GetByIdCandidateQuery query) 
        { 

        }
    }
}
