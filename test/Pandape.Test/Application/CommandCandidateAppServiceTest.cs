using Pandape.Application.CQRS.Commands;
using System.Threading.Tasks;
using Xunit;

namespace Pandape.Test.Application
{
    public class CommandCandidateAppServiceTest
    {
        [Theory]
        [MemberData(nameof(CommandCandidateAppServiceData.Insert), MemberType = typeof(CommandCandidateAppServiceData))]
        public async Task Insert_ShouldReturnResponse(InsertCandidateCommand command) 
        {

        }

        [Theory]
        [MemberData(nameof(CommandCandidateAppServiceData.Update), MemberType = typeof(CommandCandidateAppServiceData))]
        public async Task Update_ShouldReturnResponse(UpdateCandidateCommand command)
        {

        }

        [Theory]
        [MemberData(nameof(CommandCandidateAppServiceData.Delete), MemberType = typeof(CommandCandidateAppServiceData))]
        public async Task Delete_ShouldReturnResponse(DeleteCandidateCommand command)
        {

        }
    }
}
