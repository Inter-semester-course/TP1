using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    internal class Client
    {
        public string id { get; set; }
        public string nom { get; set; }
        public string contact { get; set; }

        public Client()
        {
            id = "INCONNU";
            nom = "INCONNU";
            contact = "INCONNU";
        }

    }
}
