using Microsoft.EntityFrameworkCore;
using MySB.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySB.Repositorio
{
    public class ContextoMySB : DbContext
    {

        private string  _stringConnection;
        public ContextoMySB(string stringConnection)
        {
            _stringConnection = stringConnection;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(_stringConnection);
        }

        public DbSet<LoginEnt> LoginEnt { get; set; }
    }
}
