using PizzaShop.Shared.Entities;
using System;

namespace PizzaShop.Domain.Entities
{
    public class PedidoLog : Entity
    {
        public Guid ClienteId { get; set; }
        public Guid PedidoId { get; set; }
        public Guid FuncionarioId { get; set; }
        public string Ocorrido { get; set; }
        public DateTime DataOcorrido { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual Pedido Pedido { get; set; }
        public virtual Funcionario Funcionario { get; set; }
    }
}
