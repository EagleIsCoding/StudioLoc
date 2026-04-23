using System;
using MySql.Data.MySqlClient; 
using System.Windows.Forms;    

namespace StudioLoc
{
    internal class DbManager
    {
        private static string server = "172.16.193.254";
        private static string database = "StudioLoc";
        private static string user = "adminloc";
        private static string password = "azertysio"; 
        private static string port = "3306";

        private static string connectionString = $"server={server};port={port};database={database};uid={user};pwd={password};";

        public static MySqlConnection GetConnection()
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de connexion à la base de données : " + ex.Message);
                return null;
            }
        }
    }
}