using DesignPatterns.StrategyPattern.Tool.Interface;

namespace DesignPatterns.StrategyPattern.Character
{
    public class CounterStrike
    {
        public CounterStrike(IWeapon weapon)
        {
            Weapon = weapon;
        }
        public IWeapon Weapon { get; set; }
        
    }
}