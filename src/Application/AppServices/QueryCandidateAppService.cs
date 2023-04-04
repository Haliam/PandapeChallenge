using AutoMapper;
using Pandape.Application.CQRS.Queries;
using Pandape.Application.CQRS.Responses;
using Pandape.Infrastructure.Persistence.Repositories;
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
            var findCandidateResponse = new FindCandidateResponse();

            //await CandidateQueryRepository.Find();

            return findCandidateResponse;
        }

        public async Task<GetAllCandidatesResponse> GetAll()
        {
            var candidates = await CandidateQueryRepository.GetAll();

            var getAllCandidatesResponse = new GetAllCandidatesResponse();

            getAllCandidatesResponse.Candidates = candidates;

            //var getAllCandidatesResponse = Mapper.Map<GetAllCandidatesResponse>(candidates);

            return getAllCandidatesResponse;
        }

        public async Task<GetByIdCandidateResponse> GetById(GetByIdCandidateQuery query)
        {
            var id = Mapper.Map<int>(query.Id);

            var candidate = await CandidateQueryRepository.GetById(id);

            var getByIdCandidateResponse = Mapper.Map<GetByIdCandidateResponse>(candidate);

            return getByIdCandidateResponse;
        }
    }
}
