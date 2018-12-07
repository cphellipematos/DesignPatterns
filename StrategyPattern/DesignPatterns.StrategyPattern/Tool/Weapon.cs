using DesignPatterns.StrategyPattern.Tool.Interface;

namespace DesignPatterns.StrategyPattern.Tool
{
    public class Weapon : IWeapon
    {
        private readonly IWeapon _weapon;
        public Weapon(IWeapon weapon)
        {
            _weapon = weapon;
        }

        public string Act()
        {
            return _weapon.Act();
        }
    }
}