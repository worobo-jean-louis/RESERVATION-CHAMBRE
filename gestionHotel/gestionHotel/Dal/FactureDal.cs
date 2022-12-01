using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gestionHotel.Entity;


namespace gestionHotel.Dal
{
    public class FactureDal : Facture
    {
        public gestionHotelEntities2 DbContext { get; set; }
        public Facture factures { get; set; }

        public FactureDal()
        {
            DbContext = new gestionHotelEntities2();
            factures = new Facture();
        }
        public Facture Enregistrer(Facture facture)
        {
            factures = facture;
            Facture GenererFacture = DbContext.Facture.Add(factures);
            DbContext.SaveChanges();
            return GenererFacture;
        }

        public Facture Modifier(Facture facture)
        {
            factures = facture;
            //Facture ModifierFacture = DbContext.Facture.Add(factures);
            DbContext.SaveChanges();
            return facture;
        }

        public Facture Supprimer(Facture facture)
        {
            factures = facture;
            Facture SupprimerFacture = DbContext.Facture.Remove(factures);
            DbContext.SaveChanges();
            return SupprimerFacture;
        }



    }

}
