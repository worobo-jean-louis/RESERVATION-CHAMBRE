using gestionHotel.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using gestionHotel.View;

namespace gestionHotel.Dal
{
    public class ClientDal
    {
       
        public Clients clients { get; set; }

        public ClientDal()
        {
            
        }
        public int CreatedClients(Clients clients)
        {
            string requeteClient = "INSERT INTO Client( nom, prenom, adresse, genre,  status, telephone) VALUES ('" +clients.Nom + "' ,' " +clients.Prenom + " ' , ' " + clients.Adresse+ " ' , ' " + clients.Genre + " ' , ' " + clients.Status+ "' ,' " + clients.Telephone+ "' )";
            Connexion.conn.Open();
            Connexion.command = Connexion.conn.CreateCommand();
            Connexion.command.CommandText = requeteClient;
            Connexion.command.ExecuteNonQuery();
            Connexion.conn.Close();
            return 1;
        }
        public int Modifier(Clients clients)
        {
            string requeteModclient = "UPDATE Client SET Nom_Client = " + clients.Nom + "Prenom = " + clients.Prenom + "Adresse = " + clients.Adresse + "Genre = " + clients.Genre + " Status =" + clients.Status + " Telephone=" + clients.Telephone + "WHERE Id =" + clients.Id_client;
            Connexion.conn.Open();
            Connexion.command = Connexion.conn.CreateCommand();
            Connexion.command.CommandText = requeteModclient;
            Connexion.command.ExecuteNonQuery();
            Connexion.conn.Close();
            return 1;
           
           
        }
       
        public int supprimer(int id)
        {
            string requeteSupClient = "DELETE FROM Client WHERE id_client = " + id;
            Connexion.conn.Open();
            Connexion.command = Connexion.conn.CreateCommand();
            Connexion.command.CommandText = requeteSupClient;
            Connexion.command.ExecuteNonQuery();
            Connexion.conn.Close();
            return 1;

        }
        public int Recherche(string nom)
        {
           
                string RequeteRechercher = "SELECT * FROM Client WHERE Nom='" + nom;
                Connexion.conn.Open();
                Connexion.command = Connexion.conn.CreateCommand();
                Connexion.command.CommandText = RequeteRechercher;
                Connexion.command.ExecuteNonQuery();
                Connexion.conn.Close();
                return 1;   
               
            
        }
        public List<Clients> GetClient()
        {
            string query = "select * from Client ";
            Connexion.conn.Open();
            Connexion.command = Connexion.conn.CreateCommand();
            Connexion.command.CommandText = query;
            var reader = Connexion.command.ExecuteReader();
            //Connexion.conn.Close();
            Clients clients = new Clients();
            List< Clients> liste = new List< Clients>();
            //Connexion.conn.Open();
            while (reader.Read())
            {
                clients = new Clients();
                clients.Id_client = reader.GetInt32(0);
                clients.Nom = reader.GetString(1);
                clients.Prenom = reader.GetString(2);
                clients.Adresse = reader.GetString(3);
                clients.Genre = reader.GetString(4);
                clients.Status = reader.GetString(5);
                clients.Telephone = reader.GetInt32(6);
                //break;


                liste.Add(clients);
                
            }
            Connexion.conn.Close();

            return liste;
        }
       
        public int GetLength()
        {
            string query = "select count(*) from Client";
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
