using Microsoft.Extensions.Configuration;
using System.Data.SQLite;

namespace Netflipster.Repository
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
            IConfigurationRoot configuration = GetConfiguration();
            string connectionString = configuration.GetConnectionString("Netflipster");
            return new SQLiteConnection(connectionString);
        }

        private static IConfigurationRoot GetConfiguration()
        {
            var builder = new ConfigurationBuilder()
               .AddJsonFile("Netflipster.json", optional: false, reloadOnChange: true);
            var configuration = builder.Build();
            return configuration;
        }
    }
}