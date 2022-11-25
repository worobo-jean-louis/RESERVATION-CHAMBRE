using gestionHotel.Dal;
using gestionHotel.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace gestionHotel.Services
{
    public class ClientService
    {
        public ClientDal clientDal;

        public ClientService()
        {
            this.clientDal = new ClientDal();
        }

       public Client VerificationClient(Client client)
       {
            try
            {
                List<Client> Verifyclients = FindByName(client.Nom,client.Prenom);
                if (Verifyclients.Count == 0)
                {
                    return clientDal.Enregistrer(client);
                }
                else
                {
                    throw new Exception("Erreur: Ce client est deja cree !");
                }

            }
            catch(Exception ex)
            {
                throw new Exception($"Erreur: {ex.Message}");
            }
       }
        public Client Modifier(Client client)
        {
            try
            {
                if (clientDal.Exist(client.Id_client))
                {
                    return clientDal.Modifier(client);
                }
                else
                {
                    throw new Exception("Erreur: Ce client est deja ca modifier existe pas !");
                }
            }catch(Exception ex)
            {
                throw new Exception($"Erreur: {ex.Message}");
            }
        }
        public Client Supprimer(int id)
        {
            try
            {
                if(clientDal.Exist(id))
                {
                    return clientDal.supprimer(id);
                }
                else
                {
                    throw new Exception("Erreur: la valeur a supprimer n'existe pas !");
                }

            }
            catch(Exception ex)
            {
                throw new Exception($"Erreur: {ex.Message}");
            }
        }

        public List<Client> FindByName(string nom, string prenom)
        {
            return clientDal.FindByName(nom, prenom);
        }
        public List<Client> FindAll()
        {
            return clientDal.FindAll();
        }
       
    }
}
