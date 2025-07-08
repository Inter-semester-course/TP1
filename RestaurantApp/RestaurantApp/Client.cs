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

        public Client(string id, string nom, string contact)
        {
            this.id = id;
            this.nom = nom;
            this.contact = contact;
        }

        public override string ToString()
        {
            return $"ID: {id}, Nom: {nom}, Contact: {contact}";
        }
    }
}
