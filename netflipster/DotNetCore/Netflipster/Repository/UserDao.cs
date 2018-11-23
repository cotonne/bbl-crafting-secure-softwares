using System;
using System.Collections.Generic;
using System.Text;

namespace Netflipster.Repository
{
    public class UserDao
    {
        /// <summary>Register a user to the system.</summary>
        /// <param name="name">identifier of a user</param>
        /// <param name="password">password</param>
        /// <returns>true if the user has been successfully registered, false otherwise</returns>
        /// <remarks>The user identifier is unique.</remarks>
        public static bool Register(string name, string password)
        {
            return DB.Insert($"INSERT INTO USERS(NAME, PASSWORD) values('{name}', '{password}')");
        }

        /// <summary>Check if a user exists and get her identifier</summary>
        /// <param name="name">identifier of a user</param>
        /// <param name="password">password</param>
        /// <returns>the user identifier if the user exists; empty string otherwise.</returns>
        public static string FindId(string name, string password)
        {
            using (var cnx = DB.GetConnection())
            {
                using (var rs =
                    DB.ExecuteQuery($"SELECT ID FROM USERS where NAME='{name}' AND password='{password}'", cnx))
                {
                    if (rs.Read())
                    {
                        return rs.GetInt64(0).ToString();
                    }

                    return string.Empty;
                }
            }
        }
    }
}
