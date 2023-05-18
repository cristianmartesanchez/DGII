
using DGII.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DGII.DataAccess
{
    public class DGIIDataContext : DbContext
    {
        public DGIIDataContext(DbContextOptions<DGIIDataContext> dbContext) : base(dbContext)
        {

        }

        public DbSet<Comprobantes> Comprobantes { get; set; }
        public DbSet<Contribuyentes> Contribuyentes { get; set; }
        public DbSet<Tipos> Tipos { get; set; }


    }
}
