using Microsoft.EntityFrameworkCore;

namespace Trixnet.web.Models
{
    public class ConnectionStringClass:DbContext
    {
        public ConnectionStringClass(DbContextOptions<ConnectionStringClass> options):base(options)
        {

        }

        //public DbSet<DocumentsClass> trix_Document { get; set; }
        public DbSet<AnnuaireClass> Annuaire { get; set; }
    }
}
