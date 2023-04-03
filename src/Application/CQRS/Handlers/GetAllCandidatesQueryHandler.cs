using Pandape.Application.AppServices;
using Pandape.Application.CQRS.Queries;
using Pandape.Application.CQRS.Responses;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Pandape.Application.CQRS.Handlers
{
    public class GetAllCandidatesQueryHandler : BaseRequestHandler<GetAllCandidatesQuery, GetAllCandidatesResponse>
    {
        public GetAllCandidatesQueryHandler(ICandidateAppService candidateAppService) 
            : base(candidateAppService)
        {
        }

        public override Task<GetAllCandidatesResponse> Handle(GetAllCandidatesQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
