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
            //Creation de menu et affichage:
            Menu menu = new Menu();

            menu.addPlat();
            menu.showMenu();
           

        // Création et prise de commande
        Commande c1 = new Commande(menu);
        c1.PrendreLaCommande();

            Console.WriteLine($"\nRésumé de la commande du client {c1.client.nom} :");
            foreach (var p in c1.Plats)
            {
                Console.WriteLine($"- {p.nom} : {p.prix} Ar");
            }

          //  Console.WriteLine($"\nLe client portant l'ID: '{C1.client.id}' a passee sa commande");

        Console.ReadKey();
        }
    }
}
