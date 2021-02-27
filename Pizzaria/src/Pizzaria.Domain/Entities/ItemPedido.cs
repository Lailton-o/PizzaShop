using Pizzaria.Infra.Shared.Entities;
using System;

namespace Pizzaria.Domain.Entities
{
    public class ItemPedido : Entity
    {
        public Guid PedidoId { get; set; }
        public short Quantidade { get; set; }
        public virtual Pedido Pedido { get; set; }
    }
}
