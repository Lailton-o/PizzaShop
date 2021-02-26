using System.Threading.Tasks;

namespace PizzaShop.Shared.Data
{
    public interface IUnitOfWork
    {
        bool Commit();
    }
}
