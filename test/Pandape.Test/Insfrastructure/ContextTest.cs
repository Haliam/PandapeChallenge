using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using Pandape.Infrastructure.Persistence.DataBase;
using Xunit;

namespace Pandape.Test.Insfrastructure
{
    public class ContextTest
    {
        [Theory]
        [MemberData(nameof(ContextTestData.ConnectionString), MemberType = typeof(ContextTestData))]
        public void ConnectionString_ShouldConnectToDatabase(string connectionString)
        {
            var options = new DbContextOptionsBuilder<PandapeContext>().UseSqlServer(connectionString).Options;
            var context = new PandapeContext(options);
            context.Database.CanConnect().Should().BeTrue();
        }
    }
}
