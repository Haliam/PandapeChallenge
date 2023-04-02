using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Pandape.Infrastructure.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Pandape.Test.Insfrastructure
{
    public abstract class GenericRepositoryTest<T> : RepositoryTestBase where T : class
    {
        protected IQueryRepository<T> queryRepository;

        protected ICommandRepository<T> commandRepository;

        public GenericRepositoryTest()
        {
            queryRepository = new QueryRepository<T>(context);

            commandRepository = new CommandRepository<T>(context);
        }

        public async Task GetAll(List<T> entities, int range)
        {
            var expected = context.Set<T>().Count() + range;

            await InsertRangeEntitiesToDatabase(entities);

            var result = queryRepository.GetAll().Result;

            result.Should().HaveCount(expected);

            foreach (T entity in entities)
            {
                context.Set<T>().Contains(entity);
            }
        }

        public async Task GetById(T entity, int id)
        {
           id.Should().BeGreaterThanOrEqualTo(0);

           context.Set<T>().Contains(entity).Should().BeTrue();

           var result = queryRepository.GetById(id).Result;

           result.Should().BeEquivalentTo(entity);
        }

        public async Task Insert(T entity)
        {
            var expected = context.Set<T>().Count() + 1;

            await InsertEntityToDatabase(entity);

            context.Set<T>().Should().HaveCount(expected);

            context.Set<T>().Should().Contain(entity);
        }

        public async Task InsertRange(List<T> entities, int range)
        {
            var expected = context.Set<T>().Count() + range;

            await InsertRangeEntitiesToDatabase(entities);

            context.Set<T>().Should().HaveCount(expected);

            foreach (T entity in entities)
            {
                context.Set<T>().Contains(entity);
            }
        }

        public async Task DeleteByEntity(T entity)
        {
            await InsertEntityToDatabase(entity);

            var expected = context.Set<T>().Count() - 1;

            context.Set<T>().Contains(entity).Should().BeTrue();

            await commandRepository.Delete(entity);

            context.Set<T>().Should().HaveCount(expected);

            var deletedEntity = context.Set<T>().Contains(entity);

            deletedEntity.Should().BeFalse();
        }

        public async Task DeleteById(T entity, int id)
        {
            var expected = context.Set<T>().Count() - 1;

            context.Set<T>().Contains(entity).Should().BeTrue();

            await commandRepository.Delete(id);

            context.Set<T>().Should().HaveCount(expected);

            var result = await context.Set<T>().FindAsync(id);

            result.Should().BeNull();
        }

        public async Task DeleteRange(List<T> entities, int range)
        {
            await InsertRangeEntitiesToDatabase(entities);

            var expected = context.Set<T>().Count() - range;

            await commandRepository.DeleteRange(entities);

            context.Set<T>().Should().HaveCount(expected);

            foreach (var entity in entities)
            {
                context.Set<T>().Should().NotContain(entity);
            }
        }

        private async Task InsertEntityToDatabase(T entity)
        {
            await commandRepository.Insert(entity);
        }

        public async Task InsertRangeEntitiesToDatabase(List<T> entities)
        {
            await commandRepository.InsertRange(entities);
        }
    }
}
