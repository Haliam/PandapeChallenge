using Pandape.Application.AppServices;
using Pandape.Application.CQRS.Commands;
using Pandape.Application.CQRS.Responses;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Pandape.Application.CQRS.Handlers
{
    public class UpdateCandidateCommandHandler : BaseRequestHandler<UpdateCandidateCommand, UpdateCandidateResponse>
    {
        public UpdateCandidateCommandHandler(ICandidateAppService candidateAppService) 
            : base(candidateAppService)
        {
        }

        public override Task<UpdateCandidateResponse> Handle(UpdateCandidateCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
