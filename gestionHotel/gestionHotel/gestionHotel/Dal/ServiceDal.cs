using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using gestionHotel.View;
using gestionHotel.Entity;

namespace gestionHotel.Dal
{
    public class ServiceDal
    {
        public Service service { get; set; }

        public ServiceDal()
        {

        }
        public int CreatedService(Service services)
        {
            string requeteService = "INSERT INTO Service( Nom_service,Prix_unitaire, Quantite, Total, Id_chambre) VALUES ('" + services.Nom_service + "' ,' " + services.Prix_unitaire + " ' , ' " + services.Quantite + " ' , ' " + services.Total + " ' , ' " + services.Id_chambre + "' )";
            Connexion.conn.Open();
            Connexion.command = Connexion.conn.CreateCommand();
            Connexion.command.CommandText = requeteService;
            Connexion.command.ExecuteNonQuery();
            Connexion.conn.Close();
            return 1;
        }
        public int Modifier(Service services)
        {
            string requeteModService = "UPDATE Service SET Nom_service = " + services.Nom_service + "Prix_unitaire " + services.Prix_unitaire + "Quantite = " + services.Quantite + "Total = " + services.Total + "Id_chambre=" + services.Chambre + "WHERE Id =" + services.Id_service;
            Connexion.conn.Open();
            Connexion.command = Connexion.conn.CreateCommand();
            Connexion.command.CommandText = requeteModService;
            Connexion.command.ExecuteNonQuery();
            Connexion.conn.Close();
            return 1;


        }

        public int supprimer(int id)
        {
            string requeteSupService = "DELETE FROM Service WHERE Id_service = " + id;
            Connexion.conn.Open();
            Connexion.command = Connexion.conn.CreateCommand();
            Connexion.command.CommandText = requeteSupService;
            Connexion.command.ExecuteNonQuery();
            Connexion.conn.Close();
            return 1;

        }
        public int Recherche(string nom)
        {

            string RequeteRechercher = "SELECT * FROM Service WHERE Nom='" + nom;
            Connexion.conn.Open();
            Connexion.command = Connexion.conn.CreateCommand();
            Connexion.command.CommandText = RequeteRechercher;
            Connexion.command.ExecuteNonQuery();
            Connexion.conn.Close();
            return 1;


        }
        public List<Service> GetService()
        {
            string query = "select * from Service ";
            Connexion.conn.Open();
            Connexion.command = Connexion.conn.CreateCommand();
            Connexion.command.CommandText = query;
            var reader = Connexion.command.ExecuteReader();
            //Connexion.conn.Close();
            Service services = new Service();
            Clients clients = new Clients();
            List<Service> liste = new List<Service>();
            //Connexion.conn.Open();
            while (reader.Read())
            {
                services = new Service();
                services.Id_service = reader.GetInt32(0);
                services.Nom_service = reader.GetString(1);
                services.Prix_unitaire = reader.GetInt32(2);
                services.Quantite = reader.GetInt32(3);
                services.Total= reader.GetInt32(4); ;
                services.Id_chambre = reader.GetInt32(5);
       
                liste.Add(services);

            }
            Connexion.conn.Close();

            return liste;
        }

        public int GetLength()
        {
            string query = "select count(*) from Service";
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
