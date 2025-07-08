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


        public Plat(string id, string nom, int prix)
        {
            this.id = id;
            this.nom = nom;
            this.prix = prix;
        }

        public override string ToString()
        {
            return $"ID: {id}, Nom: {nom}, Prix: {prix} Ar";
        }
    }
}
