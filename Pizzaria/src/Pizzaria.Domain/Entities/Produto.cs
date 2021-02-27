using Pizzaria.Infra.Shared.Entities;

namespace Pizzaria.Domain.Entities
{
    public class Produto : Entity
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public bool Disponivel { get; set; }
    }
}
