using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PhaseEndProject1.Models;

namespace PhaseEndProject1.Data
{
    public class PhaseEndDbContext : DbContext
    {
        public PhaseEndDbContext (DbContextOptions<PhaseEndDbContext> options)
            : base(options)
        {
        }

        public DbSet<PhaseEndProject1.Models.DeptMaster> DeptMaster { get; set; } = default!;

        public DbSet<PhaseEndProject1.Models.EmpProfile>? EmpProfile { get; set; }
    }
}
