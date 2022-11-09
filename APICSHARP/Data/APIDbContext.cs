using APICSHARP.Models;
using Microsoft.EntityFrameworkCore;

namespace APICSHARP.Data
{
    public class APIDbContext : DbContext
    {
        public APIDbContext(DbContextOptions<APIDbContext> options) : base(options)
        {

        }
        public DbSet<Aluno> Aluno { get; set; }
    }
}
