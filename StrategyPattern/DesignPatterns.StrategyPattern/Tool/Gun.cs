using DesignPatterns.StrategyPattern.Tool.Interface;

namespace DesignPatterns.StrategyPattern
{
    public class Gun : IWeapon
    {
        public string Act()
        {
            return "•  •  • 🔫";
        }
    }
}