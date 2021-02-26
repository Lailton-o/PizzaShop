using PizzaShop.Domain.Contracts.Repository;
using PizzaShop.Domain.Entities;
using PizzaShop.Infra.Data.Context;
using PizzaShop.Infra.Data.Repositories.Common;

namespace PizzaShop.Infra.Data.Repositories
{
    public class TipoProdutoRepository : Repository<TipoProduto>, ITipoProdutoRepository
    {
        public TipoProdutoRepository(EfContext context) : base(context)
        {

        }
    }
}
