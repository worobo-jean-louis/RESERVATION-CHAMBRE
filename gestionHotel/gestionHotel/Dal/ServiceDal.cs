using gestionHotel.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionHotel.Dal
{
    public class ServiceDal
    {
        public gestionHotelEntities2 DbContext { get; set; }
        public Service service { get; set; }

        public ServiceDal()
        {
            DbContext = new gestionHotelEntities2();
            service = new Service();
        }
        public Service Enregistrer(Service services)
        {
            service = services;
            Service CreationService = DbContext.Service.Add(service);
            DbContext.SaveChanges();
            return CreationService;
        }
        public Service Modifier(Service services)
        {
            service = services;
            DbContext.SaveChanges();
            return service ;
        }
        public Service supprimer(int Id)
        {
            service = DbContext.Service.SingleOrDefault(service => service.Id_service == Id);
            Service SuppressionService = DbContext.Service.Remove(service);
            DbContext.SaveChanges();
            return SuppressionService;
        }
        public List<Service> FindByName(string Nom)
        {
            List<Service> FoundService = DbContext.Service.ToList();
            FoundService = FoundService.Where(
                Service => (Service.Nom_service.IndexOf(Nom, StringComparison.CurrentCultureIgnoreCase) != -1))
                .ToList();
            return FoundService;
        }
        public List<Service> FindAll()
        {
            return DbContext.Service.ToList();
        }
        public bool Exist(int Id)
        {
            return DbContext.Service.SingleOrDefault(Service => Service.Id_service == Id) != null;
        }
    }
}
