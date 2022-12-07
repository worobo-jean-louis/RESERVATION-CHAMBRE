using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionHotel.Entity
{
    public class Chambres
    {
        

        public int Id_chambre { get; set; }
        public string Nom_chambre { get; set; }
        public Nullable<int> Numero_chambre { get; set; }
        public string Type_chambre { get; set; }

        public Chambres ( int id_chambre, string nom_chambre, int? numero_chambre, string type_chambre)
        {
            Id_chambre = id_chambre;
            Nom_chambre = nom_chambre;
            Numero_chambre = numero_chambre;
            Type_chambre = type_chambre;
        }
        public Chambres( string nom_chambre, int? numero_chambre, string type_chambre)
        {
            Nom_chambre = nom_chambre;
            Numero_chambre = numero_chambre;
            Type_chambre = type_chambre;
        }

        public Chambres()
        {
        }
    }
}
