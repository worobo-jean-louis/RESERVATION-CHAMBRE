using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionHotel.Entity
{
    public class Factures
    {
        public int Id { get; set; }
        public Nullable<int> Montant_total { get; set; }
        public Nullable<int> Id_client { get; set; }
        public Nullable<int> Id_chambre { get; set; }
        public Nullable<int> Id_service { get; set; }

        public virtual Chambres Chambre { get; set; }
        public virtual Clients Client { get; set; }
        public virtual Service Service { get; set; }
    }
}
