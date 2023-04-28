using Pandape.Application.CQRS.Commands;
using System.Threading.Tasks;
using Xunit;

namespace Pandape.Test.Application
{
    public class CommandCandidateAppServiceTest
    {
        [Theory]
        [MemberData(nameof(CommandCandidateAppServiceData.InsertCandidateSuccess), MemberType = typeof(CommandCandidateAppServiceData))]
        public async Task InsertCandidateSuccess(InsertCandidateCommand command) 
        {

        }

        [Theory]
        [MemberData(nameof(CommandCandidateAppServiceData.UpdateCandidateSuccess), MemberType = typeof(CommandCandidateAppServiceData))]
        public async Task UpdateCandidateSuccess(UpdateCandidateCommand command)
        {

        }

        [Theory]
        [MemberData(nameof(CommandCandidateAppServiceData.DeleteCandidateSuccess), MemberType = typeof(CommandCandidateAppServiceData))]
        public async Task DeleteCandidateSuccess(DeleteCandidateCommand command)
        {

        }
    }
}
