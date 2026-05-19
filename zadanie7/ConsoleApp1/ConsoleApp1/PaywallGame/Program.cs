using PaywallGame.Enums;
using PaywallGame.Factory;
using PaywallGame.Models;
using PaywallGame.Services;
using PaywallGame.Strategies;

namespace PaywallGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player
            {
                Name = "Kacper",
                Level = 12,
                IsPremium = false,
                HasDlc = true
            };

            Console.WriteLine("=== FREE ACCESS ===");

            IAccessStrategy freeStrategy =
                AccessStrategyFactory.CreateStrategy(AccessType.Free);

            PaywallService freeService =
                new PaywallService(freeStrategy);

            freeService.CheckAccess(player);

            Console.WriteLine();


            Console.WriteLine("=== PREMIUM ACCESS ===");

            IAccessStrategy premiumStrategy =
                AccessStrategyFactory.CreateStrategy(AccessType.Premium);

            PaywallService premiumService =
                new PaywallService(premiumStrategy);

            premiumService.CheckAccess(player);

            Console.WriteLine();


            Console.WriteLine("=== LEVEL ACCESS ===");

            IAccessStrategy levelStrategy =
                AccessStrategyFactory.CreateStrategy(AccessType.Level);

            PaywallService levelService =
                new PaywallService(levelStrategy);

            levelService.CheckAccess(player);

            Console.WriteLine();


            Console.WriteLine("=== DLC ACCESS ===");

            IAccessStrategy dlcStrategy =
                AccessStrategyFactory.CreateStrategy(AccessType.Dlc);

            PaywallService dlcService =
                new PaywallService(dlcStrategy);

            dlcService.CheckAccess(player);
        }
    }
}