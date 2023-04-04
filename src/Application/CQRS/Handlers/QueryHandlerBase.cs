using MediatR;
using Pandape.Application.AppServices;
using System.Threading.Tasks;
using System.Threading;

namespace Pandape.Application.CQRS.Handlers
{
    public abstract class QueryHandlerBase<TRequest, TResponse> 
        : IRequestHandler<TRequest, TResponse> where TRequest 
        : IRequest<TResponse>
    {
        protected IQueryCandidateAppService QueryCandidateAppService { get; }

        public QueryHandlerBase( IQueryCandidateAppService queryCandidateAppService )
        {
            QueryCandidateAppService = queryCandidateAppService;
        }

        public abstract Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken);
    }
}
