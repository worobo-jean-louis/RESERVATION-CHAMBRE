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
        public Client Enregistrer(string Nom,string Prenom,string Adresse,string Genre,string status,int telephone)
        {
            Client client = new Client
            {
                Nom = Nom,
                Prenom = Prenom,
                Adresse = Adresse,
                Genre = Genre,
                Status = status,
                Telephone = telephone,
            };
            return clientService.VerificationClient(client);

        }
        public Client modifier(string Nom, string Prenom, string Adresse, string Genre, string status, int telephone)
        {
            Client client = new Client
            {
                Nom = Nom,
                Prenom = Prenom,
                Adresse = Adresse,
                Genre = Genre,
                Status = status,
                Telephone = telephone,
            };
            return clientService.Modifier(client);
        }
        public Client Supprimer(int id)
        {
            return clientService.Supprimer(id);
        }
        public List<Client> FindAll()
        {
            return clientService.FindAll();
        }
        public List<Client> FindByName(string Nom,string Prenom)
        {
            return clientService.FindByName(Nom,Prenom);
        }
    }
}
