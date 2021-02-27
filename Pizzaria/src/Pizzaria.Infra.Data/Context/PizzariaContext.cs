using Microsoft.EntityFrameworkCore;
using Pizzaria.Domain.Entities;

namespace Pizzaria.Infra.Data.Context
{
    public class PizzariaContext : DbContext
    {
        public PizzariaContext(DbContextOptions<PizzariaContext> options) : base(options)
        {

        }

        public DbSet<ItemPedido> ItensPedido { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<StatusPedido> StatusPedidos { get; set; }
    }
}
