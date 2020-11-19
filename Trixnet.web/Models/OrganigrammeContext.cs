using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Trixnet.web.Models
{
    public class OrganigrammeContext : DbContext
    {
        public DbSet<OrganigrammeClass> Organigramme { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=TRIXBURINDUS44\\SQLEXPRESS;Database=Trixnet;User Id=webmaster;Password=Trixell123!");
        }

    }
}
