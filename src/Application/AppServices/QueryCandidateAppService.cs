using AutoMapper;
using Pandape.Application.CQRS.Queries;
using Pandape.Application.CQRS.Responses;
using Pandape.Domain.Entities;
using Pandape.Infrastructure.Persistence.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pandape.Application.AppServices
{
    public class QueryCandidateAppService : AppServiceBase, IQueryCandidateAppService
    {
        protected ICandidateQueryRepository CandidateQueryRepository { get; }

        public QueryCandidateAppService(IMapper mapper, ICandidateQueryRepository candidateQueryRepository) 
            : base(mapper)
        {
            CandidateQueryRepository = candidateQueryRepository;
        }

        public async Task<FindCandidateResponse> Find(FindCandidateQuery query)
        {
            var candidates = await CandidateQueryRepository.Find(query.Expression);

            var response = new FindCandidateResponse { Candidates = candidates };

            return response;
        }

        public async Task<GetAllCandidatesResponse> GetAll()
        {
            var candidates = await CandidateQueryRepository.GetAll();

            var response = new GetAllCandidatesResponse { Candidates = Mapper.Map<IEnumerable<Candidate>>(candidates) };

            return response;
        }

        public async Task<GetByIdCandidateResponse> GetById(GetByIdCandidateQuery query)
        {
            var candidate = await CandidateQueryRepository.GetById(query.Id);

            var response = new GetByIdCandidateResponse { Candidate = candidate };

            return response;
        }
    }
}
