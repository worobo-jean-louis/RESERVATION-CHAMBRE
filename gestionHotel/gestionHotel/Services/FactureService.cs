using gestionHotel.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionHotel.Services
{
    public class FactureService
    {
        public FactureDal factureDal;

        public FactureService()
        {
            factureDal = new FactureDal();
        }
    }
}
