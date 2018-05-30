package repository;

import source.DB;

import java.sql.ResultSet;
import java.sql.SQLException;

public class UserDao {

    /**
     * Register a user to the system.
     * The user identifier is unique.
     *
     * @param name identifier of a user
     * @param password password
     * @return true if the user has been successfully registered, false otherwise
     */
    public static void register(String name, String password) {
        DB.insert(String.format("INSERT INTO USERS(NAME, PASSWORD) values('%s', '%s')", name, password));
    }

    /**
     * Check if a user
     * @param name identifier of a user
     * @param password password
     * @return true if the user exists, false otherwise
     */
        public static String exist(String name, String password) {
        ResultSet rs = DB.execute(String.format("SELECT ID as total FROM USERS where name='%s' AND password='%s'", name, password));
        try {
            rs.next();
            return String.valueOf(rs.getInt("ID"));
        } catch (SQLException e) {
            e.printStackTrace();
            return "";
        }
    }

}
