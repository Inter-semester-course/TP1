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
        public List<Plat> Menu { get; set; }
        public Menu Menu1 { get; set; }

        public Commande(int Numero,Client client,List<Plat>plats )
        {
            this.Numero = Numero;
            this.client = client;
            this.Plats = plats;

        }

        public Commande(Menu menu)
        {
            this.Menu = menu.ListePlat;
            this.Plats = new List<Plat>();
            this.client = new Client("", "", "");
        }


        public void PrendreLaCommande()
        {
            
                Console.WriteLine("\n=== Info Client ===");
                Console.Write("\nID: ");
                client.id = Console.ReadLine();

                Console.Write("\nNom: ");
                client.nom = Console.ReadLine();

                Console.Write("\nContact : ");
                client.contact = Console.ReadLine();

                clients.Add(client);

            Console.WriteLine("\n=== Menu ===");
            for (int i = 0; i < Menu.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Menu[i]}");
            }

            Console.WriteLine("Saisir les numéros des plats commandés :");
            string[] choix = Console.ReadLine().Split(',');

            foreach (var c in choix)
            {
                if (int.TryParse(c.Trim(), out int index) && index >= 1 && index <= Menu.Count)
                {
                    Plat platChoisi = Menu[index - 1];
                    Plats.Add(platChoisi);
                    client.Plats.Add(platChoisi);
                }
            }

            Console.WriteLine($"\nCommande enregistrée pour {client.nom} avec {Plats.Count} plat(s).");


            /*
             * Si client deja enregistree
             * Console.Write("Veuilez saisir l'id du client: ");
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
            */
        }
    }
}
