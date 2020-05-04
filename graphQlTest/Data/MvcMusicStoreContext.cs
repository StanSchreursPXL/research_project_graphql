using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using graphQlServer.Models;
using Microsoft.EntityFrameworkCore;

namespace graphQlServer.Data
{
    public class MvcMusicStoreContext : DbContext
    {
        public MvcMusicStoreContext(DbContextOptions<MvcMusicStoreContext> options) : base(options)
        {

        }

        public DbSet<Artist> Artist { get; set; }
    }
}
