using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class BusContext : DbContext
    {
        public BusContext(DbContextOptions<BusContext> options) : base(options)
        {
        }

        public DbSet<Transport> Transports {get;set;}
    }
}