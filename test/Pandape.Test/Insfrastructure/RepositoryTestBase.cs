using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Pandape.Infrastructure.Persistence.DataBase;
using System;

namespace Pandape.Test.Insfrastructure
{
    public abstract class RepositoryTestBase : IDisposable
    {
        protected readonly PandapeContext context;

        protected readonly DbContextOptions<PandapeContext> options;

        public readonly string connectionString =
           "Server=(localdb)\\mssqllocaldb;" +
           "Database=PandapeDb;" +
           "Trusted_Connection=True;" +
           "MultipleActiveResultSets=true";

        public RepositoryTestBase()
        {
            //This is testing to production database system. Keep in mind that context should be transient 
            //to generate a new instance of production database for testing.
            options = new DbContextOptionsBuilder<PandapeContext>().UseSqlServer(connectionString).Options;

            //options = new DbContextOptionsBuilder<PandapeContext>().UseInMemoryDatabase("CandidateDb").Options;

            context = new PandapeContext(options);
        }

        public void Dispose()
        {
            context.Dispose();           
        }
    }
}