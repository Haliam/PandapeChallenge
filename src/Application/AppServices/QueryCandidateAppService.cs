using AutoMapper;
using Microsoft.Extensions.Logging;
using Pandape.Application.CQRS.Queries;
using Pandape.Application.CQRS.Responses;
using Pandape.Application.Dtos;
using Pandape.Domain.Entities;
using Pandape.Infrastructure.Persistence.Repositories;
using Serilog;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pandape.Application.AppServices
{
    public class QueryCandidateAppService : AppServiceBase, IQueryCandidateAppService
    {
        protected ICandidateQueryRepository CandidateQueryRepository { get; }

        protected ILogger<QueryCandidateAppService> Log { get; }

        public QueryCandidateAppService(IMapper mapper, ILogger<QueryCandidateAppService> logger, ICandidateQueryRepository candidateQueryRepository) 
            : base(mapper)
        {
            CandidateQueryRepository = candidateQueryRepository;

            Log = logger;
        }

        public async Task<FindCandidateResponse> Find(FindCandidateQuery query)
        {
            var response = new FindCandidateResponse();

            try
            {
                var candidates = await CandidateQueryRepository.Find(query.Expression);

                response.CandidatesDto = Mapper.Map<IEnumerable<CandidateDto>>(candidates);
            }
            catch (Exception ex)
            {
                Log.LogError($"{nameof(QueryCandidateAppService)} - {nameof(FindCandidateResponse)} Error: {ex.Message}");
            }

            return response;
        }

        public async Task<GetAllCandidatesResponse> GetAll()
        {
            var response = new GetAllCandidatesResponse();

            try
            {
                var candidates = await CandidateQueryRepository.GetAll();

                response.CandidatesDto = Mapper.Map<IEnumerable<CandidateDto>>(candidates);
            }
            catch (Exception ex)
            {
                Log.LogError($"{nameof(QueryCandidateAppService)} - {nameof(GetAllCandidatesResponse)} Error: {ex.Message}");
            }

            return response;
        }

        public async Task<GetByIdCandidateResponse> GetById(GetByIdCandidateQuery query)
        {
            var response = new GetByIdCandidateResponse();

            try
            {
                var candidate = await CandidateQueryRepository.GetById(query.Id);

                response.CandidateDto = Mapper.Map<CandidateDto>(candidate);
            }
            catch (Exception ex)
            {
                Log.LogError($"{nameof(QueryCandidateAppService)} - {nameof(GetByIdCandidateResponse)} Error: {ex.Message}");
            }

            return response;
        }

        public async Task<GetDetailsCandidateResponse> GetDetails(GetDetailsCandidateQuery query)
        {
            var response = new GetDetailsCandidateResponse();

            var candidateExperiences = GetCandidateExperiences();

            try
            {
                var candidate = await CandidateQueryRepository.GetById(query.Id);

                response.CandidateDto = Mapper.Map<CandidateDto>(candidate);

                response.CandidateExperiencesDto = Mapper.Map<List<CandidateExperienceDto>>(candidateExperiences);
            }
            catch (Exception ex)
            {
                Log.LogError($"{nameof(QueryCandidateAppService)} - {nameof(GetDetailsCandidateResponse)} Error: {ex.Message}");
            }

            return response;
        }


        private List<CandidateExperience> GetCandidateExperiences()
        {
            var candidateExperiences = new List<CandidateExperience>
            {

                new CandidateExperience
                {
                    Company = "Google",
                    Job = "Developer",
                    Description= "Description",
                    Salary = 40000,
                    BeginDate= DateTime.Now.Date,
                    EndDate = null,
                    InsertDate = DateTime.Now.Date,
                },
                new CandidateExperience
                {
                    Company = "Imexin",
                    Job = "Chemistry",
                    Description= "Description",
                    Salary = 50000,
                    BeginDate= DateTime.Now.Date,
                    EndDate = null,
                    InsertDate = DateTime.Now.Date,
                },
            };

            return candidateExperiences;
        }
    }
}
