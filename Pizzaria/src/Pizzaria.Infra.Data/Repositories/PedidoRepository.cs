using Pizzaria.Domain.Contracts.Repository;
using Pizzaria.Domain.Entities;
using Pizzaria.Infra.Data.Context;
using Pizzaria.Infra.Data.Repositories.Common;

namespace Pizzaria.Infra.Data.Repositories
{
    public class PedidoRepository : Repository<Pedido>, IPedidoRepository
    {
        public PedidoRepository(PizzariaContext context) : base(context)
        {

        }
    }
}
