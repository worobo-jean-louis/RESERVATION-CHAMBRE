using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gestionHotel.Entity;
using gestionHotel.Dal;
using gestionHotel.Services;

namespace gestionHotel.Controller
{
    public class ClientController
    {
        public ClientService clientService;

        public ClientController()
        {
          this.clientService = new ClientService();
        }
        public int Enregistrer( string Nom,string Prenom,string Adresse,string Genre,string status,int telephone)
        {
            Clients client = new Clients
            (
                
                 Nom,
               Prenom,
                Adresse,
                 Genre,
               status,
               telephone
            );
            return clientService.CreateClient(client);

        }
        public int modifier(string Nom, string Prenom, string Adresse, string Genre, string status, int telephone)
        {
             Clients client = new Clients
             (
                  Nom,
                Prenom,
              Adresse,
                Genre,
              status,
             telephone
             );
             return clientService.modifierClient(client);
        }
        public int Supprimer(int id)
        {
            return clientService.SupprimerClient(id);
        }
        public int modification(Clients clients)
        {
            return clientService.Modifier(clients);
        }
        public int Rechercher(string nom)
        {
            return clientService.Rechercher(nom);
        }
       /* public Clients GetClient(string data)
        {
            return clientService./GetClient(data);
        }*/
        public int getLength()
        { 
            return clientService.getLength(); 
        }
        public List<Clients> GetClients()
        {
            return clientService.GetClients();
        }

    }

    
}
