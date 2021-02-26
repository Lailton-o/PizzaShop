using PizzaShop.Domain.Contracts.Repository;
using PizzaShop.Domain.Entities;
using PizzaShop.Infra.Data.Context;
using PizzaShop.Infra.Data.Repositories.Common;

namespace PizzaShop.Infra.Data.Repositories
{
    public class FuncionarioRepository : Repository<Funcionario>, IFuncionarioRepository
    {
        public FuncionarioRepository(EfContext context) : base(context)
        {

        }
    }
}
