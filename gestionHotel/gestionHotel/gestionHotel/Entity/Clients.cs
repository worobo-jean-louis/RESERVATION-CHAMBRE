using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionHotel.Entity
{
   public class Clients
    {
        public int Id_client { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public string Genre { get; set; }
        public string Status { get; set; }
        public Nullable<int> Telephone { get; set; }

        public Clients(int id_client, string nom, string prenom, string adresse, string genre, string status, int? telephone)
        {
            Id_client = id_client;
            Nom = nom;
            Prenom = prenom;
            Adresse = adresse;
            Genre = genre;
            Status = status;
            Telephone = telephone;
        }
        public Clients(string nom, string prenom, string adresse, string genre, string status, int? telephone)
        {
           
            Nom = nom;
            Prenom = prenom;
            Adresse = adresse;
            Genre = genre;
            Status = status;
            Telephone = telephone;
        }

        public Clients()
        {
        }

        public bool IsNull()
        {
            return this == null;
        }
    }
}
