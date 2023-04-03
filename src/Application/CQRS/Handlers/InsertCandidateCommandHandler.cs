using Pandape.Application.AppServices;
using Pandape.Application.CQRS.Commands;
using Pandape.Application.CQRS.Responses;
using System.Threading;
using System.Threading.Tasks;

namespace Pandape.Application.CQRS.Handlers
{
    public class InsertCandidateCommandHandler : BaseRequestHandler<InsertCandidateCommand, InsertCandidateResponse>
    {
        public InsertCandidateCommandHandler(ICandidateAppService candidateAppService) 
            : base(candidateAppService)
        {
        }

        public override Task<InsertCandidateResponse> Handle(InsertCandidateCommand request, CancellationToken cancellationToken) 
        {
            throw new System.NotImplementedException();
        }
    }
}
