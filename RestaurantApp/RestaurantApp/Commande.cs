using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    internal class Commande
    {
        List<Plat> menu = new List<Plat>();
        List<Client> clients = new List<Client>()
        {
            new Client ("1","Rabe","033 12 158 58"),
            new Client ("2","Rasoa","032 55 147 78")
        };
        public int Numero { get; set; }
        public Client client { get; set; }
        public List<Plat> Plats { get; set; }

        public Commande(int Numero,Client client,List<Plat>plats)
        {
            this.Numero = Numero;
            this.client = client;
            this.Plats = plats;

        }

        public Commande()
        {
            this.Numero = Numero;
            this.Plats = new List<Plat>();
            this.client = new Client("","","");
        }

        public void PrendreLaCommande()
        {
            Console.Write("Veuilez saisir l'id du client: ");
            client.id =  Console.ReadLine();

            Client clientTrouve = clients.FirstOrDefault(c => c.id == client.id);

            if (clientTrouve != null)
            {
                client = clientTrouve;
                Console.WriteLine($"Le client ayant l'ID {client.id} est {client.nom}");
            }
            else
            {
                Console.WriteLine("Client non trouvé.");
            }
        }
    }
}
