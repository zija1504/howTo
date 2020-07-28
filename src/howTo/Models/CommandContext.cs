using Microsoft.EntityFrameworkCore;

namespace howTo.Models
{
    public class CommandContext : DbContext
    {
        public CommandContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Commands> CommandItems { get; set; } = null!;
    }
}

