using gestionHotel.Dal;
using gestionHotel.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace gestionHotel.Services
{
    public class ClientService
    {
        public ClientDal clientDal;

        public ClientService()
        {
            this.clientDal = new ClientDal();
        }

        public int CreateClient(Clients client)
        {
            int done = clientDal.CreatedClients(client);
            if(done == 0)
                return 0;
            else 
                return done;
        }
        public int SupprimerClient(int id)
        {
            return clientDal.supprimer(id);
        }

        public int Modifier(Clients clients)
        {
            return clientDal.Modifier(clients);
        }
        public int Rechercher(string nom)
        {
            return clientDal.Recherche(nom);
        }

        public List<Clients> GetClient()
        {
            List<Clients> clients = clientDal.GetClient();
            return clients;
        }

        public int getLength()
        {
            return clientDal.GetLength();
        }

        public List<Clients> GetClients()
        {
            return clientDal.GetClient();
        }
        public int modifierClient(Clients clients)
        {
            int mod = clientDal.Modifier(clients);
            if(mod==0)
            {
                return 0;

            }
            else
            {
                return mod;
            }

        }
       
    }
}
