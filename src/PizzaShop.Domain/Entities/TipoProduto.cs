using PizzaShop.Shared.Entities;

namespace PizzaShop.Domain.Entities
{
    public class TipoProduto : Entity
    {
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
    }
}
