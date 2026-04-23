using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace StudioLoc
{
    public static class VillageService
    {
        /// <summary>
        /// Récupère tous les villages enregistrés en base de données.
        /// </summary>
        public static List<Village> GetAll()
        {
            var villages = new List<Village>();

            using (var connection = DbManager.GetConnection())
            {
                string query = "SELECT num_village, nom_village FROM village ORDER BY nom_village ASC";

                var command = new MySqlCommand(query, connection);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        villages.Add(new Village
                        {
                            Id = reader.GetInt32("num_village"),
                            Name = reader.GetString("nom_village")
                        });
                    }
                }
            }
            return villages;
        }
    }
}