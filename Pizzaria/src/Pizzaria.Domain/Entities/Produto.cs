namespace Pizzaria.Domain.Entities
{
    public class Produto
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public bool Disponivel { get; set; }
    }
}
