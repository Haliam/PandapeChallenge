using MediatR;
using Pandape.Application.CQRS.Responses;
using Pandape.Domain.Entities;

namespace Pandape.Application.CQRS.Commands
{
    public class UpdateCandidateCommand : IRequest<UpdateCandidateResponse>
    {
        public Candidate Candidate { get; set; }
    }
}
