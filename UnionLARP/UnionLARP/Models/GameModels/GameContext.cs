using Microsoft.EntityFrameworkCore;

namespace UnionLARP.Models.GameModels
{
    public class GameContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
    }
}
