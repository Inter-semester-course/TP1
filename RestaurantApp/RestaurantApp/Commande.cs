using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    internal class Commande
    {
        public int Numero { get; set; }
        public Client Client { get; set; }
        public List<Plat> Plats { get; set; }

        public Commande()
        {
            Numero = 0;
            Client = new Client();
            Plats = new List<Plat>();
        }
    }
}
