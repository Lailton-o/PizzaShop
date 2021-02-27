using System;
using System.Collections.Generic;

namespace Pizzaria.Domain.Entities
{
    public class Pedido
    {
        public Guid StatusPedidoId { get; set; }
        public decimal Valor { get; set; }

        public virtual IEnumerable<ItemPedido> Itens { get; set; }
    }
}
