using PizzaShop.Domain.Contracts.Repository;
using PizzaShop.Domain.Entities;
using PizzaShop.Infra.Data.Context;
using PizzaShop.Infra.Data.Repositories.Common;

namespace PizzaShop.Infra.Data.Repositories
{
    public class StatusPedidoRepository : Repository<TipoProduto>, ITipoProdutoRepository
    {
        public StatusPedidoRepository(EfContext context) : base(context)
        {

        }
    }
}
