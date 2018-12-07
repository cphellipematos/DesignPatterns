using System;
using DesignPatterns.StrategyPattern.Character;
using DesignPatterns.StrategyPattern.Tool;
using DesignPatterns.StrategyPattern.Tool.Interface;

namespace DesignPatterns.StrategyPattern.App
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("-----------------");
            Console.WriteLine("Use weapon");
            Console.WriteLine("-----------------");
            Console.WriteLine();
            Console.WriteLine("1 - Shoot");
            Console.WriteLine("2 - Stab");
            Console.WriteLine("3 - Through Bomb");

            var selectedOption = Console.ReadLine();
            IWeapon weapon = null;

            switch ((EWeaponCommand)Enum.Parse(typeof(EWeaponCommand), selectedOption))
            {
                case(EWeaponCommand.Shoot):
                {
                    var gun = new Gun();
                    weapon = new Weapon(gun);
                    break;
                }
                case(EWeaponCommand.Knife):
                {
                    var knife = new Knife();
                    weapon = new Weapon(knife);
                    break;
                }
                case(EWeaponCommand.Bomb):
                {
                    var bomb = new Bomb();
                    weapon = new Weapon(bomb);
                    break;
                }
                
            }

            var character = new CounterStrike(weapon);
            string action = character.Weapon.Act();

            Console.WriteLine(action); 
        }
    }
}
