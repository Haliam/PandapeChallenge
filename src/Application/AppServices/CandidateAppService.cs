using Pandape.Domain.Entities;
using Pandape.Infrastructure.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Pandape.Application.AppServices
{
    public class CandidateAppService : ICandidateAppService
    {
        public ICandidateQueryRepository CandidateQueryRepository { get; set; }

        public ICandidateCommandRepository CandidateCommandRepository { get; set; }


        public CandidateAppService(ICandidateQueryRepository queryRepository, ICandidateCommandRepository commandRepository) 
        { 
            CandidateQueryRepository = queryRepository;

            CandidateCommandRepository = commandRepository;
        }

        public async Task<IEnumerable<Candidate>> Find(Expression<Func<Candidate, bool>> predicate) => 
            await CandidateQueryRepository.Find(predicate);

        public async Task<IEnumerable<Candidate>> GetAll() 
            => await CandidateQueryRepository.GetAll();

        public async Task<Candidate> GetById(int id) => 
            await CandidateQueryRepository.GetById(id);

        public async Task Insert(Candidate entity) => 
            await CandidateCommandRepository.Insert(entity);

        public async Task InsertRange(IEnumerable<Candidate> entities) => 
            await CandidateCommandRepository.InsertRange(entities);

        public async Task Update(Candidate entity) => 
            await CandidateCommandRepository.Update(entity);

        public async Task Delete(Candidate entity) => 
            await CandidateCommandRepository.Delete(entity);

        public async Task Delete(object id) => 
            await CandidateCommandRepository.Delete(id);

        public async Task DeleteRange(IEnumerable<Candidate> entities) => 
            await CandidateCommandRepository.DeleteRange(entities);
    }
}
