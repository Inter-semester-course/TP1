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
            Plat P1 = new Plat();
            Console.Write("Quel est le nom du plat: ");
            P1.nom = Console.ReadLine();
            Console.Write($"Quel est l'ID du {P1.nom}: ");
            P1.id = Console.ReadLine();
            Console.Write($"Quel est le Prix du {P1.nom}: ");
            P1.prix = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Le plat portant l'ID: {P1.id} est le: {P1.nom}");

            P1.addNewPlat();

            Console.ReadKey();
        }
    }
}
