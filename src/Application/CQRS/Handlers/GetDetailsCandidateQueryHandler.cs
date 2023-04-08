using Pandape.Application.AppServices;
using Pandape.Application.CQRS.Queries;
using Pandape.Application.CQRS.Responses;
using System.Threading;
using System.Threading.Tasks;

namespace Pandape.Application.CQRS.Handlers
{
    public class GetDetailsCandidateQueryHandler : QueryHandlerBase<GetDetailsCandidateQuery, GetDetailsCandidateResponse>
    {
        public GetDetailsCandidateQueryHandler(IQueryCandidateAppService queryCandidateAppService) 
            : base(queryCandidateAppService)
        {
        }

        public override Task<GetDetailsCandidateResponse> Handle(GetDetailsCandidateQuery query, CancellationToken cancellationToken) =>
            QueryCandidateAppService.GetDetails(query);
    }
}
