using PizzaShop.Shared.Entities;

namespace PizzaShop.Domain.Entities
{
    public class Cliente : Entity
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Avatar { get; set; }
    }
}
