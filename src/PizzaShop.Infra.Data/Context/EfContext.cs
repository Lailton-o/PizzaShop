using Microsoft.EntityFrameworkCore;
using PizzaShop.Domain.Entities;
using PizzaShop.Shared.Data;
using System.Linq;

namespace PizzaShop.Infra.Data.Context
{
    public class EfContext : DbContext, IUnitOfWork
    {
        public EfContext(DbContextOptions<EfContext> options) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            ChangeTracker.AutoDetectChangesEnabled = false;
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<ItemPedido> Itens { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<PedidoLog> LogsPedido { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<StatusPedido> StatusPedidos { get; set; }
        public DbSet<TipoProduto> TiposProduto { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EfContext).Assembly);

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
                relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;

            base.OnModelCreating(modelBuilder);
        }

        public bool Commit()
        {
            return SaveChanges() > 0;
        }
    }
}
