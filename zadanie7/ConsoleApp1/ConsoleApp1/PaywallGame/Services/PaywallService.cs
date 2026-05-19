using PaywallGame.Models;
using PaywallGame.Strategies;

namespace PaywallGame.Services
{
    public class PaywallService
    {
        private readonly IAccessStrategy strategy;

        // Dependency Injection
        public PaywallService(IAccessStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void CheckAccess(Player player)
        {
            Console.WriteLine(strategy.GetInfo());

            if (strategy.CanAccess(player))
            {
                Console.WriteLine($"{player.Name} ma dostęp.");
            }
            else
            {
                Console.WriteLine($"{player.Name} NIE ma dostępu.");
            }
        }
    }
}