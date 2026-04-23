using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace StudioLoc
{
    public static class StudioService
    {
        /// <summary>
        /// Récupère tous les studios sous forme de liste d'objets.
        /// </summary>
        public static List<Studio> GetAll()
        {
            var studios = new List<Studio>();
            using (var connection = DbManager.GetConnection())
            {
                if (connection == null) return studios;

                string query = "SELECT * FROM studio";
                var command = new MySqlCommand(query, connection);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        studios.Add(MapReaderToStudio(reader));
                    }
                }
            }
            return studios;
        }

        /// <summary>
        /// Récupère les studios d'un village spécifique via une DataTable (pour affichage Grille).
        /// </summary>
        /// <summary>
        /// Récupère la liste des studios pour un village donné (inclut le nom de la commune).
        /// </summary>
        public static List<Studio> GetStudiosByVillage(int villageId)
        {
            var studios = new List<Studio>();
            using (var connection = DbManager.GetConnection())
            {
                // On récupère s.* pour les données du studio et c.nom_commune pour l'affichage
                string query = @"SELECT s.*, c.nom_commune 
                         FROM studio s
                         JOIN village v ON s.num_village = v.num_village
                         JOIN commune c ON v.num_commune = c.num_commune
                         WHERE s.num_village = @villageId";

                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@villageId", villageId);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var studio = MapReaderToStudio(reader);
                        studio.VillageName = reader.GetString("nom_commune");
                        studios.Add(studio);
                    }
                }
            }
            return studios;
        }

        /// <summary>
        /// Récupère la liste des objets Studio d'un village.
        /// </summary>
        public static List<Studio> GetListByVillage(int villageId)
        {
            var studios = new List<Studio>();
            using (var connection = DbManager.GetConnection())
            {
                if (connection == null) return studios;

                string query = "SELECT * FROM studio WHERE num_village = @villageId";
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@villageId", villageId);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        studios.Add(MapReaderToStudio(reader));
                    }
                }
            }
            return studios;
        }

        /// <summary>
        /// Crée un nouveau studio en base.
        /// </summary>
        public static bool Create(Studio studio)
        {
            using (var connection = DbManager.GetConnection())
            {
                if (connection == null) return false;

                string query = @"INSERT INTO studio (nom_studio, num_village, nb_places_studio, prix_saison_studio, prix_hors_saison_studio) 
                                VALUES (@name, @villageId, @capacity, @highPrice, @lowPrice)";

                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", studio.Name);
                command.Parameters.AddWithValue("@villageId", studio.VillageId);
                command.Parameters.AddWithValue("@capacity", studio.Capacity);
                command.Parameters.AddWithValue("@highPrice", studio.HighSeasonPrice);
                command.Parameters.AddWithValue("@lowPrice", studio.LowSeasonPrice);

                return command.ExecuteNonQuery() > 0;
            }
        }

        /// <summary>
        /// Met à jour un studio existant.
        /// </summary>
        public static bool Update(Studio studio)
        {
            using (var connection = DbManager.GetConnection())
            {
                if (connection == null) return false;

                string query = @"UPDATE studio SET nom_studio = @name, nb_places_studio = @capacity, 
                                 prix_saison_studio = @highPrice, prix_hors_saison_studio = @lowPrice 
                                 WHERE num_studio = @id";

                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", studio.Name);
                command.Parameters.AddWithValue("@capacity", studio.Capacity);
                command.Parameters.AddWithValue("@highPrice", studio.HighSeasonPrice);
                command.Parameters.AddWithValue("@lowPrice", studio.LowSeasonPrice);
                command.Parameters.AddWithValue("@id", studio.Id);

                return command.ExecuteNonQuery() > 0;
            }
        }

        /// <summary>
        /// Supprime un studio par son identifiant.
        /// </summary>
        public static bool Delete(int id)
        {
            using (var connection = DbManager.GetConnection())
            {
                if (connection == null) return false;

                string query = "DELETE FROM studio WHERE num_studio = @id";
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                return command.ExecuteNonQuery() > 0;
            }
        }

        /// <summary>
        /// Méthode utilitaire pour mapper le résultat SQL vers l'objet C#.
        /// </summary>
        private static Studio MapReaderToStudio(MySqlDataReader reader)
        {
            return new Studio
            {
                Id = reader.GetInt32("num_studio"),
                Name = reader.GetString("nom_studio"),
                VillageId = reader.GetInt32("num_village"),
                Capacity = reader.GetInt32("nb_places_studio"),
                HighSeasonPrice = reader.GetDecimal("prix_saison_studio"),
                LowSeasonPrice = reader.GetDecimal("prix_hors_saison_studio")
            };
        }
    }
}