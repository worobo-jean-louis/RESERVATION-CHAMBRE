using gestionHotel.Dal;
using gestionHotel.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionHotel.Dal
{
    public abstract class FActure
    {
        public abstract List<Facture> FindByName(string Nom, string Prenom);

        public Facture Modifier(Facture facture)
        {
            Facture ModifierFacture = DbContext.Facture.Add(factures);
        }
    }
}