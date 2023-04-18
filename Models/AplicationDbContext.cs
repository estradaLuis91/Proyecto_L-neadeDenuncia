using Microsoft.EntityFrameworkCore;

namespace Linea_Denuncia_API.Models
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {


        }

        public DbSet<Userlogin>  Users{ get; set; }
        public DbSet<Eo> Eos{ get; set; }
        public DbSet<Country> Countrys { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Denuncia> Denuncia { get; set; }
        public DbSet<DenunciaSP> DenunciaSP { get; set; }
        public DbSet<Status_Denuncia> Status_Denuncia { get; set; }


    }
}
