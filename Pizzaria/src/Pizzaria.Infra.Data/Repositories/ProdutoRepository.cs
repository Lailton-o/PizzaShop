using Pizzaria.Domain.Contracts.Repository;
using Pizzaria.Domain.Entities;
using Pizzaria.Infra.Data.Context;
using Pizzaria.Infra.Data.Repositories.Common;

namespace Pizzaria.Infra.Data.Repositories
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(PizzariaContext context) : base(context)
        {

        }
    }
}
