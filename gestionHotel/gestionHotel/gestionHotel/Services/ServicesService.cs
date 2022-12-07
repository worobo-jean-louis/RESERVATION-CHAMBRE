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

        public int CreateService(Service service)
        {
            int done = serviceDal.CreatedService(service);
            if (done == 0)
                return 0;
            else
                return done;
        }
        public int SupprimerService(int id)
        {
            return serviceDal.supprimer(id);
        }

        public int Modifier(Service service)
        {
            return serviceDal.Modifier(service);
        }
        /*public int Rechercher(string nom)
        {
            return clientDal.Recherche(nom);
        }*/

        public List<Service> GetService()
        {
            List<Service> service = serviceDal.GetService();
            return service;
        }

        public int getLength()
        {
            return serviceDal.GetLength();
        }

        public List<Service> GetServices()
        {
            return serviceDal.GetService();
        }
        public int modifierSer(Service service)
        {
            int mod = serviceDal.Modifier(service);
            if (mod == 0)
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
