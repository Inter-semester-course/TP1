using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Creation de menu et affichage:
            Menu menu = new Menu();

            menu.addPlat();
            menu.showMenu();
            */

            Commande C1 = new Commande();
            C1.PrendreLaCommande();

            Console.WriteLine($"\nLe client portant l'ID: '{C1.client.id}' a passee sa commande");

        Console.ReadKey();
        }
    }
}
