using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PizzaShop.Domain.Entities;

namespace PizzaShop.Infra.Data.Mappings
{
    public class PedidoLogMap : IEntityTypeConfiguration<PedidoLog>
    {
        public void Configure(EntityTypeBuilder<PedidoLog> builder)
        {

        }
    }
}
