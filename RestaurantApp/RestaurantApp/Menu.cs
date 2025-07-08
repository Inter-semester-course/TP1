using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    internal class Menu
    {
        public List<Plat> ListePlat { get; private set; } = new List<Plat>();

        public void addPlat()
        {
            while (true)
            {
                Console.Write("Quel est le nom du plat (ou 'stop' pour finir): ");
                string nom = Console.ReadLine();

                if (nom.ToLower() == "stop")
                    break;

                Console.Write($"\nQuel est l'ID du {nom}: ");
                string id = Console.ReadLine();

                Console.Write($"\nQuel est le Prix du {nom}: ");
                int prix = Convert.ToInt32(Console.ReadLine());

                ListePlat.Add(new Plat(id, nom, prix));
            }
        }

        public void showMenu()
        {
            Console.WriteLine("\n--- Menu Complet ---");
            foreach (Plat plat in ListePlat)
            {
                Console.WriteLine(plat);
            }
        }
    }
}
