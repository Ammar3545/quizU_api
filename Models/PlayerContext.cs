using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizUApi.Models
{
    public class PlayerContext : DbContext
    {
        public PlayerContext(DbContextOptions options):base(options)
        {
        }

        public DbSet<LoginAndRegisterPlayer> LoginAndRegisterPlayers { get; set; }
        public DbSet<PlayerScore> PlayerScore { get; set; }
    }
}
