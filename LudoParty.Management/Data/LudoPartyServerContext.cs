using Microsoft.EntityFrameworkCore;
using LudoParty.DataModel.Models;

namespace LudoParty.Management.Data
{
    public class LudoPartyServerContext : DbContext
    {
        public LudoPartyServerContext (DbContextOptions<LudoPartyServerContext> options)
            : base(options)
        {
        }

        public DbSet<Settings> Settings { get; set; }
    }
}
