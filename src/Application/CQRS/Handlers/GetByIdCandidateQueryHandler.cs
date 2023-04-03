using Pandape.Application.AppServices;
using Pandape.Application.CQRS.Queries;
using Pandape.Application.CQRS.Responses;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Pandape.Application.CQRS.Handlers
{
    public class GetByIdCandidateQueryHandler : BaseRequestHandler<GetByIdCandidateQuery, GetByIdCandidateResponse>
    {
        public GetByIdCandidateQueryHandler(ICandidateAppService candidateAppService) 
            : base(candidateAppService)
        {
        }

        public override Task<GetByIdCandidateResponse> Handle(GetByIdCandidateQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
