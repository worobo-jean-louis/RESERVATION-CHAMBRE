using gestionHotel.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionHotel.Dal
{
    public class ClientDal
    {
        public gestionHotelEntities2 DbContext { get; set; }
        public Client Clients { get; set; }

        public ClientDal()
        {
            DbContext = new gestionHotelEntities2();
            Clients = new Client();
        }
        public Client Enregistrer(Client client)
        {
            Clients = client;
            Client CreationClient = DbContext.Client.Add(Clients);
            DbContext.SaveChanges();
            return CreationClient;
        }
        public Client Modifier(Client client)
        {
            Clients = client;
            DbContext.SaveChanges();
            return Clients;
        }
        public Client supprimer(int Id)
        {
            Clients = DbContext.Client.SingleOrDefault(client => client.Id_client == Id);
            Client SuppressionClient = DbContext.Client.Remove(Clients);
            DbContext.SaveChanges();
            return SuppressionClient;
        }
        public List<Client> FindByName(string Nom,string Prenom)
        {
            List<Client> FoundClients = DbContext.Client.ToList();
            FoundClients = FoundClients.Where(
                Client => (Client.Nom.IndexOf(Nom, StringComparison.CurrentCultureIgnoreCase) != -1) && (Client.Prenom.IndexOf(Prenom, StringComparison.CurrentCultureIgnoreCase) != -1))
                .ToList();
            return FoundClients;
        }
        public List<Client> FindAll()
        {
            return DbContext.Client.ToList();
        }
        public bool Exist(int Id)
        {
            return DbContext.Client.SingleOrDefault(Client => Client.Id_client == Id) != null;
        }

    }
}
