namespace Netflix2.repository
{
    public class UserDao
    {
        /**
         * Register a user to the system.
         * The user identifier is unique.
         *
         * @param userId identifier of a user
         * @param password password
         * @return true if the user has been successfully registered, false otherwise
         */
        public static bool Register(string userId, string password)
        {
            return DB.Insert($"INSERT INTO USERS(ID, PASSWORD) values('{userId}', '{password}')");
        }

        /**
         * Check if a user
         * @param userId identifier of a user
         * @param password password
         * @return true if the user exists, false otherwise
         */
        public static bool Exist(string userId, string password)
        {
            var numberOfUsers = DB.ExecuteScalar<long>($"SELECT count(1) FROM USERS where id='{userId}' AND password='{password}'");
            return numberOfUsers > 0;
        }
    }
}
