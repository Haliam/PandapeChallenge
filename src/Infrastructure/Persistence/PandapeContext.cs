using Microsoft.EntityFrameworkCore;
using Pandape.Domain.Entities;

namespace Pandape.Infrastructure.Persistence
{
    public class PandapeContext : DbContext
    {
        public PandapeContext(DbContextOptions<PandapeContext> options)
            : base(options)
        {
        }

        public DbSet<Candidate> Candidate { get; set; }
    }
}
