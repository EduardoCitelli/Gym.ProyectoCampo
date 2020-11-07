namespace Gym.Datos
{
    using Gym.Domain;
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.SqlServer;
    using System.Data.Entity.ModelConfiguration.Conventions;

    public class MyDbContext : DbContext, IDisposable
    {

        public MyDbContext() : base("name=MyGym")
        {
        }

        #region //DbSets

        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<GrupoUsuarios> GrupoUsuarios { get; set; }
        public virtual DbSet<Profesores> Profesores { get; set; }
        public virtual DbSet<Actividades> Actividades { get; set; }
        public virtual DbSet<Clases_Socios> Clases_Socios { get; set; }
        public virtual DbSet<Membresias> Membresias { get; set; }
        public virtual DbSet<Salones> Salones { get; set; }
        public virtual DbSet<Socios> Socios { get; set; }
        public virtual DbSet<TipoMembresias> TipoMembresias { get; set; }
        public virtual DbSet<Clases> Clases { get; set; }
        public virtual DbSet<Socios_Membresias> Socios_Membresias { get; set; }
        public virtual DbSet<ComprobanteEmitido> ComprobanteEmitido { get; set; }

        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            SqlProviderServices.TruncateDecimalsToScale = false;

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Users>().HasKey(x => x.usu_Id);

            modelBuilder.Entity<ComprobanteEmitido>().HasKey(x => x.cem_Id);

            modelBuilder.Entity<GrupoUsuarios>().HasKey(x => x.gus_Id);

            modelBuilder.Entity<TipoMembresias>().HasKey(x => x.tmm_Id);

            modelBuilder.Entity<Clases_Socios>().HasKey(x => x.css_Id);

            modelBuilder.Entity<Clases>().HasKey(x => x.cls_Id);

            modelBuilder.Entity<Profesores>()
                        .HasKey(x => x.pro_Codigo)
                        .Property(x => x.pro_Codigo)
                        .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            modelBuilder.Entity<Actividades>()
                        .HasKey(x => x.act_Codigo)
                        .Property(x => x.act_Codigo)
                        .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            modelBuilder.Entity<Membresias>()
                        .HasKey(x => x.mem_Codigo)
                        .Property(x => x.mem_Codigo)
                        .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            modelBuilder.Entity<Salones>()
                        .HasKey(x => x.sal_Codigo)
                        .Property(x => x.sal_Codigo)
                        .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            modelBuilder.Entity<Socios>()
                        .HasKey(x => x.soc_Codigo)
                        .Property(x => x.soc_Codigo)
                        .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        }
    }
}