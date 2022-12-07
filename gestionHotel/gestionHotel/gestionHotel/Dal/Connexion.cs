using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace gestionHotel.Dal
{
    public class Connexion
    {
        public static string connect = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Downloads\gestionHotel\gestionHotel\gestionHotel\gestionHotel.mdf;Integrated Security = True; Connect Timeout = 30";
        public static SqlConnection conn = new SqlConnection(connect);
        public static SqlCommand command;
    }
}
