using PizzaShop.Domain.Contracts.Repository;
using PizzaShop.Domain.Entities;
using PizzaShop.Infra.Data.Context;
using PizzaShop.Infra.Data.Repositories.Common;

namespace PizzaShop.Infra.Data.Repositories
{
    public class PedidoLogRepository : Repository<PedidoLog>, IPedidoLogRepository
    {
        public PedidoLogRepository(EfContext context) : base(context)
        {

        }
    }
}
