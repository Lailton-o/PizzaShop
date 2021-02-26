using PizzaShop.Shared.Entities;
using System;
using System.Collections.Generic;

namespace PizzaShop.Domain.Entities
{
    public class Pedido : Entity
    {
        public Guid ClienteId { get; set; }
        public decimal Total { get; set; }
        public Guid StatusId { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual StatusPedido Status { get; set; }
        public virtual ICollection<ItemPedido> Itens { get; set; }
    }
}
