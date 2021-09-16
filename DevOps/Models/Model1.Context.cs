namespace DevOps.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class UsuariosEntities : DbContext
    {
        public UsuariosEntities()
            : base("name=UsuariosEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Usuarios> Usuarios { get; set; }
    }
}
