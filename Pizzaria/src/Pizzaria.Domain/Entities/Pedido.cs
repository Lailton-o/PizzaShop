using Pizzaria.Infra.Shared.Entities;
using System;
using System.Collections.Generic;

namespace Pizzaria.Domain.Entities
{
    public class Pedido : Entity
    {
        public Guid StatusPedidoId { get; set; }
        public decimal Valor { get; set; }

        public virtual StatusPedido Status { get; set; }
        public virtual IEnumerable<ItemPedido> Itens { get; set; }
    }
}
