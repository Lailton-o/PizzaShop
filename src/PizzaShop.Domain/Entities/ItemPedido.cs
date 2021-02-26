using PizzaShop.Shared.Entities;
using System;

namespace PizzaShop.Domain.Entities
{
    public class ItemPedido : Entity
    {
        public Guid ProdutoId { get; set; }
        public Guid PedidoId { get; set; }
        public short Quantidade { get; set; }
        
        public virtual Produto Produto { get; set; }
        public virtual Pedido Pedido { get; set; }
    }
}
