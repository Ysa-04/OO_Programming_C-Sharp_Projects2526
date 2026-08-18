using System;
using System.Collections.Generic;
using System.Text;

namespace Overerving
{
    internal class ChildrenMeal : Meal
    {
        public ChildrenMeal(string name, double price) : base(name, price)
        {

        }
        // Overschrijven van ShowTheMenu voor de kleur en het behoud van het formaat
        public override void ShowMenu()
        {
            // Bewaar de huidige kleur van de console
            ConsoleColor oudeKleur = Console.ForegroundColor;

            // Genereer een willekeurig getal tussen 1 en 15 en cast dit naar ConsoleColor
            // (0 is vaak zwart en kan onleesbaar zijn op een zwarte achtergrond
            Random random = new Random();
            int willekeurigGetal = random.Next(1, 16);
            Console.ForegroundColor = (ConsoleColor)willekeurigGetal;

            // Roep de basislogica aan via base.ShowTheMenu(). 
            // Hierdoor blijft het formaat (zoals het aantal tabs) automatisch gekoppeld!
            base.ShowMenu();

            // Zet de kleur van de console daarna weer terug naar normaal
            Console.ForegroundColor = oudeKleur;
        }
    }
}
