using System.Collections.Generic;

namespace Netflipster.Repository
{
    public class VhsDao
    {
        public static IEnumerable<string> GetIdentifiers()
        {
            using (var cnx = DB.GetConnection())
            using (var rs = DB.ExecuteQuery("SELECT ID FROM VHS WHERE ID > 0", cnx))
            {
                while (rs.Read())
                {
                    var id = (long)rs["ID"];
                    yield return id.ToString();
                }
            }
        }

        public static string GetVhsNameById(string id)
        {
            return DB.ExecuteScalar<string>($"SELECT NAME FROM VHS WHERE ID = {id}");
        }
    }
}
