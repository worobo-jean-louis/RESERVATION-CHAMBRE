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
    public class ServiceController
    {
        public ServicesService ServicesService; 

        public ServiceController()
        {
            this.ServicesService = new ServicesService();
        }
        public int Enregistrer(string Nom, int  Prix_unitaire, int quantite, int total, int id_chambre)
        {
            Service service= new Service
            (

                 Nom,
                Prix_unitaire, 
                quantite,
               total,
               id_chambre

            );
            return ServicesService.CreateService(service);

        }
        public int Modifier(string Nom, int Prix_unitaire, int quantite, int total, int id_chambre)
        {
            Service service = new Service
            (

                 Nom,
                Prix_unitaire,
                quantite,
               total,
               id_chambre

            );
            return ServicesService.modifierSer(service);

        }
        public int Supprimer(int id)
        {
            return ServicesService.SupprimerService(id);
        }
        public int modification(Service service)
        {
            return ServicesService.Modifier(service);
        }

        /* public Clients GetClient(string data)
         {
             return clientService./GetClient(data);
         }*/
        public int getLength()
        {
            return ServicesService.getLength();
        }
        public List<Service> GetServices()
        {
            return ServicesService.GetServices();
        }

    }
}
