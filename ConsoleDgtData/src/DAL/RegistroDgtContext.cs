using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleDgtData;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ConsoleDgtData.DAL
{
    public class RegistroDgtContext : DbContext
    {
        public RegistroDgtContext() : base("RegistroDgtContext")
        {
        }

        public DbSet<VehicleData> Registros { get; set; }

        public DbSet<ClaseMat> ClaseMatriculas { get; set; }

        public DbSet<ProcedenciaItv> Procedencias { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
