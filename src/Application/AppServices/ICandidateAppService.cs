using Pandape.Domain.Entities;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System;

namespace Pandape.Application.AppServices
{
    public interface ICandidateAppService 
    {
        Task<IEnumerable<Candidate>> Find(Expression<Func<Candidate, bool>> predicate);

        Task<IEnumerable<Candidate>> GetAll();

        Task<Candidate> GetById(int id);

        Task Insert(Candidate entity);

        Task InsertRange(IEnumerable<Candidate> entities);

        Task Update(Candidate entity);

        Task Delete(Candidate entity);

        Task Delete(object id);

        Task DeleteRange(IEnumerable<Candidate> entities);
    }
}
