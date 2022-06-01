using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MatchAPI.Models;

namespace MatchAPI.Data
{
    public class MatchAPIContext : DbContext
    {
        public MatchAPIContext (DbContextOptions<MatchAPIContext> options)
            : base(options)
        {
        }

        public DbSet<MatchAPI.Models.Match> Match { get; set; }

        public DbSet<MatchAPI.Models.MatchOdds> MatchOdds { get; set; }
    }
}
