using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace StudioLoc
{
    public static class ReservationService
    {
        /// <summary>
        /// Récupère la liste complète des réservations avec le nom du client et du studio.
        /// </summary>
        public static List<Reservation> GetAll()
        {
            var reservations = new List<Reservation>();

            using (var connection = DbManager.GetConnection())
            {
                // Requête SQL sur la base de données (en français)
                string query = @"SELECT r.*, c.nom_client, s.nom_studio 
                                 FROM reservation r
                                 JOIN client c ON r.id_user = c.id_user
                                 JOIN studio s ON r.num_studio = s.num_studio
                                 ORDER BY r.date_debut_reservation DESC";

                var command = new MySqlCommand(query, connection);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Mapping des colonnes FR vers les propriétés EN
                        reservations.Add(new Reservation
                        {
                            Id = reader.GetInt32("num_reservation"),
                            CreatedAt = reader.GetDateTime("date_reservation"),
                            StartDate = reader.GetDateTime("date_debut_reservation"),
                            EndDate = reader.GetDateTime("date_fin_reservation"),
                            GuestCount = reader.GetInt32("nb_personnes_reservation"),
                            ClientName = reader.GetString("nom_client"),
                            StudioName = reader.GetString("nom_studio")
                        });
                    }
                }
            }
            return reservations;
        }

        /// <summary>
        /// Met à jour les dates et le nombre de personnes d'une réservation existante.
        /// </summary>
        public static bool Update(Reservation reservation)
        {
            using (var connection = DbManager.GetConnection())
            {
                if (connection == null) return false;

                string query = @"UPDATE reservation 
                                 SET date_debut_reservation = @start, 
                                     date_fin_reservation = @end, 
                                     nb_personnes_reservation = @guests
                                 WHERE num_reservation = @id";

                var command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@start", reservation.StartDate);
                command.Parameters.AddWithValue("@end", reservation.EndDate);
                command.Parameters.AddWithValue("@guests", reservation.GuestCount);
                command.Parameters.AddWithValue("@id", reservation.Id);

                return command.ExecuteNonQuery() > 0;
            }
        }

        /// <summary>
        /// Supprime une réservation à partir de son identifiant unique.
        /// </summary>
        public static bool Delete(int id)
        {
            using (var connection = DbManager.GetConnection())
            {
                string query = "DELETE FROM reservation WHERE num_reservation = @id";
                var command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                return command.ExecuteNonQuery() > 0;
            }
        }
    }
}