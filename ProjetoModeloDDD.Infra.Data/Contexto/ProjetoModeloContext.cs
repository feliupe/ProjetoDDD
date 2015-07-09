using ProjetoModeloDDD.Domain.Entities;
using System.Data.Entity;

namespace ProjetoModeloDDD.Infra.Data.Contexto
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class ProjetoModeloContext : DbContext
    {
         public ProjetoModeloContext() : this("Contexto") { }
        public ProjetoModeloContext(string connStringName) : base(connStringName) {}
        static ProjetoModeloContext()
        {
            // static constructors are guaranteed to only fire once per application.
            // I do this here instead of App_Start so I can avoid including EF
            // in my MVC project (I use UnitOfWork/Repository pattern instead)
            DbConfiguration.SetConfiguration(new MySql.Data.Entity.MySqlEFConfiguration());
        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
