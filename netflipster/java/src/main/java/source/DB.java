package source;

import java.sql.*;

public class DB {
    private static final String url = "jdbc:h2:mem:test;INIT=RUNSCRIPT FROM 'classpath:/init.sql'";
    private static Connection conn = null;

    private static Connection instance() {
        if (conn != null)
            return conn;

        try {
            Class.forName("org.h2.Driver");
        } catch (ClassNotFoundException e) {
            e.printStackTrace();
        }

        try {
            conn = DriverManager.getConnection(url);
        } catch (SQLException e) {
            e.printStackTrace();
        }
        return conn;
    }

    public static ResultSet execute(String query) {
        try {
            Statement stmt = instance().createStatement();
            return stmt.executeQuery(query);
        } catch (SQLException e) {
            e.printStackTrace();
            return null;
        }
    }

    public static void insert(String query) {
        try {
            Statement stmt = instance().createStatement();
            stmt.execute(query);
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }
}
