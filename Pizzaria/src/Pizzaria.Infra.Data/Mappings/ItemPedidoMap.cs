using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pizzaria.Domain.Entities;

namespace Pizzaria.Infra.Data.Mappings
{
    public class ItemPedidoMap : IEntityTypeConfiguration<ItemPedido>
    {
        public void Configure(EntityTypeBuilder<ItemPedido> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.PedidoId)
                .IsRequired();

            builder.Property(x => x.Quantidade)
                .HasDefaultValue(1)
                .IsRequired();

            builder.ToTable("ItemPedido");
        }
    }
}
