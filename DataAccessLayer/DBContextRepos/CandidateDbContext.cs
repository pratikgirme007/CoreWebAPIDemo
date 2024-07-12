using CoreWebAPIDemo.DatabaseRepository.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreWebAPIDemo.DatabaseRepository.DBContextRepos
{
    public class CandidateDbContext : DbContext
    {
        public CandidateDbContext(DbContextOptions<CandidateDbContext> options) 
                                : base(options) { }

        public DbSet<Candidate> Candidates { get; set; }
    }
}
