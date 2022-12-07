using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gestionHotel.Dal;
using gestionHotel.Entity;

namespace gestionHotel.Services
{
    public class ChambreService
    {
        public ChambreDal chambreDal;

        public ChambreService()
        {
            this.chambreDal = new ChambreDal();
        }

        public int CreatedChambres(Chambres Chambre)
        {
            int done = chambreDal.CreatedChambres(Chambre);
            if (done == 0)
                return 0;
            else
                return done;
        }
        public int supprimer(int id)
        {
            return chambreDal.supprimer(id);
        }

        public int Modifier(Chambres chambre)
        {
            return chambreDal.Modifier(chambre);
        }
        /*public int Rechercher(string nom)
        {
            return clientDal.Recherche(nom);
        }*/

        public List<Chambres> Getchambre()
        {
            List<Chambres> chambre = chambreDal.GetChambres();
            return chambre;
        }

        public int getLength()
        {
            return chambreDal.GetLength();
        }

        public List<Chambres> Getchambres()
        {
            return chambreDal.GetChambres();
        }
        public int modifierchambre(Chambres chambre)
        {
            int mod = chambreDal.Modifier(chambre);
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
