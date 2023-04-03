using Pandape.Application.AppServices;
using Pandape.Application.CQRS.Commands;
using Pandape.Application.CQRS.Responses;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Pandape.Application.CQRS.Handlers
{
    public class DeleteCandidateCommandHandler : BaseRequestHandler<DeleteCandidateCommand, DeleteCandidateResponse>
    {
        public DeleteCandidateCommandHandler(ICandidateAppService candidateAppService) 
            : base(candidateAppService)
        {
        }

        public override Task<DeleteCandidateResponse> Handle(DeleteCandidateCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
