using System.Configuration;
using System.Data.SQLite;

namespace Netflix2.repository
{
    public static class DB
    {
        public static bool Insert(string query)
        {
            using (var cnx = GetConnection())
            {
                cnx.Open();
                using (var cmd = cnx.CreateCommand())
                {
                    cmd.CommandText = query;
                    var result = cmd.ExecuteNonQuery();
                    return result == 1;
                }
            }
        }

        public static T ExecuteScalar<T>(string query)
        {
            using (var cnx = GetConnection())
            {
                cnx.Open();
                using (var cmd = cnx.CreateCommand())
                {
                    cmd.CommandText = query;
                    return (T)cmd.ExecuteScalar();
                }
            }
        }

        public static SQLiteDataReader ExecuteQuery(string query, SQLiteConnection cnx)
        {
            cnx.Open();
            using (var cmd = cnx.CreateCommand())
            {
                cmd.CommandText = query;
                return cmd.ExecuteReader();
            }
        }

        public static SQLiteConnection GetConnection()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Netflix2"].ConnectionString;
            return new SQLiteConnection(connectionString);
        }
    }
}