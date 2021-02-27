using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pizzaria.Domain.Entities;

namespace Pizzaria.Infra.Data.Mappings
{
    public class StatusPedidoMap : IEntityTypeConfiguration<StatusPedido>
    {
        public void Configure(EntityTypeBuilder<StatusPedido> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Descricao)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.ToTable("StatusPedido");

        }
    }
}
