using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    internal class Plat
    {
        public string id { get; set; }
        public string nom { get; set; }
        public int prix { get; set; }

        public Plat()
        {
            id = "INCONNU";
            nom = "INCONNU";
            prix = 0;
        }

        public List<Plat> Plats = new List<Plat>();
        public void addNewPlat()
        {
            Plats.Add(new Plat() { id = id, nom = nom, prix = prix });
            Console.WriteLine(Plats);
        }
    }
}
