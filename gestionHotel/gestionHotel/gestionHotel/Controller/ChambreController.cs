using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gestionHotel.Entity;
using gestionHotel.Dal;
using gestionHotel.Services;

namespace gestionHotel.Controller
{
    public class ChambreController
    {
        public ChambreService chambreService;

        public ChambreController()
        {
            this.chambreService = new ChambreService();
        }
        public int Enregistrer(string Nom_chambre, int Numero_chambre,string Type_chambre)
        {
            Chambres chambres = new Chambres
            (

                Nom_chambre,
                Numero_chambre,
                Type_chambre
                
            );
            return chambreService.CreatedChambres(chambres);

        }
        public int modifier(string Nom_chambre, int Numero_chambre, string Type_chambre)
        {
            Chambres chambres = new Chambres
            (

                Nom_chambre,
                Numero_chambre,
                Type_chambre

            );
            return chambreService.Modifier(chambres);
        }
        public int Supprimer(int id)
        {
            return chambreService.supprimer(id);
        }
        public int modification(Chambres chambres)
        {
            return chambreService.Modifier(chambres);
        }
        /*public int Rechercher(string nom)
        {
            return clientService.Rechercher(nom);
        }*/
       
        public int getLength()
        {
            return chambreService.getLength();
        }
        public List<Chambres> GetChambres()
        {
            return chambreService.Getchambres();
        }


    }
}
