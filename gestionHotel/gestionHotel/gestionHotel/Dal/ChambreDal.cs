using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gestionHotel.Dal;
using gestionHotel.Entity;

namespace gestionHotel.Dal
{
   public class ChambreDal
    {
        public Chambres Chambre { get; set; }
        public ChambreDal()
        {

        }
        public int CreatedChambres(Chambres Chambre)
        {
            string requeteChambres = "INSERT INTO Chambre (Nom_chambre,Numero_chambre,Type_chambre) VALUES ('" + Chambre.Nom_chambre + "' ,' " + Chambre.Numero_chambre + " ' , ' " + Chambre.Type_chambre + " ' )";
            Connexion.conn.Open();
            Connexion.command = Connexion.conn.CreateCommand();
            Connexion.command.CommandText = requeteChambres;
            Connexion.command.ExecuteNonQuery();
            Connexion.conn.Close();
            return 1;
       
        }
        public int Modifier(Chambres Chambre)
        {
            string requeteModChambre = "UPDATE Chambre SET Nom_chambre = " + Chambre.Nom_chambre + "Numero = " + Chambre.Numero_chambre + "Type = " + Chambre.Type_chambre + "WHERE Id =" + Chambre.Id_chambre;
            Connexion.conn.Open();
            Connexion.command = Connexion.conn.CreateCommand();
            Connexion.command.CommandText = requeteModChambre;
            Connexion.command.ExecuteNonQuery();        
            Connexion.conn.Close();
            return 1;
        }

        public int supprimer(int id)
        {
            string requeteSupChambre = "DELETE FROM Chambre WHERE id_chambre = " + id;
            Connexion.conn.Open();
            Connexion.command = Connexion.conn.CreateCommand();
            Connexion.command.CommandText = requeteSupChambre;
            Connexion.command.ExecuteNonQuery();            
            Connexion.conn.Close();
            return 1;
        }
        public List<Chambres> GetChambres()
        {
            string query = "select * from Chambre ";
            Connexion.conn.Open();
            Connexion.command = Connexion.conn.CreateCommand();
            Connexion.command.CommandText = query;
            var reader = Connexion.command.ExecuteReader();
            //Connexion.conn.Close();
            Clients clients = new Clients();
            Chambres chambre = new Chambres();
            List<Chambres> liste = new List<Chambres>();
            //Connexion.conn.Open();
            while (reader.Read())
            {
                chambre = new Chambres();
                chambre.Id_chambre= reader.GetInt32(0);
                chambre.Nom_chambre = reader.GetString(1);
                chambre.Numero_chambre = reader.GetInt32(2);
               
                //break;


                liste.Add(chambre);

            }
            Connexion.conn.Close();

            return liste;
        }
        public int GetLength()
        {
            string query = "select count(*) from Chambre";
            int length = 0;
            Connexion.conn.Open();
            Connexion.command = Connexion.conn.CreateCommand();
            Connexion.command.CommandText = query;
            var reader = Connexion.command.ExecuteReader();

            while (reader.Read())
            {
                length = reader.GetInt32(0);
                break;
            }

            return length;
        }

    }
}

