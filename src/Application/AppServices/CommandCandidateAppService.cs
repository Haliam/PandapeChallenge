using AutoMapper;
using Pandape.Application.CQRS.Commands;
using Pandape.Application.CQRS.Responses;
using Pandape.Domain.Entities;
using Pandape.Infrastructure.Persistence.Repositories;
using System.Threading.Tasks;

namespace Pandape.Application.AppServices
{
    public class CommandCandidateAppService : AppServiceBase, ICommandCandidateAppService
    {
        protected ICandidateCommandRepository CandidateCommandRepository { get; }

        public CommandCandidateAppService(ICandidateCommandRepository candidateCommandRepository, IMapper mapper) 
            : base(mapper)
        {
            CandidateCommandRepository = candidateCommandRepository;
        }

        public async Task<InsertCandidateResponse> Insert(InsertCandidateCommand command)
        {
            var candidate = Mapper.Map<Candidate>(command);

            await CandidateCommandRepository.Insert(candidate);

            var insertCandidateResponse = new InsertCandidateResponse { IsInserted = true};

            return insertCandidateResponse;
        }

        public async Task<UpdateCandidateResponse> Update(UpdateCandidateCommand command)
        {
            throw new System.NotImplementedException();
        }

        public async Task<DeleteCandidateResponse> Delete(DeleteCandidateCommand command)
        {
            throw new System.NotImplementedException();
        }
    }
}
