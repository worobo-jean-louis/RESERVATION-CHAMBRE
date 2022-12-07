using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionHotel.Entity
{
     public class Service
     {
        public int Id_service { get; set; }
        public string Nom_service { get; set; }
        public Nullable<int> Prix_unitaire { get; set; }
        public Nullable<int> Quantite { get; set; }
        public Nullable<int> Total { get; set; }
        public Nullable<int> Id_chambre { get; set; }
        public Chambres Chambre { get; set; }
        public virtual ICollection<Factures> Facture { get; set; }

        public Service(int id_service, string nom_service, int? prix_unitaire, int? quantite, int? total, int? id_chambre)
        {
            Id_service = id_service;
            Nom_service = nom_service;
            Prix_unitaire = prix_unitaire;
            Quantite = quantite;
            Total = total;
            Id_chambre = id_chambre;
           
        }
        public Service(string nom_service, int? prix_unitaire, int? quantite, int? total, int? id_chambre)
        {
            
            Nom_service = nom_service;
            Prix_unitaire = prix_unitaire;
            Quantite = quantite;
            Total = total;
            Id_chambre = id_chambre;

        }
        public Service( string nom_service, int? prix_unitaire, int? quantite, int? total, int? id_chambre, Chambres chambre, ICollection<Factures> facture) 
            
        {
            Chambre = chambre;
            Facture = facture;
        }

        public Service()
        {
        }
    }
}
