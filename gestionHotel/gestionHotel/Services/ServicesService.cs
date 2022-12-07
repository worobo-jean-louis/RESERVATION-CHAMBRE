using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gestionHotel.Dal;
using gestionHotel.Entity;

namespace gestionHotel.Services
{
    public class ServicesService
    {
        public ServiceDal serviceDal;

        public ServicesService()
        {
            this.serviceDal = new ServiceDal();
        }
        public Service VerificationService(Service service)
        {
            try
            {
                List<Service> VerifyServices = FindByName(service.Nom_service);
                if (VerifyServices.Count == 0)
                {
                    return serviceDal.Enregistrer(service);
                }
                else
                {
                    throw new Exception("Erreur: Ce service est deja cree !");
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Erreur: {ex.Message}");
            }
        }
        public Service Modifier(Service service)
        {
            try
            {
                if (serviceDal.Exist(service.Id_service))
                {
                    return serviceDal.Modifier(service);
                }
                else
                {
                    throw new Exception("Erreur: Ce service à modifier existe pas !");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erreur: {ex.Message}");
            }
        }
        public Service Supprimer(int id)
        {
            try
            {
                if (serviceDal.Exist(id))
                {
                    return serviceDal.supprimer(id);
                }
                else
                {
                    throw new Exception("Erreur: la valeur a supprimer n'existe pas !");
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Erreur: {ex.Message}");
            }
        }

        public List<Service> FindByName(string nom)
        {
            return serviceDal.FindByName(nom);
        }
        public List<Service> FindAll()
        {
            return serviceDal.FindAll();
        }

    }
}

