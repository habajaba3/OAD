using PaywallGame.Models;

namespace PaywallGame.Strategies
{
    public class LevelAccessStrategy : IAccessStrategy
    {
        private int requiredLevel;

        public LevelAccessStrategy(int level)
        {
            requiredLevel = level;
        }

        public bool CanAccess(Player player)
        {
            return player.Level >= requiredLevel;
        }

        public string GetInfo()
        {
            return $"Dostęp od poziomu {requiredLevel}.";
        }
    }
}