using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pandape.Domain.Entities;

namespace Pandape.Host.Mvc.Data
{
    public class PandapeContext : DbContext
    {
        public PandapeContext (DbContextOptions<PandapeContext> options)
            : base(options)
        {
        }

        public DbSet<Pandape.Domain.Entities.Candidate> Candidate { get; set; }
    }
}
