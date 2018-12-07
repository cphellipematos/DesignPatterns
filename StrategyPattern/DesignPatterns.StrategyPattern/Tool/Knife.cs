using DesignPatterns.StrategyPattern.Tool.Interface;

namespace DesignPatterns.StrategyPattern.Tool
{
    public class Knife : IWeapon
    {
        public string Act()
        {
            return "🔪  🔪  🔪";
        }    
    }
}