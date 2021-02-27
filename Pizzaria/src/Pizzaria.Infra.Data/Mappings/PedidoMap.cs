using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pizzaria.Domain.Entities;

namespace Pizzaria.Infra.Data.Mappings
{
    public class PedidoMap : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.StatusPedidoId)
                .IsRequired();

            builder.Property(x => x.Valor)
                .IsRequired();

            builder.HasOne(x => x.Status)
                .WithMany()
                .HasForeignKey(x => x.StatusPedidoId);

            builder.ToTable("Pedido");
        }
    }
}
