using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OTS_ENTITIES.Mappings;

namespace OTS_ENTITIES
{
   public class OTS_CONTEXT : DbContext
    {
        public DbSet<Bolge> Bolgeler { get; set; }

        public DbSet<Dil> Diller { get; set; }

        public DbSet<Fatura> Faturalar { get; set; }

        public DbSet<Turistler> Turistler { get; set; }
        public DbSet<Rehberler> Rehberler { get; set; }

        public DbSet<Turlar> Turlar { get; set; }

        public DbSet<Yer> Yerler { get; set; }

        public DbSet<TurBileti> TurBileti { get; set; }
        public DbSet<RehberDil> RehberDil { get; set; }
        public DbSet<RehberYer> RehberYer { get; set; }
        public DbSet<TurYer> TurYer { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Configurations.Add(new MapBolge());
            modelBuilder.Configurations.Add(new MapDil());
            modelBuilder.Configurations.Add(new MapYer());
            modelBuilder.Configurations.Add(new MapFatura());
            modelBuilder.Configurations.Add(new MapTuristler());
            modelBuilder.Configurations.Add(new MapRehberler());
            modelBuilder.Configurations.Add(new MapTurlar());


            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            base.OnModelCreating(modelBuilder);
        }
    }
}
