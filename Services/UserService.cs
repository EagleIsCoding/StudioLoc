using MySql.Data.MySqlClient;

namespace StudioLoc
{
    public static class UserService
    {
        public static bool Login(string email, string passwordSaisi)
        {
            using (MySqlConnection conn = DbManager.GetConnection())
            {
                if (conn == null) return false;

                string query = "SELECT password, roles FROM user WHERE email = @email LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@email", email);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string hashBDD = reader.GetString("password");
                        string rolesJson = reader.GetString("roles");

                        if (BCrypt.Net.BCrypt.Verify(passwordSaisi, hashBDD))
                        {
                            return rolesJson.Contains("ROLE_ADMIN");
                        }
                    }
                }
            }
            return false;
        }
    }
}