using Microsoft.EntityFrameworkCore;
using Practice.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.DataAccess.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) { }
        public DbSet<Applicant> Applicants { get; set; }
        public DbSet<Country> Countries{ get; set; }
    }
}
