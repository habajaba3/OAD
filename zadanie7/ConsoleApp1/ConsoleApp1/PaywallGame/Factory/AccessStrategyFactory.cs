using PaywallGame.Enums;
using PaywallGame.Strategies;

namespace PaywallGame.Factory
{
    public class AccessStrategyFactory
    {
        public static IAccessStrategy CreateStrategy(AccessType type)
        {
            switch (type)
            {
                case AccessType.Free:
                    return new FreeAccessStrategy();

                case AccessType.Premium:
                    return new PremiumAccessStrategy();

                case AccessType.Level:
                    return new LevelAccessStrategy(10);

                case AccessType.Dlc:
                    return new DlcAccessStrategy();

                default:
                    throw new Exception("Nieznany typ dostępu.");
            }
        }
    }
}