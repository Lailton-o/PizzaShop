using System;

namespace Pizzaria.Domain.Entities
{
    public class ItemPedido
    {
        public Guid PedidoId { get; set; }
        public short Quantidade { get; set; }
        public virtual Pedido Pedido { get; set; }
    }
}
