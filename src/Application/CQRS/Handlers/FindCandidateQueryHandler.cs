using Pandape.Application.AppServices;
using Pandape.Application.CQRS.Queries;
using Pandape.Application.CQRS.Responses;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Pandape.Application.CQRS.Handlers
{
    public class FindCandidateQueryHandler : BaseRequestHandler<FindCandidateQuery, FindCandidateResponse>
    {
        public FindCandidateQueryHandler(ICandidateAppService candidateAppService) 
            : base(candidateAppService)
        {
        }

        public override Task<FindCandidateResponse> Handle(FindCandidateQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
