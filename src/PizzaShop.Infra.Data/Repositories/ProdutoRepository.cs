using PizzaShop.Domain.Contracts.Repository;
using PizzaShop.Domain.Entities;
using PizzaShop.Infra.Data.Context;
using PizzaShop.Infra.Data.Repositories.Common;

namespace PizzaShop.Infra.Data.Repositories
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(EfContext context) : base(context)
        {

        }
    }
}
