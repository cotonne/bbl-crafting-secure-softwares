package repository;

import source.DB;

import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.Collection;

public class DvdDao {

    /**
     * Get the list of DVDs identifiers
     *
     * @return list of DVD identifiers
     */
    public static Collection<String> getIdentifiers() {
        Collection<String> dvds = new ArrayList<>();
        ResultSet rs = DB.execute("SELECT ID FROM DVDS WHERE ID > 0");
        try {
            while (rs.next()) {
                int id = rs.getInt("ID");
                dvds.add(String.valueOf(id));
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }
        return dvds;
    }

    /**
     * Get the name of the DVD
     *
     * @param id identifier of the DVD
     * @return list of DVD names
     */
    public static String getDvdNameById(String id) {
        Collection<String[]> dvds = new ArrayList<>();
        ResultSet rs = DB.execute(String.format("SELECT NAME FROM DVDS WHERE ID = %s", id));
        try {
            rs.next();
            return rs.getString("NAME");
        } catch (SQLException e) {
            e.printStackTrace();
        }
        return null;
    }
}
