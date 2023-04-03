using MediatR;
using Pandape.Application.CQRS.Responses;

namespace Pandape.Application.CQRS.Queries
{
    public class FindCandidateQuery : IRequest<FindCandidateResponse>
    {
    }
}
