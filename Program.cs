using System;
using Jogo_RPG.src.Entities;

namespace Jogo_RPG.src.Entities
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 42, "Knight", 469, 72);
            Wizard whitewizard = new Wizard("Jennica", 42, "White Wizard", 325, 474);
            Ninja ninja = new Ninja ("Wedge", 42, "Ninja", 292, 89);
            BlackWizard blackWizard = new BlackWizard("Topapa", 42, "BlackWizard", 106, 611);
            
            Console.WriteLine($"{arus.Name} {arus.Level} {arus.HeroType} {arus.HealthPoints} {arus.MagicPoints} {arus.Attack()}");        
            Console.WriteLine($"{whitewizard.Name} {whitewizard.Level} {whitewizard.HeroType} {whitewizard.HealthPoints} {whitewizard.MagicPoints} {whitewizard.Attack()}"); 
            Console.WriteLine($"{ninja.Name} {ninja.Level} {ninja.HeroType} {ninja.HealthPoints} {ninja.MagicPoints} {ninja.Attack()}");       
            Console.WriteLine($"{blackWizard.Name} {blackWizard.Level} {blackWizard.HeroType} {blackWizard.HealthPoints} {blackWizard.MagicPoints} {blackWizard.Attack()}");  

        }
    }
}