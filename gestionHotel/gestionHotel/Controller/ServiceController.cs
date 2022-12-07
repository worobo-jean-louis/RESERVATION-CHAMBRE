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
        public ServicesService ServiceService;

        public ServiceController()
        {
            this.ServiceService = new ServicesService();
        }
        public Service Enregistrer(string Nom_service, int Prix_unitaire, int Quantite, int Total, int Numero_chambre)
        {
            Service service = new Service
            {
                Nom_service = Nom_service,
                Prix_unitaire = Prix_unitaire,
                Quantite = Quantite,
                Total = Total,
                Id_chambre = Numero_chambre,
               
            };
            return ServiceService.VerificationService(service);

        }
        public Service Modifier(string Nom_service, int Prix_unitaire, int Quantite, int Total, int Numero_chambre)
        {
            Service service = new Service
            {
                Nom_service = Nom_service,
                Prix_unitaire = Prix_unitaire,
                Quantite = Quantite,
                Total = Total,
                Id_chambre = Numero_chambre,

            };
            return ServiceService.Modifier(service);

        }
        public Service Supprimer(int id)
        {
            return ServiceService.Supprimer(id);
        }
        public List<Service> FindAll()
        {
            return ServiceService.FindAll();
        }
        public List<Service> FindByName(string Nom)
        {
            return ServiceService.FindByName(Nom);
        }
    }
}

