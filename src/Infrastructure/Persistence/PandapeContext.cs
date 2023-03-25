using Microsoft.EntityFrameworkCore;
using Pandape.Domain.Entities;
using Pandape.Infrastructure.Configuration;

namespace Pandape.Infrastructure.Persistence
{
    public class PandapeContext : DbContext
    {
        public PandapeContext(DbContextOptions<PandapeContext> options)
            : base(options)
        {
        }

        public DbSet<Candidate> Candidates { get; set; }

        public DbSet<CandidateExperience> CandidateExperiences { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new CandidateConfiguration());
            modelBuilder.ApplyConfiguration(new CandidateExperienceConfiguration());
        }
    }
}
