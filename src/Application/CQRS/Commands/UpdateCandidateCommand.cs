using MediatR;
using Pandape.Application.CQRS.Responses;
using Pandape.Domain.Entities;

namespace Pandape.Application.CQRS.Commands
{
    public class UpdateCandidateCommand : IRequest<UpdateCandidateResponse>
    {
        public int ID { get; set; }

        public Candidate Candidate { get; set; }


        public UpdateCandidateCommand(int id, Candidate candidate)
        {
            ID = id;

            Candidate = candidate;
        }
    }
}
