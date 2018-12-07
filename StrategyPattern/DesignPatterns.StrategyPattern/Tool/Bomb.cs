using DesignPatterns.StrategyPattern.Tool.Interface;

namespace DesignPatterns.StrategyPattern.Tool
{
    public class Bomb : IWeapon
    {
        public string Act()
        {
            return "💣 💥💥💥 ";
        }

    }
}