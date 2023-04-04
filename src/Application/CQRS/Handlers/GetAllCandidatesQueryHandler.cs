using Pandape.Application.AppServices;
using Pandape.Application.CQRS.Queries;
using Pandape.Application.CQRS.Responses;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Pandape.Application.CQRS.Handlers
{
    public class GetAllCandidatesQueryHandler : QueryHandlerBase<GetAllCandidatesQuery, GetAllCandidatesResponse>
    {
        public GetAllCandidatesQueryHandler(IQueryCandidateAppService queryCandidateAppService) 
            : base(queryCandidateAppService)
        {
        }

        public override Task<GetAllCandidatesResponse> Handle(GetAllCandidatesQuery query, CancellationToken cancellationToken) =>
            QueryCandidateAppService.GetAll();
    }
}
