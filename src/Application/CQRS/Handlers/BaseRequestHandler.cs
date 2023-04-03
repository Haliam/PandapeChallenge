using MediatR;
using Pandape.Application.AppServices;
using System.Threading.Tasks;
using System.Threading;

namespace Pandape.Application.CQRS.Handlers
{
    public abstract class BaseRequestHandler<TRequest, TResponse> 
        : IRequestHandler<TRequest, TResponse> where TRequest 
        : IRequest<TResponse>
    {
        protected ICandidateAppService CandidateAppService { get; }

        public BaseRequestHandler(ICandidateAppService candidateAppService)
        {
            CandidateAppService = candidateAppService;
        }

        public abstract Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken);
    }
}
