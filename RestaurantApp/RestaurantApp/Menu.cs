using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    internal class Menu
    {
        List<Plat> menu = new List<Plat>();

        public void addPlat()
        {
            while (true)
            {
                Console.Write("Quel est le nom du plat (ou 'stop' pour finir): ");
                string nom = Console.ReadLine();

                if (nom.ToLower() == "stop")
                    break;

                Console.Write($"Quel est l'ID du {nom}: ");
                string id = Console.ReadLine();

                Console.Write($"Quel est le Prix du {nom}: ");
                int prix = Convert.ToInt32(Console.ReadLine());

                Plat plat = new Plat(id, nom, prix);
                menu.Add(plat);
            }
        }
        
        public void showMenu()
        {
            Console.WriteLine("\n--- Menu Complet ---");
            foreach (Plat plat in menu)
            {
                Console.WriteLine(plat);
            }
        }
    }
}
