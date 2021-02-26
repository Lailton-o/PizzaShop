using PizzaShop.Shared.Entities;
using System;

namespace PizzaShop.Domain.Entities
{
    public class Produto : Entity
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public string Foto { get; set; }
        public bool Disponivel { get; set; }
        public Guid TipoProdutoId { get; set; }

        public virtual TipoProduto TipoProduto { get; set; }
    }
}
